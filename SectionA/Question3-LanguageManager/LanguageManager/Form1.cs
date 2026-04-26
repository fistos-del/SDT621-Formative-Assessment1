using System;
using System.Windows.Forms;

namespace LanguageManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set up the initial state
            lblMessage.Text = "";
            lblDateTime.Text = "";
            this.Text = "Proamming Langage Manager";
        }

        // Add Language Button Click Event
        private void Form1_Load(object sender, EventArgs e)
        {
            string newlanguage = txtLanguage.Text.Trim();

            // Validation 1: Prevent empty input
            if (!string.IsNullOrEmpty(newlanguage))
            {
                lblMessage.Text = "❌ Error: Please enter a language name!";
                lblMessage.ForeColor = System.Drawing.Color.Red; return;
            }


        }
    }
}
