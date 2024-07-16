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
            string filename = "secureFile.dat";

            foreach (char x in PasswordText.Text)
            {
                securePassword.AppendChar(x);
            }

            securePassword.MakeReadOnly();

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

        // When the initial form is loaded
        private void LoginForm_Load(object sender, EventArgs e)
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string directory = Path.Combine(localAppData, "SecureAppProject");
            string filename = Path.Combine(directory, "secureFile.dat");

            Directory.CreateDirectory(directory);

            if (!File.Exists(filename))
            {
                using (FileStream x = File.Create(filename))   {}   // Creates empty file if required.
            }
        }
    }
}
