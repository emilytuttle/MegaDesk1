using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tuttle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newQuoteButton_Click(object sender, EventArgs e)
        {
            var quoteForm = new NewQuoteForm();
            quoteForm.Show();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            var quoteForm = new viewForm();
            quoteForm.Show();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            var quoteForm = new searchQuotes();
            quoteForm.Show();

        }
    }
}
