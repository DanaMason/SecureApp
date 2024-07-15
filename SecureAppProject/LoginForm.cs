using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Runtime.InteropServices;

namespace SecureAppProject
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        // Checks the information given to login.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = UsernameText.Text;
            SecureString securePassword = new SecureString();

            foreach (char x in PasswordText.Text)
            {
                securePassword.AppendChar(x);
            }

            securePassword.MakeReadOnly();

            string filename = "secureFile.dat";

            bool isVerified = SecureFeatures.VerifyPassword(filename, username, securePassword);

            if (isVerified)
            {
                MessageBox.Show("Username and Password are correct, now please finish by using Multi-Factor Authentication.");
            }
            else
            {
                MessageBox.Show("Error with username or password!");
            }

            return;

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            return;

        }

        private void SignUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }
    }
}
