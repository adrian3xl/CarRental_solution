using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Add_Edit_Jobseeker_resume : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Add_Edit_Jobseeker_resume()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            lable_title.Text = "Add New Resume";
        }

        public Add_Edit_Jobseeker_resume(Resume_details resume_toedit)
        {
            InitializeComponent();
            lable_title.Text = "Edit New Resume";
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


              //  var Jobseeker_details_id = new Jobseeker_details.id;
            }
            catch (Exception)
            {

                // throw;
            }


        }
    }
}
