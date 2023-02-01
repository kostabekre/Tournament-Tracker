namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMemberBtn = new System.Windows.Forms.Button();
            this.createTeamBtn = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamNameValue.Location = new System.Drawing.Point(12, 102);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(271, 27);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 64);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(148, 35);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(182, 41);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMemberBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addMemberBtn.Location = new System.Drawing.Point(70, 236);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(159, 44);
            this.addMemberBtn.TabIndex = 19;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(12, 186);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(271, 28);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoEllipsis = true;
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(12, 148);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(247, 35);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberBtn);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(12, 300);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(328, 260);
            this.addNewMemberGroupBox.TabIndex = 20;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createMemberBtn.Location = new System.Drawing.Point(69, 213);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(167, 41);
            this.createMemberBtn.TabIndex = 21;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            this.createMemberBtn.Click += new System.EventHandler(this.createMemberBtn_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cellphoneValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cellphoneValue.Location = new System.Drawing.Point(121, 166);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(150, 32);
            this.cellphoneValue.TabIndex = 28;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cellphoneLabel.Location = new System.Drawing.Point(9, 168);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(102, 25);
            this.cellphoneLabel.TabIndex = 27;
            this.cellphoneLabel.Text = "Cellphone:";
            // 
            // emailValue
            // 
            this.emailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.emailValue.Location = new System.Drawing.Point(121, 124);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(150, 32);
            this.emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.emailLabel.Location = new System.Drawing.Point(9, 126);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 25);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lastNameValue.Location = new System.Drawing.Point(121, 80);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(150, 32);
            this.lastNameValue.TabIndex = 24;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lastNameLabel.Location = new System.Drawing.Point(9, 82);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 25);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.firstNameValue.Location = new System.Drawing.Point(121, 38);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(150, 32);
            this.firstNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.firstNameLabel.Location = new System.Drawing.Point(9, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name:";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 20;
            this.teamMembersListBox.Location = new System.Drawing.Point(392, 96);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(272, 464);
            this.teamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedMemberBtn
            // 
            this.removeSelectedMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeSelectedMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.removeSelectedMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.removeSelectedMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedMemberBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.removeSelectedMemberBtn.Location = new System.Drawing.Point(680, 298);
            this.removeSelectedMemberBtn.Name = "removeSelectedMemberBtn";
            this.removeSelectedMemberBtn.Size = new System.Drawing.Size(108, 60);
            this.removeSelectedMemberBtn.TabIndex = 25;
            this.removeSelectedMemberBtn.Text = "Remove Selected";
            this.removeSelectedMemberBtn.UseVisualStyleBackColor = true;
            this.removeSelectedMemberBtn.Click += new System.EventHandler(this.removeSelectedMemberBtn_Click);
            // 
            // createTeamBtn
            // 
            this.createTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createTeamBtn.Location = new System.Drawing.Point(281, 576);
            this.createTeamBtn.Name = "createTeamBtn";
            this.createTeamBtn.Size = new System.Drawing.Size(211, 55);
            this.createTeamBtn.TabIndex = 26;
            this.createTeamBtn.Text = "Create Team";
            this.createTeamBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.createTeamBtn);
            this.Controls.Add(this.removeSelectedMemberBtn);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberBtn;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private Button createMemberBtn;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberBtn;
        private Button createTeamBtn;
    }
}