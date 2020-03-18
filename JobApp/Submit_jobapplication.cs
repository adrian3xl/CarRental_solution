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

            var id = int.Parse(lb_id.Text);
            var resume = _db.Resume_details.FirstOrDefault(q => q.id == id);
            resume.Education_level = edu_tb.Text;
            resume.Contact_number = cont_tb.Text;
            resume.Hobbies = hobby_tb.Text;
            resume.Email = email_tb.Text;
            resume.PriorWork_Experiences = exper_tb.Text;
            resume.Qualifications = qualifica_tb.Text;

            _db.SaveChanges();


            var vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == id);

        }
    }
}
