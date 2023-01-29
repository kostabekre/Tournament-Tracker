namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(176, 41);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeNumberValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.placeNumberValue.Location = new System.Drawing.Point(180, 72);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(150, 27);
            this.placeNumberValue.TabIndex = 24;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.placeNumberLabel.Location = new System.Drawing.Point(18, 74);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(135, 25);
            this.placeNumberLabel.TabIndex = 23;
            this.placeNumberLabel.Text = "Place Number:";
            // 
            // placeNameValue
            // 
            this.placeNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeNameValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.placeNameValue.Location = new System.Drawing.Point(180, 117);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(150, 27);
            this.placeNameValue.TabIndex = 26;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.placeNameLabel.Location = new System.Drawing.Point(18, 119);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(116, 25);
            this.placeNameLabel.TabIndex = 25;
            this.placeNameLabel.Text = "Place Name:";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeAmountValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizeAmountValue.Location = new System.Drawing.Point(180, 162);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(150, 27);
            this.prizeAmountValue.TabIndex = 28;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizeAmountLabel.Location = new System.Drawing.Point(18, 164);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(130, 25);
            this.prizeAmountLabel.TabIndex = 27;
            this.prizeAmountLabel.Text = "Prize Amount:";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizePercentageValue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizePercentageValue.Location = new System.Drawing.Point(180, 266);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(150, 27);
            this.prizePercentageValue.TabIndex = 30;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizePercentageLabel.Location = new System.Drawing.Point(18, 268);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(157, 25);
            this.prizePercentageLabel.TabIndex = 29;
            this.prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.orLabel.Location = new System.Drawing.Point(149, 214);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(53, 25);
            this.orLabel.TabIndex = 31;
            this.orLabel.Text = "-OR-";
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.createPrizeBtn.Location = new System.Drawing.Point(73, 333);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(211, 55);
            this.createPrizeBtn.TabIndex = 32;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            this.createPrizeBtn.Click += new System.EventHandler(this.createPrizeBtn_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 415);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeBtn;
    }
}