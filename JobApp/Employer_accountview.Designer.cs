namespace JobApp
{
    partial class Employer_accountview
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
            this.CompName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ManageVacancy_menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindow_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageApplicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.CompEmail = new System.Windows.Forms.Label();
            this.compLoc = new System.Windows.Forms.Label();
            this.IndType = new System.Windows.Forms.Label();
            this.WorkNum = new System.Windows.Forms.Label();
            this.CompBack = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompName
            // 
            this.CompName.AutoSize = true;
            this.CompName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompName.Location = new System.Drawing.Point(542, 20);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(244, 39);
            this.CompName.TabIndex = 13;
            this.CompName.Text = "Employer Account";
            this.CompName.Click += new System.EventHandler(this.CompName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Company Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Company Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(807, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Company Background";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Industry Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Company Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Workforce Number";
            // 
            // ManageVacancy_menustrip
            // 
            this.ManageVacancy_menustrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageVacancy_menustrip.Name = "ManageVacancy_menustrip";
            this.ManageVacancy_menustrip.Size = new System.Drawing.Size(170, 19);
            this.ManageVacancy_menustrip.Text = "Manage Vacancy";
            this.ManageVacancy_menustrip.Click += new System.EventHandler(this.Show_vacancies);
            // 
            // mainWindow_MenuItem
            // 
            this.mainWindow_MenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainWindow_MenuItem.Name = "mainWindow_MenuItem";
            this.mainWindow_MenuItem.Size = new System.Drawing.Size(170, 19);
            this.mainWindow_MenuItem.Text = "Manage account information";
            this.mainWindow_MenuItem.Click += new System.EventHandler(this.mainWindow_MenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageVacancy_menustrip,
            this.manageApplicantsToolStripMenuItem,
            this.mainWindow_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(177, 492);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageApplicantsToolStripMenuItem
            // 
            this.manageApplicantsToolStripMenuItem.Name = "manageApplicantsToolStripMenuItem";
            this.manageApplicantsToolStripMenuItem.Size = new System.Drawing.Size(170, 19);
            this.manageApplicantsToolStripMenuItem.Text = "Manage Applicants";
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ContactNumber.Location = new System.Drawing.Point(440, 166);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(51, 16);
            this.ContactNumber.TabIndex = 45;
            this.ContactNumber.Text = "label1";
            // 
            // CompEmail
            // 
            this.CompEmail.AutoSize = true;
            this.CompEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CompEmail.Location = new System.Drawing.Point(440, 214);
            this.CompEmail.Name = "CompEmail";
            this.CompEmail.Size = new System.Drawing.Size(51, 16);
            this.CompEmail.TabIndex = 46;
            this.CompEmail.Text = "label2";
            // 
            // compLoc
            // 
            this.compLoc.AutoSize = true;
            this.compLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compLoc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.compLoc.Location = new System.Drawing.Point(440, 255);
            this.compLoc.Name = "compLoc";
            this.compLoc.Size = new System.Drawing.Size(51, 16);
            this.compLoc.TabIndex = 47;
            this.compLoc.Text = "label5";
            // 
            // IndType
            // 
            this.IndType.AutoSize = true;
            this.IndType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IndType.Location = new System.Drawing.Point(440, 304);
            this.IndType.Name = "IndType";
            this.IndType.Size = new System.Drawing.Size(59, 16);
            this.IndType.TabIndex = 48;
            this.IndType.Text = "label10";
            // 
            // WorkNum
            // 
            this.WorkNum.AutoSize = true;
            this.WorkNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.WorkNum.Location = new System.Drawing.Point(440, 363);
            this.WorkNum.Name = "WorkNum";
            this.WorkNum.Size = new System.Drawing.Size(59, 16);
            this.WorkNum.TabIndex = 49;
            this.WorkNum.Text = "label11";
            // 
            // CompBack
            // 
            this.CompBack.Location = new System.Drawing.Point(824, 113);
            this.CompBack.Name = "CompBack";
            this.CompBack.Size = new System.Drawing.Size(350, 167);
            this.CompBack.TabIndex = 51;
            // 
            // Employer_accountview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 492);
            this.Controls.Add(this.CompBack);
            this.Controls.Add(this.WorkNum);
            this.Controls.Add(this.IndType);
            this.Controls.Add(this.compLoc);
            this.Controls.Add(this.CompEmail);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CompName);
            this.Name = "Employer_accountview";
            this.Text = "Job Application Management System";
            this.Load += new System.EventHandler(this.Employer_accountview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem ManageVacancy_menustrip;
        private System.Windows.Forms.ToolStripMenuItem mainWindow_MenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicantsToolStripMenuItem;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label CompEmail;
        private System.Windows.Forms.Label compLoc;
        private System.Windows.Forms.Label IndType;
        private System.Windows.Forms.Label WorkNum;
        private System.Windows.Forms.TextBox CompBack;
    }
}