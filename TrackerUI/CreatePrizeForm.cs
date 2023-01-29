using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                var model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text,
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                foreach (var db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }


                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0"; 
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            var output = true;

            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if(placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool placeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);

            if(placeAmountValid == false)
            {
                output = false;
            }

            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(prizePercentageValid == false)
            {
                output = false;
            }


            if (prizeAmount < 1 && prizePercentage < 1)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
