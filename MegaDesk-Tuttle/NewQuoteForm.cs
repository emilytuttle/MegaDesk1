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
    public partial class NewQuoteForm : Form
    {
        public NewQuoteForm()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numberDrawersInput.Value > 7)
            {
                MessageBox.Show("You can only have 7 drawers!");
            }

        }

        public void quoteSubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum Rush
        {
            threeDays = 3,
            fiveDays = 5,
            sevenDays = 7
        }

        public List<DeskQuote> allDeskQuotes = new List<DeskQuote> { };


        public void button1_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            decimal deskWidth = deskWidthInput.Value;
            decimal deskDepth = deskDepthInput.Value;
            decimal numDrawers = numberDrawersInput.Value;
            decimal surfaceArea = deskWidth * deskDepth;
            string surfaceType = surfaceInput.Text;
            decimal rushValue = rushInputField.Value;
            decimal basePrice = 200;
            decimal drawerRate = 50;
            decimal surfaceTypeCharge = 0;
            decimal finalPrice;
            decimal rushPrice = 0;
            decimal surfaceAreaCharge = deskDepth * deskWidth;
            decimal priceBeforeMaterial = basePrice + surfaceAreaCharge + (numDrawers * drawerRate);

           if (surfaceType == "oak")
            {
                surfaceTypeCharge = 200;
            } else if (surfaceType == "laminate")
            {
                surfaceTypeCharge = 100;
            }
            else if (surfaceType == "pine")
            {
                surfaceTypeCharge = 50;
            }
            else if (surfaceType == "rosewood") 
            {
                surfaceTypeCharge = 300;
            }
            else if (surfaceType == "veneer")
            {
                surfaceTypeCharge = 125;
            }

           if (surfaceArea < 1000)
            {
                if (rushValue == 3) {rushPrice = 60;
                }else if (rushValue == 5) { rushPrice = 40; }
                else if (rushValue ==7) { rushPrice = 30; }
            } else if (surfaceArea > 1000 && surfaceArea <= 2000)
            {
                if (rushValue == 3)
                {
                    rushPrice = 70;
                }
                else if (rushValue == 5) { rushPrice = 50; }
                else if (rushValue == 7) { rushPrice = 35; }
            }
            else if (surfaceArea > 2000)
            {
                if (rushValue == 3)
                {
                    rushPrice = 80;
                }
                else if (rushValue == 5) { rushPrice = 60; }
                else if (rushValue == 7) { rushPrice = 40; }
            }
            finalPrice = priceBeforeMaterial + surfaceTypeCharge + rushPrice;
            calculatedCost.Text = finalPrice.ToString();

            DeskQuote quote = new DeskQuote(name, deskWidth, deskDepth, numDrawers, surfaceType, rushValue, finalPrice );
            allDeskQuotes.Add( quote );

            //  pass the list of quotes to the viewForm
            viewForm view = new viewForm();
            view.Quotes = allDeskQuotes;  // Set the list of quotes
            view.Show();  // Show the viewForm

            //  pass the list of quotes to the viewForm
            searchQuotes search = new searchQuotes();
            search.Quotes = allDeskQuotes;
            search.Show();


        }

        public void deskWidthInput_ValueChanged(object sender, EventArgs e)
        {
            if (deskWidthInput.Value <= 23 || deskWidthInput.Text.Length >= 97)
            {
                deskWidthInput.Value = 0;
                MessageBox.Show("Width must be between 24 and 96 inches!");
              //deskWidthInput.Focus();
                button1.Hide();
            }
            else
            {
                button1.Show();
            }
        }

        public void deskDepthInput_ValueChanged(object sender, EventArgs e)
        {
            if (deskDepthInput.Value <= 11 || deskDepthInput.Text.Length >=49)
            {
                deskDepthInput.Value = 0;
                MessageBox.Show("Width must be between 12 and 48 inches!");
                //skDepthInput.Focus();
                button1.Hide();

            }
            else
            {
                button1.Show();
            }

        }

        public void nameInput_TextChanged(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(nameInput.Text))
            {
                MessageBox.Show("Enter a name!");
                //nameInput.Focus();
                button1.Hide();
            }
            else
            {
                button1.Show();
            }
        }

  

        public void surfaceInput_TextChanged(object sender, EventArgs e)
        {
            if (!surfaceInput.Focus())
            {
                if (surfaceInput.Text != "laminate" || surfaceInput.Text != "oak" || surfaceInput.Text != "rosewood" || surfaceInput.Text != "veneer" || surfaceInput.Text != "pine")
                {
                    MessageBox.Show("Options are laminate, oak, rosewood, veneer, or pine");

                    button1.Hide();
                }
                else
                {
                    button1.Show();
                }
            }
           
        }

        public void rushInput_TextChanged(object sender, EventArgs e)
        {
            //if (surfaceInput.Text !== 3 || surfaceInput.Text !=="5" || surfaceInput.Text != "7" || surfaceInput.Text != "0")
            //{
            //    MessageBox.Show("Options are 3, 5, 7, or 0");
            //    nameInput.Focus();
            //    button1.Hide();
            //}
            //else
            //{
            //    button1.Show();
            //}
        }
    }
}
