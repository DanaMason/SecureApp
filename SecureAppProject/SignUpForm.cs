using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureAppProject
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            PasswordButton.PasswordChar = '●';
        }

        // Creates a secureString password and username to send to the proceeding functions
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = UsernameButton.Text;
            string filename = "secureFile.dat";
            InputValidation inputValidation = new InputValidation();
            SecureString securePassword = new SecureString();

            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Missing a username.");
                return;
            }

            foreach (char x in PasswordButton.Text)
            {
                securePassword.AppendChar(x);
            }

            if (!inputValidation.ValidatePassword(securePassword))
            {
                MessageBox.Show("Password requirements not met! Please ensure you are meeting the criteria: \n\t* Have at least 12 characters. \n\t* Have at least 1 symbol. \n\t* Have at least 1 Uppercase and Lowercase Letter. \n\t* Have at least 1 number.");
                return;
            }

            securePassword.MakeReadOnly();

            MFASetup setup = new MFASetup();
            setup.ShowDialog();

            string secretKey = setup.SecretKey;

            if (string.IsNullOrEmpty(secretKey))
            {
                MessageBox.Show("MFA setup incomplete.");
                return;
            }

            SecureFeatures.SignUp(filename, username, securePassword, secretKey);

            MessageBox.Show("Sign Up was successful! You can now login.");

            return;
        }

        private void UsernameButton_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void PasswordButton_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
