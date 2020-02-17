using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class jobSeeker_Signup : Form
    {

        

        public jobSeeker_Signup()
        {
            
            InitializeComponent();

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var First_name = textBox_fname.Text;
                var Last_name = textBox_lname.Text;
                int age = int.Parse(textBox_age.Text);
                var User_name = textBox_username.Text;
                var Create_Password = textBox_username.Text;
                var IsValid = true;

                if (string.IsNullOrWhiteSpace(First_name) || string.IsNullOrWhiteSpace(Last_name) || string.IsNullOrWhiteSpace(User_name) || string.IsNullOrWhiteSpace(Create_Password))
                {
                    IsValid = false;
                    MessageBox.Show("Error, required fields were not populated");

                }
                if (age <= 0 || age < 18)
                {
                    IsValid = false;
                    MessageBox.Show("Too young for this application");
                }

                if (IsValid)
                {
                    MessageBox.Show("Registration was successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
            
        }
    }
}
