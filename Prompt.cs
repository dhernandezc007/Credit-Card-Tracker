using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        private void tbPromptName_TextChanged(object sender, EventArgs e)
        {

        }

        string creditname = "";
        decimal rate, owed = 0;

        public String CreditName()
        {
            creditname = tbPromptName.Text;
            return creditname;
        }

        public decimal Rate() 
        {
            rate = decimal.Parse(tbPromptRate.Text);
            return rate;
        }

        public decimal Owed()
        {
            owed = decimal.Parse(tbPromptOwed.Text);
            return owed;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
            
    }
}
