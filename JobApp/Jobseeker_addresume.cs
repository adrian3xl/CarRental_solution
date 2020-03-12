using System;
using System.Windows.Forms;

namespace JobApp
{

    public partial class Jobseeker_addresume : Form
    {
        private bool issubmit_mode;
        private readonly Jobapp_dbEntities _db;
        public Jobseeker_addresume()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();

        }
        public Jobseeker_addresume(Job_Applications_details addresume)
        {
            InitializeComponent();
            populateFields(addresume);

        }

        private void populateFields(Job_Applications_details addresume)
        {
            edu_tb.Text = addresume.Resume_details.Education_level;
            cont_tb.Text = addresume.Resume_details.Contact_number;
            hobby_tb.Text = addresume.Resume_details.Hobbies;
            email_tb.Text = addresume.Resume_details.Email;
            exper_tb.Text = addresume.Resume_details.PriorWork_Experiences;
            qualifica_tb.Text = addresume.Resume_details.Qualifications;
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            var Job_Seeker_Accountview = new Job_Seeker_Accountview();
            Job_Seeker_Accountview.Close();
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {


            try
            {
                var Education_level = edu_tb.Text;
                var Contact_number = cont_tb.Text;
                var Hobbies = hobby_tb.Text;
                var Email = email_tb.Text;
                var PriorWork_Experiences = exper_tb.Text;
                var Qualifications = qualifica_tb.Text;

                var Resume_details = new Resume_details
                {
                    Education_level = Education_level,
                    Contact_number = Contact_number,
                    Hobbies = Hobbies,
                    Email = Email,
                    PriorWork_Experiences = PriorWork_Experiences,
                    Qualifications = Qualifications
                };

                _db.Resume_details.Add(Resume_details);
                _db.SaveChanges();

            }
            catch (Exception)
            {

                // throw;
            }



        }
    }
}
