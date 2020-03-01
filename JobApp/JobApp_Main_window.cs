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
    public partial class JobApp_Main_window : Form
    {
        public JobApp_Main_window()
        {
            InitializeComponent();
        }



        private void JobSeekerSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobSeeker_Signup = new JobSeeker_Signup
            {
                MdiParent = this
            };
            jobSeeker_Signup.Show();
        }

        private void JobSeekerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobSeeker_loginView = new JobSeeker_loginView
            {
                MdiParent = this
            };
            jobSeeker_loginView.Show();
        }

        private void EmployerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employer_signup = new Employer_signup
            {
                MdiParent = this
            };
            employer_signup.Show();
        }

        private void EmployerLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var employee_loginview = new Employer_loginview
            {
                MdiParent = this
            };
            employee_loginview.Show();
        }
    }
}
