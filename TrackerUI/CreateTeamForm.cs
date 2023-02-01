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
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberBtn_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text; 
                p.LastName = lastNameValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;
                p.EmailAddress = emailValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                cellphoneValue.Text = "";
                emailValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fiels.");
            }
        }

        private bool ValidateForm()
        {
            if(firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if(cellphoneValue.Text.Length == 0) 
            { 
                return false;
            }

            return true;
        }
    }
}
