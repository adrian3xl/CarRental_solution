namespace CarRental
{
    partial class Add_Edit_Cars
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.window_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_change_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.tbox_license = new System.Windows.Forms.TextBox();
            this.tbox_vin = new System.Windows.Forms.TextBox();
            this.tbox_make = new System.Windows.Forms.TextBox();
            this.tbox_model = new System.Windows.Forms.TextBox();
            this.tbox_year = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.75779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.24222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tbox_year, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbox_model, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbox_make, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.window_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbox_license, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbox_vin, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // window_label
            // 
            this.window_label.AutoSize = true;
            this.window_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_label.Location = new System.Drawing.Point(3, 0);
            this.window_label.Name = "window_label";
            this.window_label.Size = new System.Drawing.Size(47, 17);
            this.window_label.TabIndex = 2;
            this.window_label.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "LicensePlateNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "VIN";
            // 
            // Save_change_btn
            // 
            this.Save_change_btn.Location = new System.Drawing.Point(91, 380);
            this.Save_change_btn.Name = "Save_change_btn";
            this.Save_change_btn.Size = new System.Drawing.Size(144, 44);
            this.Save_change_btn.TabIndex = 1;
            this.Save_change_btn.Text = "Save Changes";
            this.Save_change_btn.UseVisualStyleBackColor = true;
            this.Save_change_btn.Click += new System.EventHandler(this.Save_change_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(415, 380);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(144, 44);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // tbox_license
            // 
            this.tbox_license.Location = new System.Drawing.Point(175, 180);
            this.tbox_license.Name = "tbox_license";
            this.tbox_license.Size = new System.Drawing.Size(269, 20);
            this.tbox_license.TabIndex = 7;
            // 
            // tbox_vin
            // 
            this.tbox_vin.Location = new System.Drawing.Point(175, 239);
            this.tbox_vin.Name = "tbox_vin";
            this.tbox_vin.Size = new System.Drawing.Size(269, 20);
            this.tbox_vin.TabIndex = 8;
            // 
            // tbox_make
            // 
            this.tbox_make.Location = new System.Drawing.Point(175, 3);
            this.tbox_make.Name = "tbox_make";
            this.tbox_make.Size = new System.Drawing.Size(269, 20);
            this.tbox_make.TabIndex = 9;
            // 
            // tbox_model
            // 
            this.tbox_model.Location = new System.Drawing.Point(175, 62);
            this.tbox_model.Name = "tbox_model";
            this.tbox_model.Size = new System.Drawing.Size(269, 20);
            this.tbox_model.TabIndex = 10;
            // 
            // tbox_year
            // 
            this.tbox_year.Location = new System.Drawing.Point(175, 121);
            this.tbox_year.Name = "tbox_year";
            this.tbox_year.Size = new System.Drawing.Size(269, 20);
            this.tbox_year.TabIndex = 11;
            // 
            // Add_Edit_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_change_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Edit_Cars";
            this.Text = "Add_Edit_Cars";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label window_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_change_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.TextBox tbox_year;
        private System.Windows.Forms.TextBox tbox_model;
        private System.Windows.Forms.TextBox tbox_make;
        private System.Windows.Forms.TextBox tbox_license;
        private System.Windows.Forms.TextBox tbox_vin;
    }
}