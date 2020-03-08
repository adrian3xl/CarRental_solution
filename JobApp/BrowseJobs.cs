using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class BrowseJobs : Form
    {

        private readonly Jobapp_dbEntities _db;
        public BrowseJobs()
        {
            InitializeComponent();
            //user_name_tb.Text
            _db = new Jobapp_dbEntities();
        }




        private void Search_bt_Click(object sender, EventArgs e)
        {

            Jobapp_dbEntities _db = new Jobapp_dbEntities();
           // var job_title = _db.Vacancy_details.


        }

        private void BrowseJobs_Load(object sender, EventArgs e)
        {
            var vacancy = _db.Vacancy_details.Select(q => new
            {
                vacancyID = q.id,
                Jobtitle = q.Job_title,
                JobRequirements = q.Job_Requirements
       ,
                Joblevel = q.Job_level
       ,
                Employmenttype = q.Employment_type
       ,
                Submitdeadline = q.Submit_deadline,
                Jobcategory = q.Job_category
            }).ToList();

            dgv_vacacies.DataSource = vacancy;
            dgv_vacacies.Columns[0].HeaderText = "ID";
        }
    }
}
