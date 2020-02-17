namespace CarRental
{
    partial class Main_Window
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
            this.window_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_label
            // 
            this.window_label.AutoSize = true;
            this.window_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_label.Location = new System.Drawing.Point(150, 24);
            this.window_label.Name = "window_label";
            this.window_label.Size = new System.Drawing.Size(351, 43);
            this.window_label.TabIndex = 1;
            this.window_label.Text = "Car Rental System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehiclesToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addRemoveVehiclesToolStripMenuItem,
            this.vehicleListingToolStripMenuItem,
            this.editDetailsToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.manageVehiclesToolStripMenuItem.Text = "Manage vehicles";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // addRemoveVehiclesToolStripMenuItem
            // 
            this.addRemoveVehiclesToolStripMenuItem.Name = "addRemoveVehiclesToolStripMenuItem";
            this.addRemoveVehiclesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addRemoveVehiclesToolStripMenuItem.Text = "Add/Remove vehicles";
            // 
            // vehicleListingToolStripMenuItem
            // 
            this.vehicleListingToolStripMenuItem.Name = "vehicleListingToolStripMenuItem";
            this.vehicleListingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vehicleListingToolStripMenuItem.Text = "Vehicle Listing";
            this.vehicleListingToolStripMenuItem.Click += new System.EventHandler(this.vehicleListingToolStripMenuItem_Click);
            // 
            // editDetailsToolStripMenuItem
            // 
            this.editDetailsToolStripMenuItem.Name = "editDetailsToolStripMenuItem";
            this.editDetailsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editDetailsToolStripMenuItem.Text = "Edit Details";
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageRentalsToolStripMenuItem.Text = "Manage Rentals";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Rental Records";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.window_label);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label window_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRemoveVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}