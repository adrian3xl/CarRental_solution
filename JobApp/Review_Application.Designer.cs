namespace JobApp
{
    partial class Review_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_bt = new System.Windows.Forms.Button();
            this.Status_tb = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // Submit_bt
            // 
            this.Submit_bt.Location = new System.Drawing.Point(157, 153);
            this.Submit_bt.Name = "Submit_bt";
            this.Submit_bt.Size = new System.Drawing.Size(113, 32);
            this.Submit_bt.TabIndex = 1;
            this.Submit_bt.Text = "Submit";
            this.Submit_bt.UseVisualStyleBackColor = true;
            this.Submit_bt.Click += new System.EventHandler(this.Submit_bt_Click);
            // 
            // Status_tb
            // 
            this.Status_tb.Location = new System.Drawing.Point(131, 100);
            this.Status_tb.Multiline = true;
            this.Status_tb.Name = "Status_tb";
            this.Status_tb.Size = new System.Drawing.Size(158, 29);
            this.Status_tb.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(404, 13);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(35, 13);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "label2";
            this.lb_id.Visible = false;
            // 
            // Review_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 210);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.Status_tb);
            this.Controls.Add(this.Submit_bt);
            this.Controls.Add(this.label1);
            this.Name = "Review_Application";
            this.Text = "Review Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit_bt;
        private System.Windows.Forms.TextBox Status_tb;
        private System.Windows.Forms.Label lb_id;
    }
}