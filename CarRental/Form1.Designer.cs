using System.Windows.Forms;

namespace CarRental
{
    partial class Form1
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
            this.txtbox_owner = new System.Windows.Forms.TextBox();
            this.drpbox_cartype = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
 
            this.daterented = new System.Windows.Forms.DateTimePicker();
            this.datereturned = new System.Windows.Forms.DateTimePicker();
 
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ;
 
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtbox_cost = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtbox_id_number = new System.Windows.Forms.TextBox();
            this.txtbox_submit = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtbox_lastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental";
            // 
            // txtbox_owner
            // 
            this.txtbox_owner.Location = new System.Drawing.Point(12, 97);
            this.txtbox_owner.Name = "txtbox_owner";
            this.txtbox_owner.Size = new System.Drawing.Size(136, 20);
            this.txtbox_owner.TabIndex = 1;
            // 
            // drpbox_cartype
            // 
            this.drpbox_cartype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpbox_cartype.FormattingEnabled = true;
            this.drpbox_cartype.Items.AddRange(new object[] {
            "Honda Stream",
            "Tayota Corola",
            "Suzuki Swift",
            "Mazda "});
            this.drpbox_cartype.Location = new System.Drawing.Point(210, 96);
            this.drpbox_cartype.Name = "drpbox_cartype";
            this.drpbox_cartype.Size = new System.Drawing.Size(121, 21);
            this.drpbox_cartype.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Owner";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(210, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 13);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Type Of Car";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(14, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 13);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Rent Date";
            // 
 
            // daterented
            // 
            this.daterented.Location = new System.Drawing.Point(12, 170);
            this.daterented.Name = "daterented";
            this.daterented.Size = new System.Drawing.Size(200, 20);
            this.daterented.TabIndex = 6;
            // 
            // datereturned
            // 
            this.datereturned.Location = new System.Drawing.Point(288, 170);
            this.datereturned.Name = "datereturned";
            this.datereturned.Size = new System.Drawing.Size(200, 20);
            this.datereturned.TabIndex = 8;
 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
             
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(300, 151);
            this.textBox5.Name = "textBox5";
 
            this.textBox5.Size = new System.Drawing.Size(80, 13);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Return Date";
 
            this.textBox5.Size = new System.Drawing.Size(63, 13);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Rent Date";
 
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(12, 214);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 13);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Customer First Name";
            // 
            // txtbox_firstname
            // 
            this.txtbox_firstname.Location = new System.Drawing.Point(12, 234);
            this.txtbox_firstname.Name = "txtbox_firstname";
            this.txtbox_firstname.Size = new System.Drawing.Size(136, 20);
            this.txtbox_firstname.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(380, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(99, 13);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "Cost";
            // 
            // txtbox_cost
            // 
            this.txtbox_cost.Location = new System.Drawing.Point(380, 97);
            this.txtbox_cost.Name = "txtbox_cost";
            this.txtbox_cost.Size = new System.Drawing.Size(136, 20);
            this.txtbox_cost.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(380, 214);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(99, 13);
            this.textBox10.TabIndex = 14;
            this.textBox10.Text = "ID number";
            // 
            // txtbox_id_number
            // 
            this.txtbox_id_number.Location = new System.Drawing.Point(380, 234);
            this.txtbox_id_number.Name = "txtbox_id_number";
            this.txtbox_id_number.Size = new System.Drawing.Size(136, 20);
            this.txtbox_id_number.TabIndex = 13;
            // 
            // txtbox_submit
            // 
            this.txtbox_submit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_submit.Location = new System.Drawing.Point(184, 320);
            this.txtbox_submit.Name = "txtbox_submit";
            this.txtbox_submit.Size = new System.Drawing.Size(144, 39);
            this.txtbox_submit.TabIndex = 15;
            this.txtbox_submit.Text = "Submit";
            this.txtbox_submit.UseVisualStyleBackColor = true;
            this.txtbox_submit.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(192, 214);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(136, 13);
            this.textBox12.TabIndex = 17;
            this.textBox12.Text = "Customer Last Name";
            // 
            // txtbox_lastname
            // 
            this.txtbox_lastname.Location = new System.Drawing.Point(192, 234);
            this.txtbox_lastname.Name = "txtbox_lastname";
            this.txtbox_lastname.Size = new System.Drawing.Size(136, 20);
            this.txtbox_lastname.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtbox_lastname);
            this.Controls.Add(this.txtbox_submit);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtbox_id_number);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtbox_cost);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtbox_firstname);
 
            this.Controls.Add(this.datereturned);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.daterented);
 
          
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker1);
 
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.drpbox_cartype);
            this.Controls.Add(this.txtbox_owner);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_owner;
        private System.Windows.Forms.ComboBox drpbox_cartype;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
 
        private System.Windows.Forms.DateTimePicker daterented;
        private System.Windows.Forms.DateTimePicker datereturned;
        private DateTimePicker dateTimePicker2;
 
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        
 
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtbox_firstname;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtbox_cost;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtbox_id_number;
        private System.Windows.Forms.Button txtbox_submit;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtbox_lastname;
    }
}

