using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

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
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);

            textBox1.Text = string.Empty;
            foreach (JToken line in array)
            {
                string surface = line["_surfaceMaterial"].ToString();
                if (surface == "laminate" || surface == "Laminate")
                {
                    textBox1.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
            }
        }

        private void oakSearchButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);

            textBox1.Text = string.Empty;
            foreach (JToken line in array)
            {
                string surface = line["_surfaceMaterial"].ToString();
                if (surface == "oak" || surface == "Oak")
                {
                    textBox1.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
            }
        }

        private void rosewoodSearchButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);

            textBox1.Text = string.Empty;
            foreach (JToken line in array)
            {
                string surface = line["_surfaceMaterial"].ToString();
                if (surface == "rosewood" || surface == "Rosewood")
                {
                    textBox1.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
            }
        }

        private void veneerSearchButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);

            textBox1.Text = string.Empty;
            foreach (JToken line in array)
            {
                string surface = line["_surfaceMaterial"].ToString();
                if (surface == "veneer" || surface == "veneer")
                {
                    textBox1.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
            }
        }

        private void pineSearchButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\emily\source\repos\TeamMegaDesk\MegaDesk-Tuttle\quotes.json";

            var initialJson = File.ReadAllText(path);
            var array = JArray.Parse(initialJson);

            textBox1.Text = string.Empty;
            foreach (JToken line in array)
            {
                string surface = line["_surfaceMaterial"].ToString();
                if (surface == "pine" || surface == "Pine")
                {
                    textBox1.Text += $"Name: {line["_name"]}, Width: {line["_deskWidth"]}, Depth: {line["_deskDepth"]}, Drawers: {line["_numDrawers"]}, Surface: {line["_surfaceMaterial"]}, Rush: {line["_rushDays"]}, Price: ${line["_finalPrice"]}";
                    textBox1.Text += "\r\n";
                    textBox1.Text += "\r\n";
                }
            }
        }
    }
}
