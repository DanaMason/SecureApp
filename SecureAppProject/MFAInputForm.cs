using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureAppProject
{
    public partial class MFAInputForm : Form
    {
        public string Input { get; private set; }

        public MFAInputForm()
        {
            InitializeComponent();
            Input = string.Empty;
        }

        private void MFAInputForm_Load(object sender, EventArgs e)
        {

        }

        private void EnteredCodedInformationText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Input = EnteredCodedInformationText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
