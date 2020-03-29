namespace JobApp
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.Notification = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // Notification
            // 
            this.Notification.BackColor = System.Drawing.Color.Transparent;
            this.Notification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Notification.BackgroundImage")));
            this.Notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notification.Image = ((System.Drawing.Image)(resources.GetObject("Notification.Image")));
            this.Notification.ImageLocation = "";
            this.Notification.Location = new System.Drawing.Point(0, 0);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(256, 90);
            this.Notification.TabIndex = 0;
            this.Notification.TabStop = false;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(256, 90);
            this.Controls.Add(this.Notification);
            this.Name = "Reminder";
            this.Text = "Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Notification;
    }
}