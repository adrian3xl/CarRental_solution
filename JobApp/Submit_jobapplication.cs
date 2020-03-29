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

            _db.Resume_details.Add(resume);
            _db.SaveChanges();


            lb_id.Text = resume.id.ToString();

     

            var Id = int.Parse(lb_id.Text);
            var vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == Id);

            var jobapplication = new Job_Applications_details()
            {
                Resume_details = resume,
                Vacancy_details=vacancy

            };


           _db.Job_Applications_details.Add(jobapplication);

          //  _db.Job_Applications_details.AddRange(Resume_details);
            _db.SaveChanges();

            MessageBox.Show("you have sucessfully applied for position");
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
