﻿namespace TrackerUI
{
    partial class CreateTournament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPrizeBtn = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamBtn = new System.Windows.Forms.Button();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(271, 41);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentNameValue.Location = new System.Drawing.Point(12, 102);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(271, 27);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 64);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(222, 35);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.entryFeeValue.Location = new System.Drawing.Point(134, 173);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.PlaceholderText = "0";
            this.entryFeeValue.Size = new System.Drawing.Size(119, 27);
            this.entryFeeValue.TabIndex = 12;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 165);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(116, 35);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(12, 273);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(271, 28);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoEllipsis = true;
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 235);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(139, 35);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "SelectTeam";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(202, 247);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(81, 20);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addTeamBtn.Location = new System.Drawing.Point(85, 316);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(132, 44);
            this.addTeamBtn.TabIndex = 16;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createPrizeBtn.Location = new System.Drawing.Point(85, 377);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(132, 44);
            this.createPrizeBtn.TabIndex = 17;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 20;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(346, 100);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(272, 164);
            this.tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(346, 62);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(187, 35);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPrizeBtn
            // 
            this.deleteSelectedPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deleteSelectedPrizeBtn.Location = new System.Drawing.Point(634, 370);
            this.deleteSelectedPrizeBtn.Name = "deleteSelectedPrizeBtn";
            this.deleteSelectedPrizeBtn.Size = new System.Drawing.Size(108, 60);
            this.deleteSelectedPrizeBtn.TabIndex = 23;
            this.deleteSelectedPrizeBtn.Text = "Delete Selected";
            this.deleteSelectedPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizesLabel.Location = new System.Drawing.Point(346, 278);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(79, 35);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 20;
            this.prizesListBox.Location = new System.Drawing.Point(346, 318);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(272, 164);
            this.prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedTeamBtn
            // 
            this.deleteSelectedTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteSelectedTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deleteSelectedTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedTeamBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.deleteSelectedTeamBtn.Location = new System.Drawing.Point(634, 152);
            this.deleteSelectedTeamBtn.Name = "deleteSelectedTeamBtn";
            this.deleteSelectedTeamBtn.Size = new System.Drawing.Size(108, 60);
            this.deleteSelectedTeamBtn.TabIndex = 24;
            this.deleteSelectedTeamBtn.Text = "Delete Selected";
            this.deleteSelectedTeamBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTournamentBtn.Location = new System.Drawing.Point(254, 507);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(211, 55);
            this.createTournamentBtn.TabIndex = 25;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 574);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.deleteSelectedTeamBtn);
            this.Controls.Add(this.deleteSelectedPrizeBtn);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreateTournament";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamBtn;
        private Button createPrizeBtn;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPrizeBtn;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedTeamBtn;
        private Button createTournamentBtn;
    }
}