namespace JobApp
{
    partial class Jobseeker_vacancy_view
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findJobsTool_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.browseJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeeker_itembox = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSeekerSignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobapp_dbDataSet = new JobApp.Jobapp_dbDataSet();
            this.vacancydetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancy_detailsTableAdapter = new JobApp.Jobapp_dbDataSetTableAdapters.Vacancy_detailsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDiscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobRequirementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joblevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitdeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancydetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findJobsTool_itembox,
            this.jobSeeker_itembox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(71, 450);
            this.menuStrip1.TabIndex = 10;
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
            // 
            // advanceSearchToolStripMenuItem
            // 
            this.advanceSearchToolStripMenuItem.Name = "advanceSearchToolStripMenuItem";
            this.advanceSearchToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.advanceSearchToolStripMenuItem.Text = "Advance Search";
            // 
            // jobSeeker_itembox
            // 
            this.jobSeeker_itembox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobSeeker_itembox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobSeekerSignUpToolStripMenuItem});
            this.jobSeeker_itembox.Name = "jobSeeker_itembox";
            this.jobSeeker_itembox.Size = new System.Drawing.Size(70, 19);
            this.jobSeeker_itembox.Text = "Job Seeker";
            this.jobSeeker_itembox.Visible = false;
            // 
            // jobSeekerSignUpToolStripMenuItem
            // 
            this.jobSeekerSignUpToolStripMenuItem.Name = "jobSeekerSignUpToolStripMenuItem";
            this.jobSeekerSignUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jobSeekerSignUpToolStripMenuItem.Text = "Job Seeker Sign out";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.jobDiscriptionDataGridViewTextBoxColumn,
            this.jobRequirementsDataGridViewTextBoxColumn,
            this.joblevelDataGridViewTextBoxColumn,
            this.employmenttypeDataGridViewTextBoxColumn,
            this.submitdeadlineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vacancydetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 351);
            this.dataGridView1.TabIndex = 11;
            // 
            // jobapp_dbDataSet
            // 
            this.jobapp_dbDataSet.DataSetName = "Jobapp_dbDataSet";
            this.jobapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacancydetailsBindingSource
            // 
            this.vacancydetailsBindingSource.DataMember = "Vacancy_details";
            this.vacancydetailsBindingSource.DataSource = this.jobapp_dbDataSet;
            // 
            // vacancy_detailsTableAdapter
            // 
            this.vacancy_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Job Title";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            this.jobtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobDiscriptionDataGridViewTextBoxColumn
            // 
            this.jobDiscriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobDiscriptionDataGridViewTextBoxColumn.DataPropertyName = "Job_Discription";
            this.jobDiscriptionDataGridViewTextBoxColumn.HeaderText = "Job Discription";
            this.jobDiscriptionDataGridViewTextBoxColumn.Name = "jobDiscriptionDataGridViewTextBoxColumn";
            this.jobDiscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobRequirementsDataGridViewTextBoxColumn
            // 
            this.jobRequirementsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobRequirementsDataGridViewTextBoxColumn.DataPropertyName = "Job_Requirements";
            this.jobRequirementsDataGridViewTextBoxColumn.HeaderText = "Job Requirements";
            this.jobRequirementsDataGridViewTextBoxColumn.Name = "jobRequirementsDataGridViewTextBoxColumn";
            this.jobRequirementsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joblevelDataGridViewTextBoxColumn
            // 
            this.joblevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joblevelDataGridViewTextBoxColumn.DataPropertyName = "Job_level";
            this.joblevelDataGridViewTextBoxColumn.HeaderText = "Job level";
            this.joblevelDataGridViewTextBoxColumn.Name = "joblevelDataGridViewTextBoxColumn";
            this.joblevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employmenttypeDataGridViewTextBoxColumn
            // 
            this.employmenttypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employmenttypeDataGridViewTextBoxColumn.DataPropertyName = "Employment_type";
            this.employmenttypeDataGridViewTextBoxColumn.HeaderText = "Employment type";
            this.employmenttypeDataGridViewTextBoxColumn.Name = "employmenttypeDataGridViewTextBoxColumn";
            this.employmenttypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // submitdeadlineDataGridViewTextBoxColumn
            // 
            this.submitdeadlineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.submitdeadlineDataGridViewTextBoxColumn.DataPropertyName = "Submit_deadline";
            this.submitdeadlineDataGridViewTextBoxColumn.HeaderText = "Submit deadline";
            this.submitdeadlineDataGridViewTextBoxColumn.Name = "submitdeadlineDataGridViewTextBoxColumn";
            this.submitdeadlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Jobseeker_vacancy_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Jobseeker_vacancy_view";
            this.Text = "Jobseeker_vacancy_view";
            this.Load += new System.EventHandler(this.Jobseeker_vacancy_view_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobapp_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancydetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findJobsTool_itembox;
        private System.Windows.Forms.ToolStripMenuItem browseJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobSeeker_itembox;
        private System.Windows.Forms.ToolStripMenuItem jobSeekerSignUpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Jobapp_dbDataSet jobapp_dbDataSet;
        private System.Windows.Forms.BindingSource vacancydetailsBindingSource;
        private Jobapp_dbDataSetTableAdapters.Vacancy_detailsTableAdapter vacancy_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDiscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRequirementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joblevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitdeadlineDataGridViewTextBoxColumn;
    }
}