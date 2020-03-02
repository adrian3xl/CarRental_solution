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

        private void addResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Job_Seeker_Accountview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobapp_dbDataSet.Job_Applications_details' table. You can move, or remove it, as needed.
            this.job_Applications_detailsTableAdapter.Fill(this.jobapp_dbDataSet.Job_Applications_details);

        }
    }
}
