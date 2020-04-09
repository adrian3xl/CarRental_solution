namespace JobApp
{
    partial class Review_Applicant
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
            this.app_title.Size = new System.Drawing.Size(249, 39);
            this.app_title.TabIndex = 14;
            this.app_title.Text = "Review Applicants";
            // 
            // Applicant_view
            // 
            this.Applicant_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Applicant_view.Location = new System.Drawing.Point(56, 97);
            this.Applicant_view.Name = "Applicant_view";
            this.Applicant_view.Size = new System.Drawing.Size(690, 270);
            this.Applicant_view.TabIndex = 15;
            // 
            // Review_Applicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Applicant_view);
            this.Controls.Add(this.app_title);
            this.Name = "Review_Applicant";
            this.Text = "Job Application Managemnet System";
            this.Load += new System.EventHandler(this.Review_Applicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.DataGridView Applicant_view;
    }
}