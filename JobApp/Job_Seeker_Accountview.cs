using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Job_Seeker_Accountview : Form
    {
        private readonly Jobapp_dbEntities _db;

        public Job_Seeker_Accountview()
        {
        }

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

        private void Job_Seeker_Accountview_Load(object sender, EventArgs e)
        {

            try
            {
                var application = _db.Job_Applications_details.Select(q => new
                {
                    ID = q.id,
                    q.Application_status,
                    Resume_details = q.Resume_details.Jobseeker_details.First_name + "" + q.Resume_details.Jobseeker_details.Last_name,
                    q.Vacancy_details.Job_title

                }).ToList();

                gv_appstatus_list.DataSource = application;
                gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                // gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                gv_appstatus_list.Columns["Job_title"].HeaderText = "Job Title";
                gv_appstatus_list.Columns["ID"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                // throw;
            }
        }


        private void Manageresume_MenuItem_Click(object sender, EventArgs e)
        {
            var Manage_resumeview = new Manage_resumeview();
            Manage_resumeview.MdiParent = this.MdiParent;
            Manage_resumeview.Show();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Reminder_icon.Show(694, 6);
        }

        private void jobSeekerSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //   private void addResumeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        // var Education_level;
        //  var Qualifications;
        // var experience;
        //  var Hobbies;
        //   var Contact;
        // var Email;
        //  }



    }
}
