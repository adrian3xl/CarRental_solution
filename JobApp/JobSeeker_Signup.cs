using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class JobSeeker_Signup : Form
    {

        private readonly Jobapp_dbEntities _db;

        public JobSeeker_Signup()
        {
            _db = new Jobapp_dbEntities();

            InitializeComponent();



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
                    var jobJobseeker_detail = new Jobseeker_details
                    {
                        First_name = First_name,
                        Last_name = Last_name,
                        User_Name = User_name,
                        Jobseeker_age = age,
                        Password = Create_Password
                    };

                    _db.Jobseeker_details.Add(jobJobseeker_detail);
                    _db.SaveChanges();

                    MessageBox.Show("Registration was successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }

        }

        private void JobSeekerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobSeeker_loginView jobSeeker_loginView = new JobSeeker_loginView();
            jobSeeker_loginView.Show();

        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
