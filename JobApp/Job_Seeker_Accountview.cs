using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Job_Seeker_Accountview : Form
    {
        private readonly Jobapp_dbEntities _db;

        public Job_Seeker_Accountview(string user_name)
        {

            InitializeComponent();
            _db = new Jobapp_dbEntities();
            user_name_tb.Text = user_name;
        }

        private void BrowseJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BrowseJobs = new BrowseJobs();
            BrowseJobs.Show();
        }

        private void addResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Education_level;
            var Qualifications;
            var experience;
            var Hobbies;
            var Contact;
            var Email;
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
