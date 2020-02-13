namespace CarRental
{
    partial class Vehicle_Listing
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
            this.dataGrid_forcars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_forcars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_forcars
            // 
            this.dataGrid_forcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_forcars.Location = new System.Drawing.Point(101, 92);
            this.dataGrid_forcars.Name = "dataGrid_forcars";
            this.dataGrid_forcars.Size = new System.Drawing.Size(457, 245);
            this.dataGrid_forcars.TabIndex = 0;
            // 
            // Vehicle_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_forcars);
            this.Name = "Vehicle_Listing";
            this.Text = "Vehicle_Listing";
            this.Load += new System.EventHandler(this.Vehicle_Listing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_forcars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_forcars;
    }
}