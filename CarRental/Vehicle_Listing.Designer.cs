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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_forcars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_forcars
            // 
            this.dataGrid_forcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_forcars.Location = new System.Drawing.Point(41, 48);
            this.dataGrid_forcars.Name = "dataGrid_forcars";
            this.dataGrid_forcars.Size = new System.Drawing.Size(734, 342);
            this.dataGrid_forcars.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(83, 388);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(144, 50);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(331, 388);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(144, 50);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(606, 388);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(144, 50);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Delete Car";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // Vehicle_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGrid_forcars);
            this.Name = "Vehicle_Listing";
            this.Text = "Vehicle_Listing";
            this.Load += new System.EventHandler(this.Vehicle_Listing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_forcars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_forcars;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
    }
}