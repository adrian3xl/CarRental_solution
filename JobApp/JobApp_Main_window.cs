using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class JobApp_Main_window : Form
    {
        public JobApp_Main_window()
        {
            InitializeComponent();
        }



        private void JobSeekerSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobSeeker_Signup = new JobSeeker_Signup();


               jobSeeker_Signup.ShowDialog();
            jobSeeker_Signup.MdiParent = this;
        }

        private void JobSeekerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobSeeker_loginView = new JobSeeker_loginView();


               jobSeeker_loginView.ShowDialog();
            jobSeeker_loginView.MdiParent = this;

        }

        private void EmployerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employer_signup = new Employer_signup();

            employer_signup.ShowDialog();
            employer_signup.MdiParent = this;
            
            
        }

        private void EmployerLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var employee_loginview = new Employer_loginview();

            employee_loginview.ShowDialog();
            employee_loginview.MdiParent = this;
           
            
        }
    }
}
