namespace SecureAppProject
{
    partial class SignUpForm
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
            SaveButton = new Button();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameButton = new TextBox();
            PasswordButton = new TextBox();
            WelcomeLabel = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(367, 202);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(159, 44);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(56, 84);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(294, 20);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Please enter the Username you'd lke to use:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(53, 143);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(297, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Please enter the Password you'd like to use: ";
            // 
            // UsernameButton
            // 
            UsernameButton.Location = new Point(367, 81);
            UsernameButton.Name = "UsernameButton";
            UsernameButton.Size = new Size(159, 27);
            UsernameButton.TabIndex = 4;
            UsernameButton.TextChanged += UsernameButton_TextChanged;
            // 
            // PasswordButton
            // 
            PasswordButton.Location = new Point(367, 136);
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(159, 27);
            PasswordButton.TabIndex = 5;
            PasswordButton.TextChanged += PasswordButton_TextChanged;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(142, 30);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(274, 28);
            WelcomeLabel.TabIndex = 6;
            WelcomeLabel.Text = "Welcome to the sign up page!";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(26, 202);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(159, 44);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click_1;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 278);
            Controls.Add(BackButton);
            Controls.Add(WelcomeLabel);
            Controls.Add(PasswordButton);
            Controls.Add(UsernameButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(SaveButton);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameButton;
        private TextBox PasswordButton;
        private Label WelcomeLabel;
        private Button BackButton;
    }
}