using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Applicant_status : Form
    {

        private readonly Jobapp_dbEntities _db;
        private int Id;

        public Applicant_status()
        {
            _db = new Jobapp_dbEntities();
            // Id = ID;
            InitializeComponent();
        }

        private void Review_Applicant_Load(object sender, EventArgs e)
        {

            try
            {
                var application = _db.Job_Applications_details.Select(q => new
                {
                    ID = q.id,
                    q.Application_status,
                    Resume_details = q.Resume_details.Jobseeker_details.First_name + "" + q.Resume_details.Jobseeker_details.Last_name,
                    q.Vacancy_details.Job_title,
                    q.Resume_details.Qualifications,
                    q.Resume_details.PriorWork_Experiences,
                    q.Resume_details.Education_level,
                    q.Resume_details.Contact_number,
                    q.Resume_details.Email
                   // Job_SeekerID = q.Jobseeker_id

                }).ToList();

                Applicant_view.DataSource = application;
                Applicant_view.Columns["Application_status"].HeaderText = "Application Status";
                Applicant_view.Columns["Resume_details"].HeaderText = "Resume Details";
                // gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                Applicant_view.Columns["Job_title"].HeaderText = "Job Title";

                Applicant_view.Columns["ID"].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show($"error: {err}");
                // throw;
            }

        }


        private void Quary_bt_Click(object sender, EventArgs e)
        {

            try
            {
                var ID = (int)Applicant_view.SelectedRows[0].Cells["ID"].Value;
                var Review = _db.Job_Applications_details.FirstOrDefault(q => q.id == ID);

                var Review_Application = new Review_Application(Review)
                {
                    MdiParent = this.MdiParent
                };
                Review_Application.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("error");
                //throw;
            }

        }

        public void PopulateGrid()
        {

            try
            {
                var application = _db.Job_Applications_details.Select(q => new
                {
                    ID = q.id,
                    q.Application_status,
                    Resume_details = q.Resume_details.Jobseeker_details.First_name + "" + q.Resume_details.Jobseeker_details.Last_name,
                    q.Vacancy_details.Job_title,
                    q.Resume_details.Qualifications,
                    q.Resume_details.PriorWork_Experiences,
                    q.Resume_details.Education_level,
                    q.Resume_details.Contact_number,
                    q.Resume_details.Email
                    // Job_SeekerID = q.Jobseeker_id

                }).ToList();

                Applicant_view.DataSource = application;
                Applicant_view.Columns["Application_status"].HeaderText = "Application Status";
                Applicant_view.Columns["Qualifications"].HeaderText = "Qualifications";
                Applicant_view.Columns["PriorWork_Experiences"].HeaderText = "PriorWork Experiences";
                Applicant_view.Columns["Email"].HeaderText = "Email";
                Applicant_view.Columns["Resume_details"].HeaderText = "Resume Details";
                // gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                Applicant_view.Columns["Job_title"].HeaderText = "Job Title";

                Applicant_view.Columns["ID"].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show($"error: {err}");
                // throw;
            }

        }






        private void button1_Click(object sender, EventArgs e)
        {


            PopulateGrid();
        }
    }
}
