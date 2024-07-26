namespace SecureAppProject
{
    partial class MFASetup
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
            Label = new Label();
            GenKeyButton = new Button();
            ContBtn = new Button();
            KeyBox = new TextBox();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = Color.Black;
            Label.ForeColor = Color.DarkRed;
            Label.Location = new Point(44, 9);
            Label.Name = "Label";
            Label.Size = new Size(315, 20);
            Label.TabIndex = 0;
            Label.Text = "Now, please setup Multi-Factor Authentication";
            Label.Click += Label_Click;
            // 
            // GenKeyButton
            // 
            GenKeyButton.BackColor = Color.Black;
            GenKeyButton.ForeColor = Color.DarkRed;
            GenKeyButton.Location = new Point(12, 48);
            GenKeyButton.Name = "GenKeyButton";
            GenKeyButton.Size = new Size(135, 37);
            GenKeyButton.TabIndex = 1;
            GenKeyButton.Text = "Generate Key";
            GenKeyButton.UseVisualStyleBackColor = false;
            GenKeyButton.Click += GenKeyButton_Click;
            // 
            // ContBtn
            // 
            ContBtn.BackColor = Color.Black;
            ContBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ContBtn.ForeColor = Color.DarkRed;
            ContBtn.Location = new Point(117, 138);
            ContBtn.Name = "ContBtn";
            ContBtn.Size = new Size(174, 54);
            ContBtn.TabIndex = 3;
            ContBtn.Text = "Continue";
            ContBtn.UseVisualStyleBackColor = false;
            ContBtn.Click += ContBtn_Click_1;
            // 
            // KeyBox
            // 
            KeyBox.BackColor = Color.DarkRed;
            KeyBox.ForeColor = Color.White;
            KeyBox.Location = new Point(163, 53);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(223, 27);
            KeyBox.TabIndex = 4;
            KeyBox.TextChanged += KeyBox_TextChanged;
            // 
            // MFASetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(398, 204);
            Controls.Add(KeyBox);
            Controls.Add(ContBtn);
            Controls.Add(GenKeyButton);
            Controls.Add(Label);
            ForeColor = Color.DarkRed;
            Name = "MFASetup";
            Text = "MFASetup";
            Load += MFASetup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private Button GenKeyButton;
        private Button ContBtn;
        private TextBox KeyBox;
    }
}