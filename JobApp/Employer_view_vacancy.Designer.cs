namespace JobApp
{
    partial class Employer_view_vacancy
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
            this.Delete_vacac_bt = new System.Windows.Forms.Button();
            this.editvacanc_button1 = new System.Windows.Forms.Button();
            this.Add_vacancy_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete_vacac_bt
            // 
            this.Delete_vacac_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_vacac_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_vacac_bt.Location = new System.Drawing.Point(496, 388);
            this.Delete_vacac_bt.Name = "Delete_vacac_bt";
            this.Delete_vacac_bt.Size = new System.Drawing.Size(154, 50);
            this.Delete_vacac_bt.TabIndex = 41;
            this.Delete_vacac_bt.Text = "Edit vacancy";
            this.Delete_vacac_bt.UseVisualStyleBackColor = false;
            // 
            // editvacanc_button1
            // 
            this.editvacanc_button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editvacanc_button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editvacanc_button1.Location = new System.Drawing.Point(288, 388);
            this.editvacanc_button1.Name = "editvacanc_button1";
            this.editvacanc_button1.Size = new System.Drawing.Size(154, 50);
            this.editvacanc_button1.TabIndex = 40;
            this.editvacanc_button1.Text = "Edit vacancy";
            this.editvacanc_button1.UseVisualStyleBackColor = false;
            // 
            // Add_vacancy_bt
            // 
            this.Add_vacancy_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_vacancy_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_vacancy_bt.Location = new System.Drawing.Point(77, 388);
            this.Add_vacancy_bt.Name = "Add_vacancy_bt";
            this.Add_vacancy_bt.Size = new System.Drawing.Size(154, 50);
            this.Add_vacancy_bt.TabIndex = 39;
            this.Add_vacancy_bt.Text = "Add vacancy";
            this.Add_vacancy_bt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "Employer Vacany view";
            // 
            // Employer_view_vacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_vacac_bt);
            this.Controls.Add(this.editvacanc_button1);
            this.Controls.Add(this.Add_vacancy_bt);
            this.Name = "Employer_view_vacancy";
            this.Text = "Job Application Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_vacac_bt;
        private System.Windows.Forms.Button editvacanc_button1;
        private System.Windows.Forms.Button Add_vacancy_bt;
        private System.Windows.Forms.Label label1;
    }
}