namespace JobApp
{
    partial class JobSeeker_loginView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.enterloging_jobseek_bt = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.Signup_click_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Job Seeker Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(287, 100);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(148, 20);
            this.textBox_username.TabIndex = 14;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(287, 138);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '#';
            this.textBox_Password.Size = new System.Drawing.Size(148, 20);
            this.textBox_Password.TabIndex = 15;
            // 
            // enterloging_jobseek_bt
            // 
            this.enterloging_jobseek_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterloging_jobseek_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterloging_jobseek_bt.Location = new System.Drawing.Point(281, 218);
            this.enterloging_jobseek_bt.Name = "enterloging_jobseek_bt";
            this.enterloging_jobseek_bt.Size = new System.Drawing.Size(154, 50);
            this.enterloging_jobseek_bt.TabIndex = 30;
            this.enterloging_jobseek_bt.Text = "Enter";
            this.enterloging_jobseek_bt.UseVisualStyleBackColor = false;
            this.enterloging_jobseek_bt.Click += new System.EventHandler(this.Enterloging_jobseek_bt_Click);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(254, 359);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(165, 15);
            this.label_text.TabIndex = 31;
            this.label_text.Text = "* If you are not yet a member.";
            // 
            // Signup_click_lb
            // 
            this.Signup_click_lb.AutoSize = true;
            this.Signup_click_lb.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_click_lb.ForeColor = System.Drawing.Color.Blue;
            this.Signup_click_lb.Location = new System.Drawing.Point(425, 359);
            this.Signup_click_lb.Name = "Signup_click_lb";
            this.Signup_click_lb.Size = new System.Drawing.Size(81, 15);
            this.Signup_click_lb.TabIndex = 32;
            this.Signup_click_lb.Text = "CLICK HERE";
            this.Signup_click_lb.Click += new System.EventHandler(this.Signup_click_lb_Click);
            // 
            // JobSeeker_loginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Signup_click_lb);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.enterloging_jobseek_bt);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobSeeker_loginView";
            this.Text = "JobSeeker_View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button enterloging_jobseek_bt;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label Signup_click_lb;
    }
}