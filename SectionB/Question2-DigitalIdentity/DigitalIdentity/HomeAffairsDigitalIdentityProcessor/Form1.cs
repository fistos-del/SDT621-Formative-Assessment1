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
