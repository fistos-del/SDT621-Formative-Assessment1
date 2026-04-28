namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblID = new Label();
            txtIDNumber = new TextBox();
            lblCitizenship = new Label();
            cmbCitizenship = new ComboBox();
            btnValidateID = new Button();
            btnGenerateProfile = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(318, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME AFFAIRS DIGITAL IDENTITY PROCESSOR";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(79, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 124);
            lblID.Name = "lblID";
            lblID.Size = new Size(85, 20);
            lblID.TabIndex = 3;
            lblID.Text = "ID Number:";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(140, 124);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(125, 27);
            txtIDNumber.TabIndex = 4;
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Location = new Point(21, 173);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(128, 20);
            lblCitizenship.TabIndex = 5;
            lblCitizenship.Text = "Citizenship Status:";
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Location = new Point(199, 173);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(343, 28);
            cmbCitizenship.TabIndex = 6;
            cmbCitizenship.Text = "Items: Citizen, Permanent Resident, Visitor";
            // 
            // btnValidateID
            // 
            btnValidateID.Location = new Point(55, 311);
            btnValidateID.Name = "btnValidateID";
            btnValidateID.Size = new Size(94, 29);
            btnValidateID.TabIndex = 8;
            btnValidateID.Text = "Validate ID";
            btnValidateID.UseVisualStyleBackColor = true;
            // 
            // btnGenerateProfile
            // 
            btnGenerateProfile.Location = new Point(216, 311);
            btnGenerateProfile.Name = "btnGenerateProfile";
            btnGenerateProfile.Size = new Size(94, 29);
            btnGenerateProfile.TabIndex = 9;
            btnGenerateProfile.Text = "Generate Profile";
            btnGenerateProfile.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(12, 369);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(375, 27);
            txtResults.TabIndex = 10;
            txtResults.Text = "Multiline = True, ReadOnly = True, ScrollBars = Vertical";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResults);
            Controls.Add(btnGenerateProfile);
            Controls.Add(btnValidateID);
            Controls.Add(cmbCitizenship);
            Controls.Add(lblCitizenship);
            Controls.Add(txtIDNumber);
            Controls.Add(lblID);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "HOME AFFAIRS DIGITAL IDENTITY PROCESSOR";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblID;
        private TextBox txtIDNumber;
        private Label lblCitizenship;
        private ComboBox cmbCitizenship;
        private Button btnValidateID;
        private Button btnGenerateProfile;
        private TextBox txtResults;
    }
}
