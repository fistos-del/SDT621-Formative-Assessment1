using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        private CitizenProfile currentProfile;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set form properties
            this.Text = "Home Affairs Digital Identity Processor";

            // Set up ComboBox items
            cmbCitizenship.Items.Clear();
            cmbCitizenship.Items.Add("Citizen");
            cmbCitizenship.Items.Add("Permanent Resident");
            cmbCitizenship.Items.Add("Visitor");
            cmbCitizenship.SelectedIndex = 0; // Default to Citizen

            // Set up results TextBox
            txtResults.Multiline = true;
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;

            // Styling for title
            lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Text = "HOME AFFAIRS DIGITAL IDENTITY PROCESSOR";
        }

        /// <summary>
        /// Validate ID Button Click - Validates the ID number
        /// </summary>
        private void btnValidateID_Click(object sender, EventArgs e)
        {
            // Validate name input
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtResults.Text = "ERROR: Please enter a full name.";
                return;
            }

            // Validate ID input
            if (string.IsNullOrWhiteSpace(txtIDNumber.Text))
            {
                txtResults.Text = "ERROR: Please enter an ID number.";
                return;
            }