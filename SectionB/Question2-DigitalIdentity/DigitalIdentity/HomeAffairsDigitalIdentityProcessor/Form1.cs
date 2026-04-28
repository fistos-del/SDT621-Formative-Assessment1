using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

            // Validate citizenship selection
            if (cmbCitizenship.SelectedItem == null)
            {
                txtResults.Text = "ERROR: Please select a citizenship status.";
                return;
            }

            // Validate citizenship selection
            if (cmbCitizenship.SelectedItem == null)
            {
                txtResults.Text = "ERROR: Please select a citizenship status.";
                return;
            }

            // Create a CitizenProfile object
            currentProfile = new CitizenProfile(
                txtName.Text.Trim(),
                txtIDNumber.Text.Trim(),
                cmbCitizenship.SelectedItem.ToString()
            );

            // Display validation result
            txtResults.Text = "====================================\r\n";
            txtResults.Text += "        ID VALIDATION RESULT        \r\n";
            txtResults.Text += "====================================\r\n";
            txtResults.Text += $"Name: {currentProfile.FullName}\r\n";
            txtResults.Text += $"ID Number: {currentProfile.IDNumber}\r\n";
            txtResults.Text += $"Calculated Age: {currentProfile.Age} years\r\n";
            txtResults.Text += "------------------------------------\r\n";
            txtResults.Text += $"Result: {currentProfile.ValidatedID()}\r\n";
            txtResults.Text += "====================================\r\n";
        }

        /// <summary>
        /// Generate Profile Button Click - Produces a formatted profile summary
        /// </summary>
        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            // Check if ID has been validated first
            if (currentProfile == null)
            {
                txtResults.Text = "ERROR: Please validate the ID first before generating a profile.";
                return;
            }

            // Get current timestamp
            DateTime processingTime = DateTime.Now;

            // Build profile summary
            string profileSummary = "";
            profileSummary += "==========================================\r\n";
            profileSummary += "        DIGITAL CITIZEN PROFILE           \r\n";
            profileSummary += "==========================================\r\n";
            profileSummary += "\r\n";
            profileSummary += "  PERSONAL DETAILS:\r\n";
            profileSummary += "  ----------------------------------------\r\n";
            profileSummary += $"  Full Name:          {currentProfile.FullName}\r\n";
            profileSummary += $"  ID Number:          {currentProfile.IDNumber}\r\n";
            profileSummary += $"  Age:                {currentProfile.Age} years\r\n";
            profileSummary += $"  Citizenship Status: {currentProfile.CitizenshipStatus}\r\n";
            profileSummary += "\r\n";
            profileSummary += "  VALIDATION RESULT:\r\n";
            profileSummary += "  ----------------------------------------\r\n";
            profileSummary += $"  {currentProfile.ValidatedID()}\r\n";
            profileSummary += "\r\n";
            profileSummary += "  PROCESSING INFORMATION:\r\n";
            profileSummary += "  ----------------------------------------\r\n";
            profileSummary += $"  Profile Generated:  {processingTime:dd/MM/yyyy}\r\n";
            profileSummary += $"  Time:               {processingTime:HH:mm:ss}\r\n";
            profileSummary += "==========================================\r\n";

            // Display the profile summary
            txtResults.Text = profileSummary;
        }
    }
}
