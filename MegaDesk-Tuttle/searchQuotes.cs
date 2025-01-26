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
    public partial class searchQuotes : Form
    {
        public List<DeskQuote> Quotes { get; set; }
        public searchQuotes()
        {
            InitializeComponent();
        }

        private void quoteClosetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void laminateSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            int quoteNumber = 0;
            if (Quotes == null || Quotes.Count == 0)
            {
                MessageBox.Show("No quotes to display.");
                return;
            }

            foreach (DeskQuote item in Quotes)
            {
                if (item.GetSurfaceMaterial() == "laminate" || item.GetSurfaceMaterial() == "Laminate")
                {
                    textBox1.Text += $"{quoteNumber}. ";
                    textBox1.Text += item.GetString();
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
                
            }

        }

        private void oakSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            int quoteNumber = 0;
            if (Quotes == null || Quotes.Count == 0)
            {
                MessageBox.Show("No quotes to display.");
                return;
            }

            foreach (DeskQuote item in Quotes)
            {
                if (item.GetSurfaceMaterial() == "oak" || item.GetSurfaceMaterial() == "Oak")
                {
                    textBox1.Text += $"{quoteNumber}. ";
                    textBox1.Text += item.GetString();
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }

            }
        }

        private void rosewoodSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            int quoteNumber = 0;
            if (Quotes == null || Quotes.Count == 0)
            {
                MessageBox.Show("No quotes to display.");
                return;
            }

            foreach (DeskQuote item in Quotes)
            {
                if (item.GetSurfaceMaterial() == "rosewood" || item.GetSurfaceMaterial() == "Rosewood")
                {
                    textBox1.Text += $"{quoteNumber}. ";
                    textBox1.Text += item.GetString();
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }

            }
        }

        private void veneerSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            int quoteNumber = 0;
            if (Quotes == null || Quotes.Count == 0)
            {
                MessageBox.Show("No quotes to display.");
                return;
            }

            foreach (DeskQuote item in Quotes)
            {
                if (item.GetSurfaceMaterial() == "veneer" || item.GetSurfaceMaterial() == "Veneer")
                {
                    textBox1.Text += $"{quoteNumber}. ";
                    textBox1.Text += item.GetString();
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }

            }
        }

        private void pineSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            int quoteNumber = 0;
            if (Quotes == null || Quotes.Count == 0)
            {
                MessageBox.Show("No quotes to display.");
                return;
            }

            foreach (DeskQuote item in Quotes)
            {
                if (item.GetSurfaceMaterial() == "pine" || item.GetSurfaceMaterial() == "Pine")
                {
                    textBox1.Text += $"{quoteNumber}. ";
                    textBox1.Text += item.GetString();
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }

            }
        }
    }
}
