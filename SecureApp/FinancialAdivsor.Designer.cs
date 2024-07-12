namespace FinancialAid
{
    partial class FinancialAdvisor
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QuizTB = new System.Windows.Forms.TextBox();
            this.RiskQuizButton = new System.Windows.Forms.Button();
            this.WelcomeBox = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Welcometxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(31, 443);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(473, 36);
            this.textBox2.TabIndex = 10;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Thank you for using our services and hopefully this financial advise can help you" +
    " in your future financial decisions. Happy investing!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(67, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 72);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "After you have taken the previous quiz, please press the following button to dete" +
    "rmine your suggested Portfolio.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(346, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Portfolio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuizTB
            // 
            this.QuizTB.BackColor = System.Drawing.SystemColors.MenuText;
            this.QuizTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuizTB.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.QuizTB.ForeColor = System.Drawing.Color.White;
            this.QuizTB.Location = new System.Drawing.Point(67, 153);
            this.QuizTB.Multiline = true;
            this.QuizTB.Name = "QuizTB";
            this.QuizTB.ReadOnly = true;
            this.QuizTB.Size = new System.Drawing.Size(224, 73);
            this.QuizTB.TabIndex = 7;
            this.QuizTB.TabStop = false;
            this.QuizTB.Text = "Please click the button to the right to take our personally designed quiz to dete" +
    "rmine your risk personality.";
            this.QuizTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuizTB.TextChanged += new System.EventHandler(this.QuizTB_TextChanged);
            // 
            // RiskQuizButton
            // 
            this.RiskQuizButton.BackColor = System.Drawing.Color.Navy;
            this.RiskQuizButton.ForeColor = System.Drawing.Color.White;
            this.RiskQuizButton.Location = new System.Drawing.Point(346, 153);
            this.RiskQuizButton.Name = "RiskQuizButton";
            this.RiskQuizButton.Size = new System.Drawing.Size(132, 55);
            this.RiskQuizButton.TabIndex = 6;
            this.RiskQuizButton.Text = "Risk Quiz";
            this.RiskQuizButton.UseVisualStyleBackColor = false;
            this.RiskQuizButton.Click += new System.EventHandler(this.RiskQuizButton_Click);
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.WelcomeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeBox.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.ForeColor = System.Drawing.Color.White;
            this.WelcomeBox.Location = new System.Drawing.Point(87, 12);
            this.WelcomeBox.Multiline = true;
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.ReadOnly = true;
            this.WelcomeBox.Size = new System.Drawing.Size(346, 135);
            this.WelcomeBox.TabIndex = 11;
            this.WelcomeBox.TabStop = false;
            this.WelcomeBox.Text = "welcome to FinancialAid.io! Please follow the instructions that follow.";
            this.WelcomeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeBox.TextChanged += new System.EventHandler(this.WelcomeBox_TextChanged);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Navy;
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(31, 382);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(220, 38);
            this.Restart.TabIndex = 12;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Navy;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(284, 382);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(220, 38);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(87, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 135);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.WelcomeBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(54, 21);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(346, 135);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.WelcomeBox_TextChanged);
            // 
            // Welcometxt
            // 
            this.Welcometxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.Welcometxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Welcometxt.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcometxt.ForeColor = System.Drawing.Color.White;
            this.Welcometxt.Location = new System.Drawing.Point(87, 12);
            this.Welcometxt.Multiline = true;
            this.Welcometxt.Name = "Welcometxt";
            this.Welcometxt.Size = new System.Drawing.Size(346, 135);
            this.Welcometxt.TabIndex = 11;
            this.Welcometxt.Text = "welcome box";
            this.Welcometxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Welcometxt.TextChanged += new System.EventHandler(this.WelcomeBox_TextChanged);
            // 
            // FinancialAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Welcometxt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.WelcomeBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuizTB);
            this.Controls.Add(this.RiskQuizButton);
            this.Name = "FinancialAdvisor";
            this.Text = "FinancialAdivsor";
            this.Load += new System.EventHandler(this.FinancialAdivsor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QuizTB;
        private System.Windows.Forms.Button RiskQuizButton;
        private System.Windows.Forms.TextBox WelcomeBox;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Welcometxt;
    }
}