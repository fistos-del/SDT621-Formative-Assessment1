namespace LanguageManager
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
            lblInstruction = new Label();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lstLanguages = new ListBox();
            lblDateTime = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Language Manager";
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(155, 9);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(210, 20);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Enter Programming Language:";
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(155, 32);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(125, 27);
            txtLanguage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(155, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(255, 138);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(12, 217);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(150, 104);
            lstLanguages.TabIndex = 5;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(199, 230);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(50, 20);
            lblDateTime.TabIndex = 6;
            lblDateTime.Text = "label1";
            // 
            // lblMessage
            // 
            lblMessage.AccessibleName = "lblMessage";
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(255, 230);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 7;
            lblMessage.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(lblDateTime);
            Controls.Add(lstLanguages);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lblInstruction);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstruction;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lstLanguages;
        private Label lblDateTime;
        private Label lblMessage;
    }
}
