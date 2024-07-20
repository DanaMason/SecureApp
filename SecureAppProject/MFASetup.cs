using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureAppProject
{
    public partial class MFASetup : Form
    {
        public string SecretKey { get; private set; }
        private MultiFactorAuthentication mfa;

        public MFASetup()
        {
            InitializeComponent();
            mfa = new MultiFactorAuthentication();
            SecretKey = MultiFactorAuthentication.GenerateTotpSecret();
        }

        private void MFASetup_Load(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void KeyTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenKeyButton_Click(object sender, EventArgs e)
        {
            KeyBox.Text = SecretKey;
        }

        private void ContBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
