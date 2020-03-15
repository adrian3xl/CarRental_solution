namespace JobApp
{
    partial class JobApp_Main_window
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
            this.Main_window_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jobSeeker_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeekerSignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeekerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findJobsTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.browseJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.employerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerLoginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dummy_search_bt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_window_label
            // 
            this.Main_window_label.AutoSize = true;
            this.Main_window_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Main_window_label.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_window_label.Location = new System.Drawing.Point(556, 5);
            this.Main_window_label.Name = "Main_window_label";
            this.Main_window_label.Size = new System.Drawing.Size(116, 43);
            this.Main_window_label.TabIndex = 0;
            this.Main_window_label.Text = "JobApp";
            this.Main_window_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Main_window_label.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(777, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Helping you to find the best employment oppertunities";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobSeeker_itembox,
            this.findJobsTool_itembox,
            this.salaryTool_itembox,
            this.employee_itembox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(77, 503);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jobSeeker_itembox
            // 
            this.jobSeeker_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobSeeker_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobSeekerSignUpToolStripMenuItem,
            this.jobSeekerLoginToolStripMenuItem});
            this.jobSeeker_itembox.Name = "jobSeeker_itembox";
            this.jobSeeker_itembox.Size = new System.Drawing.Size(70, 19);
            this.jobSeeker_itembox.Text = "Job Seeker";
            // 
            // jobSeekerSignUpToolStripMenuItem
            // 
            this.jobSeekerSignUpToolStripMenuItem.Name = "jobSeekerSignUpToolStripMenuItem";
            this.jobSeekerSignUpToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jobSeekerSignUpToolStripMenuItem.Text = "Job Seeker Sign up";
            this.jobSeekerSignUpToolStripMenuItem.Click += new System.EventHandler(this.JobSeekerSignUpToolStripMenuItem_Click);
            // 
            // jobSeekerLoginToolStripMenuItem
            // 
            this.jobSeekerLoginToolStripMenuItem.Name = "jobSeekerLoginToolStripMenuItem";
            this.jobSeekerLoginToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jobSeekerLoginToolStripMenuItem.Text = "Job Seeker Login";
            this.jobSeekerLoginToolStripMenuItem.Click += new System.EventHandler(this.JobSeekerLoginToolStripMenuItem_Click);
            // 
            // findJobsTool_itembox
            // 
            this.findJobsTool_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findJobsTool_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseJobsToolStripMenuItem,
            this.advanceSearchToolStripMenuItem});
            this.findJobsTool_itembox.Enabled = false;
            this.findJobsTool_itembox.Name = "findJobsTool_itembox";
            this.findJobsTool_itembox.Size = new System.Drawing.Size(71, 19);
            this.findJobsTool_itembox.Text = "Find Jobs";
            this.findJobsTool_itembox.Visible = false;
            // 
            // browseJobsToolStripMenuItem
            // 
            this.browseJobsToolStripMenuItem.Name = "browseJobsToolStripMenuItem";
            this.browseJobsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.browseJobsToolStripMenuItem.Text = "Browse Jobs";
            // 
            // advanceSearchToolStripMenuItem
            // 
            this.advanceSearchToolStripMenuItem.Name = "advanceSearchToolStripMenuItem";
            this.advanceSearchToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.advanceSearchToolStripMenuItem.Text = "Advance Search";
            // 
            // salaryTool_itembox
            // 
            this.salaryTool_itembox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salaryTool_itembox.Name = "salaryTool_itembox";
            this.salaryTool_itembox.Size = new System.Drawing.Size(71, 19);
            this.salaryTool_itembox.Text = "Salary Tool";
            this.salaryTool_itembox.Visible = false;
            // 
            // employee_itembox
            // 
            this.employee_itembox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.employee_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employerLoginToolStripMenuItem,
            this.employerLoginToolStripMenuItem1});
            this.employee_itembox.Name = "employee_itembox";
            this.employee_itembox.Size = new System.Drawing.Size(70, 19);
            this.employee_itembox.Text = "Employer";
            // 
            // employerLoginToolStripMenuItem
            // 
            this.employerLoginToolStripMenuItem.Name = "employerLoginToolStripMenuItem";
            this.employerLoginToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.employerLoginToolStripMenuItem.Text = "Employer Sign up";
            this.employerLoginToolStripMenuItem.Click += new System.EventHandler(this.EmployerLoginToolStripMenuItem_Click);
            // 
            // employerLoginToolStripMenuItem1
            // 
            this.employerLoginToolStripMenuItem1.Name = "employerLoginToolStripMenuItem1";
            this.employerLoginToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.employerLoginToolStripMenuItem1.Text = "Employer Login";
            this.employerLoginToolStripMenuItem1.Click += new System.EventHandler(this.EmployerLoginToolStripMenuItem1_Click);
            // 
            // dummy_search_bt
            // 
            this.dummy_search_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummy_search_bt.Location = new System.Drawing.Point(167, 320);
            this.dummy_search_bt.Name = "dummy_search_bt";
            this.dummy_search_bt.Size = new System.Drawing.Size(129, 45);
            this.dummy_search_bt.TabIndex = 12;
            this.dummy_search_bt.Text = "Search Jobs";
            this.dummy_search_bt.UseVisualStyleBackColor = true;
            this.dummy_search_bt.Click += new System.EventHandler(this.Dummy_search_bt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 320);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 45);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Note: This feature will not work unless you are Registered";
            // 
            // JobApp_Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobApp.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dummy_search_bt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Main_window_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "JobApp_Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Job Application Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_window_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findJobsTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem browseJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeeker_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeekerSignUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobSeekerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employee_itembox;
        private System.Windows.Forms.ToolStripMenuItem employerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerLoginToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dummy_search_bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

