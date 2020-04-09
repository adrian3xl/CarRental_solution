namespace JobApp
{
    partial class Submit_jobapplication
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
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.Submit_bt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.selectJob = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Location = new System.Drawing.Point(530, 408);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(129, 54);
            this.Cancel_bt.TabIndex = 52;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = true;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // Submit_bt
            // 
            this.Submit_bt.Location = new System.Drawing.Point(789, 408);
            this.Submit_bt.Name = "Submit_bt";
            this.Submit_bt.Size = new System.Drawing.Size(129, 54);
            this.Submit_bt.TabIndex = 53;
            this.Submit_bt.Text = "Submit";
            this.Submit_bt.UseVisualStyleBackColor = true;
            this.Submit_bt.Click += new System.EventHandler(this.Submit_bt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 39);
            this.label7.TabIndex = 54;
            this.label7.Text = "Submit Resume";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(1025, 22);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(29, 13);
            this.lb_id.TabIndex = 57;
            this.lb_id.Text = "lb_id";
            // 
            // selectJob
            // 
            this.selectJob.FormattingEnabled = true;
            this.selectJob.Location = new System.Drawing.Point(454, 281);
            this.selectJob.Name = "selectJob";
            this.selectJob.Size = new System.Drawing.Size(319, 21);
            this.selectJob.TabIndex = 58;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(533, 155);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(79, 29);
            this.NameBox.TabIndex = 59;
            this.NameBox.Text = "label1";
            this.NameBox.Click += new System.EventHandler(this.NameBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Job Applied:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submit_jobapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.selectJob);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Submit_bt);
            this.Controls.Add(this.Cancel_bt);
            this.Name = "Submit_jobapplication";
            this.Text = "Submit_jobapplication";
            this.Load += new System.EventHandler(this.SetDropDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel_bt;
        private System.Windows.Forms.Button Submit_bt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox selectJob;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label label1;
    }
}