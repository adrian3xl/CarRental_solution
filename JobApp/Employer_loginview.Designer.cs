namespace JobApp
{
    partial class Employer_loginview
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
            this.label4 = new System.Windows.Forms.Label();
            this.Company_name_tb = new System.Windows.Forms.TextBox();
            this.company_pass_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter_emp_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employer Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Company Name";
            // 
            // Company_name_tb
            // 
            this.Company_name_tb.Location = new System.Drawing.Point(258, 65);
            this.Company_name_tb.Name = "Company_name_tb";
            this.Company_name_tb.Size = new System.Drawing.Size(296, 20);
            this.Company_name_tb.TabIndex = 26;
            // 
            // company_pass_tb
            // 
            this.company_pass_tb.Location = new System.Drawing.Point(258, 113);
            this.company_pass_tb.Name = "company_pass_tb";
            this.company_pass_tb.Size = new System.Drawing.Size(296, 20);
            this.company_pass_tb.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Company Password";
            // 
            // Enter_emp_bt
            // 
            this.Enter_emp_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter_emp_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_emp_bt.Location = new System.Drawing.Point(441, 212);
            this.Enter_emp_bt.Name = "Enter_emp_bt";
            this.Enter_emp_bt.Size = new System.Drawing.Size(154, 50);
            this.Enter_emp_bt.TabIndex = 29;
            this.Enter_emp_bt.Text = "Enter";
            this.Enter_emp_bt.UseVisualStyleBackColor = false;
            this.Enter_emp_bt.Click += new System.EventHandler(this.Enter_emp_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bt.Location = new System.Drawing.Point(144, 212);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(154, 50);
            this.cancel_bt.TabIndex = 30;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = false;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // Employer_loginview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.Enter_emp_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.company_pass_tb);
            this.Controls.Add(this.Company_name_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Employer_loginview";
            this.Text = "Employee_loginview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Company_name_tb;
        private System.Windows.Forms.TextBox company_pass_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enter_emp_bt;
        private System.Windows.Forms.Button cancel_bt;
    }
}