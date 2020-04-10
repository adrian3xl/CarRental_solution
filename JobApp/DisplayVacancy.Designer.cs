namespace JobApp
{
    partial class Display_Vacancy
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
            this.vacancy = new System.Windows.Forms.DataGridView();
            this.createVacancy = new System.Windows.Forms.Button();
            this.VacancyAddForm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.del_bt = new System.Windows.Forms.Button();
            this.prev_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy)).BeginInit();
            this.SuspendLayout();
            // 
            // vacancy
            // 
            this.vacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacancy.Location = new System.Drawing.Point(40, 74);
            this.vacancy.Name = "vacancy";
            this.vacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vacancy.Size = new System.Drawing.Size(748, 292);
            this.vacancy.TabIndex = 0;
            // 
            // createVacancy
            // 
            this.createVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.createVacancy.Location = new System.Drawing.Point(40, 382);
            this.createVacancy.Name = "createVacancy";
            this.createVacancy.Size = new System.Drawing.Size(133, 43);
            this.createVacancy.TabIndex = 1;
            this.createVacancy.Text = "CREATE";
            this.createVacancy.UseVisualStyleBackColor = true;
            this.createVacancy.Click += new System.EventHandler(this.CreateNew);
            // 
            // VacancyAddForm
            // 
            this.VacancyAddForm.AllowDrop = true;
            this.VacancyAddForm.AutoSize = true;
            this.VacancyAddForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VacancyAddForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VacancyAddForm.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VacancyAddForm.Location = new System.Drawing.Point(301, 9);
            this.VacancyAddForm.Name = "VacancyAddForm";
            this.VacancyAddForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VacancyAddForm.Size = new System.Drawing.Size(233, 52);
            this.VacancyAddForm.TabIndex = 15;
            this.VacancyAddForm.Text = "Your Vacancies";
            this.VacancyAddForm.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(322, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Vacancy);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(725, 21);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(29, 13);
            this.lb_id.TabIndex = 17;
            this.lb_id.Text = "lb_id";
            this.lb_id.Visible = false;
            // 
            // del_bt
            // 
            this.del_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.del_bt.Location = new System.Drawing.Point(580, 382);
            this.del_bt.Name = "del_bt";
            this.del_bt.Size = new System.Drawing.Size(133, 43);
            this.del_bt.TabIndex = 18;
            this.del_bt.Text = "Delete";
            this.del_bt.UseVisualStyleBackColor = true;
            this.del_bt.Click += new System.EventHandler(this.del_bt_Click);
            // 
            // prev_bt
            // 
            this.prev_bt.BackColor = System.Drawing.SystemColors.Highlight;
            this.prev_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.prev_bt.Location = new System.Drawing.Point(40, 32);
            this.prev_bt.Name = "prev_bt";
            this.prev_bt.Size = new System.Drawing.Size(141, 36);
            this.prev_bt.TabIndex = 19;
            this.prev_bt.Text = "Previous Window";
            this.prev_bt.UseVisualStyleBackColor = false;
            this.prev_bt.Click += new System.EventHandler(this.prev_bt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(671, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Refresh listing";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Display_Vacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prev_bt);
            this.Controls.Add(this.del_bt);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VacancyAddForm);
            this.Controls.Add(this.createVacancy);
            this.Controls.Add(this.vacancy);
            this.Name = "Display_Vacancy";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Display_vacancy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vacancy;
        private System.Windows.Forms.Button createVacancy;
        private System.Windows.Forms.Label VacancyAddForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button del_bt;
        private System.Windows.Forms.Button prev_bt;
        private System.Windows.Forms.Button button2;
    }
}