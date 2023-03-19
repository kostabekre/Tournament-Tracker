namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneLabel = new Label();
            teamOneScore = new Label();
            teamOneScoreValue = new TextBox();
            vsLabel = new Label();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoLabel = new Label();
            scoreBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.LightSeaGreen;
            headerLabel.Location = new Point(33, 43);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(184, 41);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.LightSeaGreen;
            tournamentNameLabel.Location = new Point(223, 43);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(128, 41);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.LightSeaGreen;
            roundLabel.Location = new Point(33, 108);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(87, 35);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(126, 117);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(206, 28);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = Color.LightSeaGreen;
            unplayedOnlyCheckbox.Location = new Point(126, 160);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(160, 32);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 20;
            matchupListBox.Location = new Point(33, 217);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(299, 244);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneLabel.ForeColor = Color.LightSeaGreen;
            teamOneLabel.Location = new Point(374, 217);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(154, 35);
            teamOneLabel.TabIndex = 6;
            teamOneLabel.Text = "<team one>";
            // 
            // teamOneScore
            // 
            teamOneScore.AutoSize = true;
            teamOneScore.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScore.ForeColor = Color.LightSeaGreen;
            teamOneScore.Location = new Point(374, 268);
            teamOneScore.Name = "teamOneScore";
            teamOneScore.Size = new Size(77, 35);
            teamOneScore.TabIndex = 7;
            teamOneScore.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreValue.ForeColor = Color.LightSeaGreen;
            teamOneScoreValue.Location = new Point(457, 277);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(125, 27);
            teamOneScoreValue.TabIndex = 8;
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            vsLabel.ForeColor = Color.LightSeaGreen;
            vsLabel.Location = new Point(441, 322);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(64, 35);
            vsLabel.TabIndex = 9;
            vsLabel.Text = "-VS-";
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.ForeColor = Color.LightSeaGreen;
            teamTwoScoreValue.Location = new Point(457, 428);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(125, 27);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.LightSeaGreen;
            teamTwoScoreLabel.Location = new Point(374, 419);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(77, 35);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = Color.LightSeaGreen;
            teamTwoLabel.Location = new Point(374, 368);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(153, 35);
            teamTwoLabel.TabIndex = 10;
            teamTwoLabel.Text = "<team two>";
            // 
            // scoreBtn
            // 
            scoreBtn.FlatAppearance.BorderColor = Color.Black;
            scoreBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            scoreBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            scoreBtn.FlatStyle = FlatStyle.Flat;
            scoreBtn.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            scoreBtn.ForeColor = Color.LightSeaGreen;
            scoreBtn.Location = new Point(618, 319);
            scoreBtn.Name = "scoreBtn";
            scoreBtn.Size = new Size(108, 44);
            scoreBtn.TabIndex = 13;
            scoreBtn.Text = "SCORE";
            scoreBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 476);
            Controls.Add(scoreBtn);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(vsLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScore);
            Controls.Add(teamOneLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Name = "TournamentViewerForm";
            Text = "TournamentForm";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneLabel;
        private Label teamOneScore;
        private TextBox teamOneScoreValue;
        private Label vsLabel;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Button scoreBtn;
    }
}