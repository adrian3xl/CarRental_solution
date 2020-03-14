namespace JobApp
{
    partial class Job_Seeker_Accountview
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findJobsTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.browseJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeeker_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeekerSignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Manageresume_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_name_tb = new System.Windows.Forms.Label();
            this.gv_appstatus_list = new System.Windows.Forms.DataGridView();
            this.jobApplicationsdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobapp_dbDataSet = new JobApp.Jobapp_dbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.job_Applications_detailsTableAdapter = new JobApp.Jobapp_dbDataSetTableAdapters.Job_Applications_detailsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_appstatus_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationsdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Job Seeker Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findJobsTool_itembox,
            this.salaryTool_itembox,
            this.jobSeeker_itembox,
            this.Manageresume_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 508);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findJobsTool_itembox
            // 
            this.findJobsTool_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findJobsTool_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseJobsToolStripMenuItem,
            this.advanceSearchToolStripMenuItem});
            this.findJobsTool_itembox.Name = "findJobsTool_itembox";
            this.findJobsTool_itembox.Size = new System.Drawing.Size(116, 19);
            this.findJobsTool_itembox.Text = "Find Jobs";
            // 
            // browseJobsToolStripMenuItem
            // 
            this.browseJobsToolStripMenuItem.Name = "browseJobsToolStripMenuItem";
            this.browseJobsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.browseJobsToolStripMenuItem.Text = "Browse Jobs";
            this.browseJobsToolStripMenuItem.Click += new System.EventHandler(this.BrowseJobsToolStripMenuItem_Click);
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
            this.salaryTool_itembox.Size = new System.Drawing.Size(116, 19);
            this.salaryTool_itembox.Text = "Salary Tool";
            // 
            // jobSeeker_itembox
            // 
            this.jobSeeker_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobSeeker_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobSeekerSignUpToolStripMenuItem});
            this.jobSeeker_itembox.Name = "jobSeeker_itembox";
            this.jobSeeker_itembox.Size = new System.Drawing.Size(116, 19);
            this.jobSeeker_itembox.Text = "Job Seeker";
            // 
            // jobSeekerSignUpToolStripMenuItem
            // 
            this.jobSeekerSignUpToolStripMenuItem.Name = "jobSeekerSignUpToolStripMenuItem";
            this.jobSeekerSignUpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.jobSeekerSignUpToolStripMenuItem.Text = "Job Seeker Sign out";
            // 
            // Manageresume_MenuItem
            // 
            this.Manageresume_MenuItem.Name = "Manageresume_MenuItem";
            this.Manageresume_MenuItem.Size = new System.Drawing.Size(116, 19);
            this.Manageresume_MenuItem.Text = "Manage Resume";
            this.Manageresume_MenuItem.Click += new System.EventHandler(this.Manageresume_MenuItem_Click);
            // 
            // user_name_tb
            // 
            this.user_name_tb.AutoSize = true;
            this.user_name_tb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_name_tb.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_tb.Location = new System.Drawing.Point(573, 26);
            this.user_name_tb.Name = "user_name_tb";
            this.user_name_tb.Size = new System.Drawing.Size(17, 25);
            this.user_name_tb.TabIndex = 35;
            this.user_name_tb.Text = " ";
            // 
            // gv_appstatus_list
            // 
            this.gv_appstatus_list.AllowUserToAddRows = false;
            this.gv_appstatus_list.AllowUserToDeleteRows = false;
            this.gv_appstatus_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_appstatus_list.Location = new System.Drawing.Point(141, 196);
            this.gv_appstatus_list.Name = "gv_appstatus_list";
            this.gv_appstatus_list.ReadOnly = true;
            this.gv_appstatus_list.Size = new System.Drawing.Size(571, 231);
            this.gv_appstatus_list.TabIndex = 36;
            // 
            // jobApplicationsdetailsBindingSource
            // 
            this.jobApplicationsdetailsBindingSource.DataMember = "Job_Applications_details";
            this.jobApplicationsdetailsBindingSource.DataSource = this.jobapp_dbDataSet;
            // 
            // jobapp_dbDataSet
            // 
            this.jobapp_dbDataSet.DataSetName = "Jobapp_dbDataSet";
            this.jobapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 39);
            this.label3.TabIndex = 37;
            this.label3.Text = "Application Status";
            // 
            // job_Applications_detailsTableAdapter
            // 
            this.job_Applications_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // Job_Seeker_Accountview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gv_appstatus_list);
            this.Controls.Add(this.user_name_tb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Job_Seeker_Accountview";
            this.Text = "Job Seeker Accountview";
            this.Load += new System.EventHandler(this.Job_Seeker_Accountview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_appstatus_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationsdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findJobsTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem browseJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeeker_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeekerSignUpToolStripMenuItem;
        private System.Windows.Forms.Label user_name_tb;
        private System.Windows.Forms.ToolStripMenuItem Manageresume_MenuItem;
        private System.Windows.Forms.DataGridView gv_appstatus_list;
        private System.Windows.Forms.Label label3;
        private Jobapp_dbDataSet jobapp_dbDataSet;
        private System.Windows.Forms.BindingSource jobApplicationsdetailsBindingSource;
        private Jobapp_dbDataSetTableAdapters.Job_Applications_detailsTableAdapter job_Applications_detailsTableAdapter;
    }
}