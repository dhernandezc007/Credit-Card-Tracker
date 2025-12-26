using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class PromptClick : Form
    {
        public decimal Amount {  get; set; }
        public PromptClick(string creditCardName, decimal currentBalance)
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbAmount.Text, out decimal amount))
            {
                Amount = amount;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
