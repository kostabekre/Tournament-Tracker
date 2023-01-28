namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentBtn = new System.Windows.Forms.Button();
            this.CreateTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(99, 83);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(330, 41);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(129, 186);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(271, 28);
            this.loadExistingTournamentDropDown.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoEllipsis = true;
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(114, 148);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(301, 35);
            this.loadExistingTournamentLabel.TabIndex = 19;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentBtn
            // 
            this.loadTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loadTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.loadTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.loadTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loadTournamentBtn.Location = new System.Drawing.Point(169, 229);
            this.loadTournamentBtn.Name = "loadTournamentBtn";
            this.loadTournamentBtn.Size = new System.Drawing.Size(191, 44);
            this.loadTournamentBtn.TabIndex = 21;
            this.loadTournamentBtn.Text = "Load Tournament";
            this.loadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentBtn
            // 
            this.CreateTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CreateTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.CreateTournamentBtn.Location = new System.Drawing.Point(159, 309);
            this.CreateTournamentBtn.Name = "CreateTournamentBtn";
            this.CreateTournamentBtn.Size = new System.Drawing.Size(211, 55);
            this.CreateTournamentBtn.TabIndex = 33;
            this.CreateTournamentBtn.Text = "Create Tournament";
            this.CreateTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 447);
            this.Controls.Add(this.CreateTournamentBtn);
            this.Controls.Add(this.loadTournamentBtn);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentBtn;
        private Button CreateTournamentBtn;
    }
}