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
        private readonly Jobapp_dbEntities _db;
        public JobSeeker_loginView()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        private void Enterloging_jobseek_bt_Click(object sender, EventArgs e)
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

                else
                {
                    var Jobseeker_details = _db.Jobseeker_details.FirstOrDefault(q => q.User_Name == user_name && q.Password == password);




                    if (IsValid)
                    {
                        MessageBox.Show("Welcome ");

                        Job_Seeker_Accountview job_Seeker_Accountview = new Job_Seeker_Accountview();

                        job_Seeker_Accountview.Show();
                        //job_Seeker_Accountview.Close();

                    }
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
