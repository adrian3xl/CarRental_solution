﻿namespace JobApp
{
    partial class BrowseJobs
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
            this.textox_search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findJobsTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.browseJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeeker_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeekerSignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_vacacies = new System.Windows.Forms.DataGridView();
            this.employerdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobapp_dbDataSet = new JobApp.Jobapp_dbDataSet();
            this.employer_detailsTableAdapter = new JobApp.Jobapp_dbDataSetTableAdapters.Employer_detailsTableAdapter();
            this.vacancy_detailsTableAdapter = new JobApp.Jobapp_dbDataSetTableAdapters.Vacancy_detailsTableAdapter();
            this.tableAdapterManager = new JobApp.Jobapp_dbDataSetTableAdapters.TableAdapterManager();
            this.Search_bt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacacies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textox_search
            // 
            this.textox_search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textox_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textox_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textox_search.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textox_search.Location = new System.Drawing.Point(246, 12);
            this.textox_search.Multiline = true;
            this.textox_search.Name = "textox_search";
            this.textox_search.Size = new System.Drawing.Size(606, 37);
            this.textox_search.TabIndex = 4;
            this.textox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findJobsTool_itembox,
            this.salaryTool_itembox,
            this.jobSeeker_itembox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(78, 559);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findJobsTool_itembox
            // 
            this.findJobsTool_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findJobsTool_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseJobsToolStripMenuItem,
            this.advanceSearchToolStripMenuItem});
            this.findJobsTool_itembox.Name = "findJobsTool_itembox";
            this.findJobsTool_itembox.Size = new System.Drawing.Size(71, 19);
            this.findJobsTool_itembox.Text = "Find Jobs";
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
            // 
            // jobSeeker_itembox
            // 
            this.jobSeeker_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobSeeker_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobSeekerSignUpToolStripMenuItem});
            this.jobSeeker_itembox.Name = "jobSeeker_itembox";
            this.jobSeeker_itembox.Size = new System.Drawing.Size(71, 19);
            this.jobSeeker_itembox.Text = "Job Seeker";
            this.jobSeeker_itembox.Visible = false;
            // 
            // jobSeekerSignUpToolStripMenuItem
            // 
            this.jobSeekerSignUpToolStripMenuItem.Name = "jobSeekerSignUpToolStripMenuItem";
            this.jobSeekerSignUpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.jobSeekerSignUpToolStripMenuItem.Text = "Job Seeker Sign out";
            // 
            // dgv_vacacies
            // 
            this.dgv_vacacies.AllowUserToAddRows = false;
            this.dgv_vacacies.AllowUserToDeleteRows = false;
            this.dgv_vacacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vacacies.Location = new System.Drawing.Point(97, 121);
            this.dgv_vacacies.Name = "dgv_vacacies";
            this.dgv_vacacies.ReadOnly = true;
            this.dgv_vacacies.Size = new System.Drawing.Size(786, 298);
            this.dgv_vacacies.TabIndex = 11;
            // 
            // employerdetailsBindingSource
            // 
            this.employerdetailsBindingSource.DataMember = "Employer_details";
            this.employerdetailsBindingSource.DataSource = this.jobapp_dbDataSet;
            // 
            // jobapp_dbDataSet
            // 
            this.jobapp_dbDataSet.DataSetName = "Jobapp_dbDataSet";
            this.jobapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employer_detailsTableAdapter
            // 
            this.employer_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // vacancy_detailsTableAdapter
            // 
            this.vacancy_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employer_detailsTableAdapter = this.employer_detailsTableAdapter;
            this.tableAdapterManager.Job_Applications_detailsTableAdapter = null;
            this.tableAdapterManager.Jobseeker_detailsTableAdapter = null;
            this.tableAdapterManager.Resume_detailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JobApp.Jobapp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vacancy_detailsTableAdapter = this.vacancy_detailsTableAdapter;
            // 
            // Search_bt
            // 
            this.Search_bt.Location = new System.Drawing.Point(126, 12);
            this.Search_bt.Name = "Search_bt";
            this.Search_bt.Size = new System.Drawing.Size(103, 37);
            this.Search_bt.TabIndex = 12;
            this.Search_bt.Text = "Search ";
            this.Search_bt.UseVisualStyleBackColor = true;
            this.Search_bt.Click += new System.EventHandler(this.Search_bt_Click);
            // 
            // BrowseJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobApp.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.Search_bt);
            this.Controls.Add(this.dgv_vacacies);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textox_search);
            this.Name = "BrowseJobs";
            this.Text = "BrowseJobs";
            this.Load += new System.EventHandler(this.BrowseJobs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacacies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textox_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findJobsTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem browseJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeeker_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeekerSignUpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_vacacies;
        private Jobapp_dbDataSet jobapp_dbDataSet;
        private System.Windows.Forms.BindingSource employerdetailsBindingSource;
        private Jobapp_dbDataSetTableAdapters.Employer_detailsTableAdapter employer_detailsTableAdapter;
        private Jobapp_dbDataSetTableAdapters.Vacancy_detailsTableAdapter vacancy_detailsTableAdapter;
        private Jobapp_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Search_bt;
    }
}