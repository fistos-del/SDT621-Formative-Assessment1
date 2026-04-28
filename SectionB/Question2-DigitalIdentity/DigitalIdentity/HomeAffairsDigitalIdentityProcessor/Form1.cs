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