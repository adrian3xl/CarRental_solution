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
    public partial class JobSeeker_loginView : Form
    {
        public JobSeeker_loginView()
        {
            InitializeComponent();
        }

        private void enterloging_jobseek_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var user_name = textBox_username.Text;
                var password = textBox_Password.Text;
                var IsValid = true;

                if (string.IsNullOrWhiteSpace(user_name) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Required field is empty");
                }
                if (IsValid)
                {

                    Job_Seeker_Accountview job_Seeker_Accountview = new Job_Seeker_Accountview();

                    job_Seeker_Accountview.Show();
                    //job_Seeker_Accountview.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }
    }
}
