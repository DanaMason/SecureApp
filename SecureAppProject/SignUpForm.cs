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

namespace SecureAppProject
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        // Creates a secureString password and username to send to the proceeding functions
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = UsernameButton.Text;
            string password = PasswordButton.Text;
            SecureString securePassword = new SecureString();
            
            foreach (char x in PasswordButton.Text)
            {
                securePassword.AppendChar(x);
            }

            securePassword.MakeReadOnly();

            string filename = "secureFile.dat";

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,}$";


            if (!System.Text.RegularExpressions.Regex.IsMatch(password, passwordPattern)
            {
                MessageBox.Show("Password requirements not met! Please retry meeting the criteria: * Have at least 12 characters. * Have at least 1 symbol. * Have at least 1 Uppercase and Lowercase. * Have at least 1 number.");
            }

            if(SecureFeatures.DoesUsernameExist(filename, username)
            {
                MessageBox.Show("Please select a different Username. The chosen Username already exists.");
            }

            bool isVerified = SecureFeatures.VerifyPassword(filename, username, securePassword);

            if (isVerified)
            {
                MessageBox.Show("Congratulations! Password and Username are available. Please continue on to Multi-Factor Authorization Setup..");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
            return;

        }
        private void UsernameButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
