using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Job_Seeker_Accountview : Form
    {
        private readonly Jobapp_dbEntities _db;
        private int Job_seeker_id;

        public Job_Seeker_Accountview()
        {
        }

        public Job_Seeker_Accountview(int JBskId, string user_name)
        {

            InitializeComponent();
            _db = new Jobapp_dbEntities();
            user_name_tb.Text = user_name;
            var job_seeker = new Jobseeker_details();
            Job_seeker_id = JBskId;
            MessageBox.Show($"{Job_seeker_id}");
        }

        private void BrowseJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var submit_pass_id = new Submit_jobapplication(Job_seeker_id);
            var BrowseJobs = new BrowseJobs(Job_seeker_id);
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
                    q.Vacancy_details.Job_title,
                    Job_SeekerID =  q.Jobseeker_id

                }).Where(s=>s.Job_SeekerID == Job_seeker_id).ToList();

                gv_appstatus_list.DataSource = application;
                gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                // gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                gv_appstatus_list.Columns["Job_title"].HeaderText = "Job Title";
                gv_appstatus_list.Columns["ID"].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show($"error: {err}");
                // throw;
            }
        }


        private void Manageresume_MenuItem_Click(object sender, EventArgs e)
        {
            var Manage_resumeview = new Manage_resumeview();
            Manage_resumeview.MdiParent = this.MdiParent;
            Manage_resumeview.Show();
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
