using System;
using System.Linq;
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
                var Jobseeker_details = _db.Jobseeker_details.FirstOrDefault(q => q.User_Name == user_name && q.Password == password);

                if (Jobseeker_details == null)
                {
                    IsValid = false;
                    MessageBox.Show("Required field is empty");
                }

                if (IsValid)
                {
                    MessageBox.Show("Welcome " + user_name);

                    Job_Seeker_Accountview job_Seeker_Accountview = new Job_Seeker_Accountview(textBox_username.Text);

                    job_Seeker_Accountview.ShowDialog();
                    Close();
                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void Signup_click_lb_Click(object sender, EventArgs e)
        {
            var jobseeker_signup = new JobSeeker_Signup();
            jobseeker_signup.ShowDialog();
                        

        }
    }
}
