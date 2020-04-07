using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                SHA256 sha = SHA256.Create();

                var user_name = textBox_username.Text;
                var password = textBox_Password.Text;
                var IsValid = true;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i=0; i<data.Length;i++)
                {
                    sBuilder.Append(data[1].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();


                var Jobseeker_details = _db.Jobseeker_details.FirstOrDefault(q => q.User_Name == user_name && q.Password == hashed_password);

                if (Jobseeker_details == null)
                {
                    IsValid = false;
                    MessageBox.Show("Please re-enter user name and password");
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

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
