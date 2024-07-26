namespace SecureAppProject
{
    partial class MFAInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeLabel = new Label();
            EnteredCodedInformationText = new TextBox();
            ContinueButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BackColor = Color.Black;
            WelcomeLabel.ForeColor = Color.DarkRed;
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(428, 20);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Next, please input the Multi-Factor Authentication code, please.";
            // 
            // EnteredCodedInformationText
            // 
            EnteredCodedInformationText.BackColor = Color.DarkRed;
            EnteredCodedInformationText.ForeColor = Color.White;
            EnteredCodedInformationText.Location = new Point(142, 65);
            EnteredCodedInformationText.Name = "EnteredCodedInformationText";
            EnteredCodedInformationText.Size = new Size(167, 27);
            EnteredCodedInformationText.TabIndex = 3;
            EnteredCodedInformationText.TextChanged += EnteredCodedInformationText_TextChanged;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.Black;
            ContinueButton.ForeColor = Color.DarkRed;
            ContinueButton.Location = new Point(273, 128);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(167, 76);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.ForeColor = Color.DarkRed;
            BackButton.Location = new Point(12, 128);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(167, 76);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MFAInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(456, 246);
            Controls.Add(BackButton);
            Controls.Add(EnteredCodedInformationText);
            Controls.Add(WelcomeLabel);
            Controls.Add(ContinueButton);
            ForeColor = Color.DarkRed;
            Name = "MFAInputForm";
            Text = "MFAInputForm";
            Load += MFAInputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label WelcomeLabel;
        private TextBox EnteredCodedInformationText;
        private Button ContinueButton;
        private Button BackButton;
    }
}