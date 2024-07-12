﻿namespace SecureAppProject
{
    partial class PasswordCollection
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
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            SaveButton = new Button();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(263, 59);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(308, 27);
            UsernameText.TabIndex = 0;
            UsernameText.TextChanged += UsernameText_TextChanged;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(263, 145);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(308, 27);
            PasswordText.TabIndex = 1;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(170, 208);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(229, 54);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(12, 62);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(195, 20);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Please Enter Your Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 148);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(190, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Please Enter Your Password:";
            // 
            // PasswordCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 289);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(SaveButton);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Name = "PasswordCollection";
            Text = "Secure Software Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameText;
        private TextBox PasswordText;
        private Button SaveButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
    }
}