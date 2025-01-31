using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Tuttle
{
    public partial class viewForm : Form
    {
        public List<DeskQuote> Quotes { get; set; }
        public viewForm()
        {
            InitializeComponent();
        }

        private void quoteClosetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);


            allQuotesTextBox.Text = string.Empty;
            foreach (JToken line in array)
            {
                //Console.WriteLine(line);
                allQuotesTextBox.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                allQuotesTextBox.Text += "\r\n";
                allQuotesTextBox.Text += "\r\n";
            }


            
            //int quoteNumber = 0;
            //if (Quotes == null || Quotes.Count == 0)
            //{
            //    MessageBox.Show("No quotes to display.");
            //    return;
            //}

            //foreach (DeskQuote item in Quotes)
            //{
            //    allQuotesTextBox.Text += $"{quoteNumber}. ";
            //    allQuotesTextBox.Text += item.GetString();
            //    allQuotesTextBox.Text += "\r\n";
            //    allQuotesTextBox.Text += "\r\n";
            //}

            //allQuotesTextBox.Text = string.Join("\r\n", Quotes.Select(q => q.GetString()));
        }
    }
}
