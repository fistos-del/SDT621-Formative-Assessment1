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

            // Validattion 2: Prevent duplicate entries
            foreach (var item in lstLanguages.Items)
            {
                if (item.ToString().Equals(newlanguage, StringComparison.OrdinalIgnoreCase))
                {
                    lblMessage.Text = "❌ Error: Language already exists!";
                    lblMessage.ForeColor = System.Drawing.Color.Red; return;
                }
            }

            //Add language to the listBox
            lstLanguages.Items.Add(newlanguage);

            // Display current date and time
            lblDateTime.Text = $"Added on: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            // Show the textbox for the next entry
            txtLanguage.Clear();
            txtLanguage.Focus();
        }

        // Remove Language Button Click Event
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedIndex == -1)
            {
                lblMessage.Text = "❌ Error: Please select a language to remove!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;

            }

            // Get the selected language
            string removedlanguage = lstLanguages.SelectedItem.ToString();

            // Remove it from the list
            lstLanguages.Items.RemoveAt(lstLanguages.SelectedIndex);

            // Display current date and time
            lblDateTime.Text = $"Removed on: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            // Show success message
            lblMessage.Text = $"✅ Success: '{removedlanguage}' has been removed!";

            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
    }
}
