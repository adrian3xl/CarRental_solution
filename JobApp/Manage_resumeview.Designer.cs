namespace JobApp
{
    partial class Manage_resumeview
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
            this.add_bt = new System.Windows.Forms.Button();
            this.Delete_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            this.dgv_resumeview = new System.Windows.Forms.DataGridView();
            this.Manage_lb = new System.Windows.Forms.Label();
            this.refresh_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumeview)).BeginInit();
            this.SuspendLayout();
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(127, 402);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(170, 50);
            this.add_bt.TabIndex = 0;
            this.add_bt.Text = "Add Resume";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.Add_bt_Click);
            // 
            // Delete_bt
            // 
            this.Delete_bt.Location = new System.Drawing.Point(694, 402);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(170, 50);
            this.Delete_bt.TabIndex = 1;
            this.Delete_bt.Text = "Delete Resume";
            this.Delete_bt.UseVisualStyleBackColor = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // edit_bt
            // 
            this.edit_bt.Location = new System.Drawing.Point(407, 402);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(170, 50);
            this.edit_bt.TabIndex = 2;
            this.edit_bt.Text = "Edit Resume";
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.Edit_bt_Click);
            // 
            // dgv_resumeview
            // 
            this.dgv_resumeview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumeview.Location = new System.Drawing.Point(12, 75);
            this.dgv_resumeview.Name = "dgv_resumeview";
            this.dgv_resumeview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resumeview.Size = new System.Drawing.Size(862, 298);
            this.dgv_resumeview.TabIndex = 12;
            // 
            // Manage_lb
            // 
            this.Manage_lb.AllowDrop = true;
            this.Manage_lb.AutoSize = true;
            this.Manage_lb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Manage_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Manage_lb.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_lb.Location = new System.Drawing.Point(44, 9);
            this.Manage_lb.Name = "Manage_lb";
            this.Manage_lb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Manage_lb.Size = new System.Drawing.Size(244, 52);
            this.Manage_lb.TabIndex = 13;
            this.Manage_lb.Text = "Manage Resume";
            this.Manage_lb.UseCompatibleTextRendering = true;
            // 
            // refresh_bt
            // 
            this.refresh_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refresh_bt.Location = new System.Drawing.Point(726, 38);
            this.refresh_bt.Name = "refresh_bt";
            this.refresh_bt.Size = new System.Drawing.Size(138, 23);
            this.refresh_bt.TabIndex = 14;
            this.refresh_bt.Text = "Click here to refresh table";
            this.refresh_bt.UseVisualStyleBackColor = false;
            this.refresh_bt.Click += new System.EventHandler(this.refresh_bt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage_resumeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh_bt);
            this.Controls.Add(this.Manage_lb);
            this.Controls.Add(this.dgv_resumeview);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.Delete_bt);
            this.Controls.Add(this.add_bt);
            this.Name = "Manage_resumeview";
            this.Text = "Job Application Management System";
            this.Load += new System.EventHandler(this.Manage_resumeview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumeview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button Delete_bt;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.DataGridView dgv_resumeview;
        private System.Windows.Forms.Label Manage_lb;
        private System.Windows.Forms.Button refresh_bt;
        private System.Windows.Forms.Button button1;
    }
}