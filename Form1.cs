using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        private List<CreditCard> creditCards = new List<CreditCard>(); //List of credit cards
        private string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ReadFile
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; //Clear the existing list and ListBox
                creditCards.Clear();
                listBox1.Items.Clear();

                var lines = File.ReadAllLines(filePath); //Read file content and populate credit cards listbox
                foreach (var line in lines)
                {
                    var parts = line.Split(','); 
                    if (parts.Length == 3)
                    {
                        var card = new CreditCard(parts[0], decimal.Parse(parts[1]), double.Parse(parts[2]));
                        creditCards.Add(card);
                        listBox1.Items.Add(card.Name); //Add card name to ListBox
                    }
                }

                creditCards = creditCards.OrderBy(c => c.Name).ToList(); //Sort alphabetically and select the first card
                if (listBox1.Items.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                }

                
            }
        }
        

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCardName = listBox1.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete selected card?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                CreditCard cardToRemove = null; //Delete Card 
                foreach (var card in creditCards)
                {
                    if (card.Name.Equals(selectedCardName, StringComparison.OrdinalIgnoreCase))
                    {
                        cardToRemove = card;
                        break;
                    }
                }
                if (cardToRemove != null)
                {
                    creditCards.Remove(cardToRemove);
                    listBox1.Items.Remove(selectedCardName);
                    if (listBox1.Items.Count > 0)
                    {
                        listBox1.SelectedIndex = 0; //Select first card
                    }
                    MessageBox.Show("Selected Card has been deleted.");
                }
                else
                {
                    MessageBox.Show("Deletion has been canceled.");
                }
            }
        }

        private void btnAnother_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string newName = prompt.CreditName();
                decimal amountOwed = prompt.Owed();
                decimal rate = prompt.Rate();

                bool cardExists = false;
                foreach (var card in creditCards)
                {
                    if (card.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)) //Check if the card already exists (ignoring case)
                    {
                        cardExists = true;
                        break;
                    }
                }

                if (cardExists)
                {
                    MessageBox.Show("A card with this name already exists.");
                }
                else
                {
                    var newCard = new CreditCard(newName, amountOwed, (double)rate);
                    creditCards.Add(newCard);
                    listBox1.Items.Add(newCard.Name); //Add the new card to ListBox
                    listBox1.SelectedItem = newCard.Name; //Select the newly added card
                }
            }
        }

        private string fileName = "";
        private void btnExist_Click(object sender, EventArgs e) //Exit Application & Save to a file
        {
            if (string.IsNullOrEmpty(fileName)) //Check if the same file name already exists
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                    saveFileDialog.Title = "Save to File";  //Ask for a file name
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog.FileName;
                    }
                }
                using (StreamWriter sw = new StreamWriter(fileName)) //Save to a file code
                {
                    foreach (var card in creditCards)
                    {
                        sw.WriteLine($"{card.Name},{card.AmountOwed},{card.InterestRate}");
                    }
                   
                }

                MessageBox.Show("Succesfully Saved.");
            }
            //Exit Application
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                label8.Text = "";
                label7.Text = "";
                label6.Text = "";
                label5.Text = "";
                return;
            }

            var selectedCardName = listBox1.SelectedItem.ToString();
            CreditCard selectedCard = null;
            foreach (var card in creditCards)
            {
                if (card.Name.Equals(selectedCardName, StringComparison.OrdinalIgnoreCase))
                {
                    selectedCard = card;
                    break; 
                }
            }

            if (selectedCard != null)
            {
                label8.Text = $"{selectedCard.Name}"; //Update the labels
                label7.Text = $"${selectedCard.AmountOwed:N2}"; //N2;Comma & Two decimal points
                label6.Text = $"{selectedCard.InterestRate} %";

                // Calculate the interest owed
                double interestOwed = (double)selectedCard.AmountOwed * (selectedCard.InterestRate / 100);
                label5.Text = $"${interestOwed:F2}"; //F2;Two decimal points
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string selectedCardName = listBox1.SelectedItem.ToString();
            CreditCard selectedCard = null;
            foreach (var card in creditCards)
            {
                if (card.Name.Equals(selectedCardName, StringComparison.OrdinalIgnoreCase))
                {
                    selectedCard = card;
                    break;
                }
            }
            if (selectedCard != null)
            {
                using (PromptClick promptClick = new PromptClick(selectedCard.Name, selectedCard.AmountOwed))
                {
                    if (promptClick.ShowDialog() == DialogResult.OK)
                    {
                        decimal newAmountOwed = selectedCard.AmountOwed - promptClick.Amount; //Update the amount owed
                        selectedCard.AmountOwed = newAmountOwed;

                        label8.Text = $"{selectedCard.Name}";
                        label7.Text = $"${selectedCard.AmountOwed:N2}";
                        label6.Text = $"{selectedCard.InterestRate}";

                        double interestOwed = (double)selectedCard.AmountOwed * (selectedCard.InterestRate / 100);
                        label5.Text = $"${interestOwed:F2}";

                        listBox1.Items[listBox1.SelectedIndex] = selectedCard.Name; //Update the listbox

                    }
                }
            }
        }
    }
}
