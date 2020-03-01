using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Job_Seeker_Accountview : Form
    {


        public Job_Seeker_Accountview(string user_name)
        {

            InitializeComponent();
            user_name_tb.Text = user_name;
        }

        private void BrowseJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BrowseJobs = new BrowseJobs();
            BrowseJobs.Show();
        }
    }
}
