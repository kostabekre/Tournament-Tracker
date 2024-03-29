﻿using System;
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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester callingForm)
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
            this.callingForm = callingForm;
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel() { FirstName = "Tim", LastName = "Corey"});
            availableTeamMembers.Add(new PersonModel() { FirstName = "Sue", LastName = "Storm"});

            selectedTeamMembers.Add(new PersonModel() { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel() { FirstName = "Jon", LastName = "Martin" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource= null;
            selectTeamMemberDropDown.DataSource= availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource= null;
            teamMembersListBox.DataSource= selectedTeamMembers;
            teamMembersListBox.DisplayMember= "FullName";
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
                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p == null) return;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
        }

        private void removeSelectedMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p == null) return;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists();
        }

        private void createTeamBtn_Click(object sender, EventArgs e)
        {
            var t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
