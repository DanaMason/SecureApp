namespace SecureAppProject
{
    partial class PostLoginScreen
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
            label1 = new Label();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(82, 31);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Success! You logged in.";
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Black;
            ExitBtn.ForeColor = Color.DarkRed;
            ExitBtn.Location = new Point(12, 84);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(310, 41);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PostLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(334, 157);
            Controls.Add(ExitBtn);
            Controls.Add(label1);
            Name = "PostLoginScreen";
            Text = "PostLoginScreen";
            Load += PostLoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button ExitBtn;
    }
}