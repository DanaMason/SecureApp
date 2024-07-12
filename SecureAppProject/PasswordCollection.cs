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

namespace SecureAppProject
{

    public partial class PasswordCollection : Form
    {

        private Encryption _encrypt;
        private Decryption _decrypt;

        string EncryptedUsername, EncryptedPassword;

        public PasswordCollection()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EncryptedUsername = _encrypt.encrypt(UsernameText.Text);
            EncryptedPassword = _decrypt.decrypt(PasswordText.Text);

            // Then it will proceed to Hash the encoded passwords.

            // Send the Encrypted Information to a database text file later on.

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

        /*public double HashCode(7, 13, 17, 19)
        {

        }*/

    }

}
