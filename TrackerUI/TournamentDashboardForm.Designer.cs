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
            headerLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentBtn = new Button();
            CreateTournamentBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.LightSeaGreen;
            headerLabel.Location = new Point(99, 83);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(330, 41);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(129, 186);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(271, 28);
            loadExistingTournamentDropDown.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoEllipsis = true;
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.LightSeaGreen;
            loadExistingTournamentLabel.Location = new Point(114, 148);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(301, 35);
            loadExistingTournamentLabel.TabIndex = 19;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentBtn
            // 
            loadTournamentBtn.FlatAppearance.BorderColor = Color.Black;
            loadTournamentBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            loadTournamentBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            loadTournamentBtn.FlatStyle = FlatStyle.Flat;
            loadTournamentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentBtn.ForeColor = Color.LightSeaGreen;
            loadTournamentBtn.Location = new Point(169, 229);
            loadTournamentBtn.Name = "loadTournamentBtn";
            loadTournamentBtn.Size = new Size(191, 44);
            loadTournamentBtn.TabIndex = 21;
            loadTournamentBtn.Text = "Load Tournament";
            loadTournamentBtn.UseVisualStyleBackColor = true;
            loadTournamentBtn.Click += loadTournamentBtn_Click;
            // 
            // CreateTournamentBtn
            // 
            CreateTournamentBtn.FlatAppearance.BorderColor = Color.Black;
            CreateTournamentBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            CreateTournamentBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            CreateTournamentBtn.FlatStyle = FlatStyle.Flat;
            CreateTournamentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentBtn.ForeColor = Color.LightSeaGreen;
            CreateTournamentBtn.Location = new Point(159, 309);
            CreateTournamentBtn.Name = "CreateTournamentBtn";
            CreateTournamentBtn.Size = new Size(211, 55);
            CreateTournamentBtn.TabIndex = 33;
            CreateTournamentBtn.Text = "Create Tournament";
            CreateTournamentBtn.UseVisualStyleBackColor = true;
            CreateTournamentBtn.Click += CreateTournamentBtn_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(529, 447);
            Controls.Add(CreateTournamentBtn);
            Controls.Add(loadTournamentBtn);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentBtn;
        private Button CreateTournamentBtn;
    }
}