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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneLabel = new System.Windows.Forms.Label();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(33, 43);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(184, 41);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentNameLabel.Location = new System.Drawing.Point(223, 43);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(128, 41);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.roundLabel.Location = new System.Drawing.Point(33, 108);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(87, 35);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(126, 117);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(206, 28);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(126, 160);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(160, 32);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 20;
            this.matchupListBox.Location = new System.Drawing.Point(33, 217);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(299, 244);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamOneLabel.Location = new System.Drawing.Point(374, 217);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.Size = new System.Drawing.Size(154, 35);
            this.teamOneLabel.TabIndex = 6;
            this.teamOneLabel.Text = "<team one>";
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScore.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamOneScore.Location = new System.Drawing.Point(374, 268);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(77, 35);
            this.teamOneScore.TabIndex = 7;
            this.teamOneScore.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamOneScoreValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamOneScoreValue.Location = new System.Drawing.Point(457, 277);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(125, 27);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.vsLabel.Location = new System.Drawing.Point(441, 322);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(64, 35);
            this.vsLabel.TabIndex = 9;
            this.vsLabel.Text = "-VS-";
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamTwoScoreValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamTwoScoreValue.Location = new System.Drawing.Point(457, 428);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 27);
            this.teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(374, 419);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(77, 35);
            this.teamTwoScoreLabel.TabIndex = 11;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamTwoLabel.Location = new System.Drawing.Point(374, 368);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(153, 35);
            this.teamTwoLabel.TabIndex = 10;
            this.teamTwoLabel.Text = "<team two>";
            // 
            // scoreBtn
            // 
            this.scoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.scoreBtn.Location = new System.Drawing.Point(618, 319);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(108, 44);
            this.scoreBtn.TabIndex = 13;
            this.scoreBtn.Text = "SCORE";
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 476);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.teamOneLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentForm";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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