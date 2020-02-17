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

        private readonly Jobapp_dbEntities jobapp_dbEntities;

        public jobSeeker_Signup()
        {
            jobapp_dbEntities = new Jobapp_dbEntities();
           
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
                    var jobJobseeker_detail = new Jobseeker_details();
                    jobJobseeker_detail.First_name = First_name;
                    jobJobseeker_detail.Last_name = Last_name;
                    jobJobseeker_detail.User_Name = User_name;
                    jobJobseeker_detail.Jobseeker_age = age;
                    jobJobseeker_detail.Password = Create_Password;

                    jobapp_dbEntities.Jobseeker_details.Add(jobJobseeker_detail);
                    jobapp_dbEntities.SaveChanges();

                    MessageBox.Show("Registration was successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
            
        }

        private void jobSeekerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobSeeker_loginView jobSeeker_loginView = new JobSeeker_loginView();
            jobSeeker_loginView.Show();

        }
    }
}
