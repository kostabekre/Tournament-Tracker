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
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember= "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember= "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t == null) return;

            availableTeams.Remove(t);
            selectedTeams.Add(t);

            WireUpLists();
        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            var frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedTeamBtn_Click(object sender, EventArgs e)
        {
            var t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t == null) return;

            selectedTeams.Remove(t);
            availableTeams.Add(t);

            WireUpLists();
        }

        private void removeSelectedPrizeBtn_Click(object sender, EventArgs e)
        {

            var p = (PrizeModel)prizesListBox.SelectedItem;

            if (p == null) return;

            selectedPrizes.Remove(p);

            WireUpLists();
        }
    }
}
