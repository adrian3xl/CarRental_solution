using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class BrowseJobs : Form
    {

        private readonly Jobapp_dbEntities _db;

        public bool AutoGenerateColumns { get; private set; }

        public BrowseJobs()
        {
            InitializeComponent();
            //user_name_tb.Text
            _db = new Jobapp_dbEntities();
            
        }




        private void Search_bt_Click(object sender, EventArgs e)
        {
            //dgv_vacacies.AutoGenerateColumns = false;
            Jobapp_dbEntities _db = new Jobapp_dbEntities();
            var vacancy = _db.Vacancy_details.Where(q => q.Job_title.Contains(textox_search.Text.Trim()) || q.Job_category == textox_search.Text).ToList();
            dgv_vacacies.DataSource = vacancy;

        }

        private void BrowseJobs_Load(object sender, EventArgs e)
        {
            
            var vacancy = _db.Vacancy_details.Select(q => new
            {
                //vacancyID = q.id,
                Jobtitle = q.Job_title,
                JobRequirements = q.Job_Requirements
       ,
                JobDiscription=q.Job_Discription,
                Joblevel = q.Job_level
       ,
                Employmenttype = q.Employment_type
       ,
                Submitdeadline = q.Submit_deadline,
                Jobcategory = q.Job_category
            }).ToList();

            dgv_vacacies.DataSource = vacancy;
           // dgv_vacacies.Columns[0].HeaderText = "ID";
            dgv_vacacies.Columns[0].HeaderText = "Job Title";
            dgv_vacacies.Columns[1].HeaderText = "Job Discription";
            dgv_vacacies.Columns[2].HeaderText = "Job Requirements";
            dgv_vacacies.Columns[3].HeaderText = "Job Level";
            dgv_vacacies.Columns[4].HeaderText = "Employment Type";
            dgv_vacacies.Columns[5].HeaderText = "Submit deadline";
            dgv_vacacies.Columns[6].HeaderText = "Job Category";

        }
    }
}
