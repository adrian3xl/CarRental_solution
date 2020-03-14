using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Add_Edit_Jobseeker_resume : Form
    {
        private bool iseditmode;

        private readonly Jobapp_dbEntities _db;
        public Add_Edit_Jobseeker_resume()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            lable_title.Text = "Add New Resume";
            iseditmode = false;
        }

        public Add_Edit_Jobseeker_resume(Resume_details resume_toedit)
        {
            InitializeComponent();
            lable_title.Text = "Edit New Resume";
            iseditmode = true;
            Populatefields(resume_toedit);
            
        }

        private void Populatefields(Resume_details resume_toedit)
        {
            edu_tb.Text = resume_toedit.Education_level;
            cont_tb.Text = resume_toedit.Contact_number;
            hobby_tb.Text = resume_toedit.Hobbies;
            email_tb.Text = resume_toedit.Email;
            exper_tb.Text = resume_toedit.PriorWork_Experiences;
            qualifica_tb.Text = resume_toedit.Qualifications;
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {
            if (iseditmode== true)
            {

                var Education_level = edu_tb.Text;
                var Contact_number = cont_tb.Text;
                var Hobbies = hobby_tb.Text;
                var Email = email_tb.Text;
                var PriorWork_Experiences = exper_tb.Text;
                var Qualifications = qualifica_tb.Text;

                // var vacancy_id = v
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
            else 

            try
            {
               


              //  var Jobseeker_details_id = new Jobseeker_details.id;
            }
            catch (Exception)
            {

                // throw;
            }


        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
