namespace JobApp
{
    partial class Applicant_status
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
            this.app_title = new System.Windows.Forms.Label();
            this.Applicant_view = new System.Windows.Forms.DataGridView();
            this.quary_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_view)).BeginInit();
            this.SuspendLayout();
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.app_title.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_title.Location = new System.Drawing.Point(254, 9);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(234, 39);
            this.app_title.TabIndex = 14;
            this.app_title.Text = " Applicant Status";
            // 
            // Applicant_view
            // 
            this.Applicant_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Applicant_view.Location = new System.Drawing.Point(12, 71);
            this.Applicant_view.Name = "Applicant_view";
            this.Applicant_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Applicant_view.Size = new System.Drawing.Size(977, 181);
            this.Applicant_view.TabIndex = 15;
            // 
            // quary_bt
            // 
            this.quary_bt.Location = new System.Drawing.Point(12, 258);
            this.quary_bt.Name = "quary_bt";
            this.quary_bt.Size = new System.Drawing.Size(119, 23);
            this.quary_bt.TabIndex = 16;
            this.quary_bt.Text = "Quary Applicant";
            this.quary_bt.UseVisualStyleBackColor = true;
            this.quary_bt.Click += new System.EventHandler(this.Quary_bt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Applicant_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quary_bt);
            this.Controls.Add(this.Applicant_view);
            this.Controls.Add(this.app_title);
            this.Name = "Applicant_status";
            this.Text = "Job Application Managemnet System";
            this.Load += new System.EventHandler(this.Review_Applicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.DataGridView Applicant_view;
        private System.Windows.Forms.Button quary_bt;
        private System.Windows.Forms.Button button1;
    }
}