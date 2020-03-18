using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Submit_jobapplication : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Submit_jobapplication()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        public Submit_jobapplication(BrowseJobs browseJobs, Vacancy_details vacancy)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();

        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {

            var resume = new Resume_details
            {
               Education_level = edu_tb.Text,
                Contact_number = cont_tb.Text,
                Hobbies = hobby_tb.Text,
                Email = email_tb.Text,
                PriorWork_Experiences = exper_tb.Text,
                Qualifications = qualifica_tb.Text


            };

            // _db.SaveChanges();

            var Id = int.Parse(lb_id.Text);
            var vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == Id);
           
         //   _db.SaveChanges();

            _db.Job_Applications_details.Add(this, vacancy, resume);
            _db.SaveChanges();
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
