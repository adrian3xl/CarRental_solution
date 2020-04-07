using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Submit_jobapplication : Form
    {
        private readonly Jobapp_dbEntities _db;
        private int _jbsId;
        private int VId;
        private int ResumeId;
        //_JobId
        public Submit_jobapplication()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();

        }

        public Submit_jobapplication(int jbsId)
        {
            InitializeComponent();            
            
        }

        public Submit_jobapplication(BrowseJobs browseJobs, Vacancy_details vacancy,int id,int vacanId)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            _jbsId = id;
            VId = vacanId;
            //MessageBox.Show($"fsdfs: {_jbsId}");
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {
           // var JobSkrTable = new Resume_details();
            var Data = _db.Resume_details.FirstOrDefault(q => q.id == 3);
            var JobseekerData = _db.Resume_details.FirstOrDefault(q => q.Jobseeker_details_id ==_jbsId);
           var ResumeId = JobseekerData.id;

            // int ResumeId = Data.id;

           var Applicant = new Job_Applications_details
            {
                resume_id = ResumeId,
                Jobseeker_id = _jbsId,
                vacancy_id = VId,
                Application_status ="Pending"  
            };

             _db.Job_Applications_details.Add(Applicant);
             _db.SaveChanges();


            // lb_id.Text = resume.id.ToString();


             var Id = int.Parse(lb_id.Text);
             var vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == Id);

          //   _db.SaveChanges();

          // _db.Job_Applications_details.Add(this, vacancy, resume);
            // _db.SaveChanges();*/

            
            
            
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetDropDown(object sender, EventArgs e)
        {

            var data = _db.Resume_details.ToList();
            selectJob.DisplayMember = "Education_level";
            selectJob.ValueMember = "id";
            selectJob.DataSource = data;
        }
        
    }
}
