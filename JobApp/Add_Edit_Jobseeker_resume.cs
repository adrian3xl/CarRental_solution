using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Add_Edit_Jobseeker_resume : Form
    {
        private readonly bool iseditmode;

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
            _db = new Jobapp_dbEntities();
            lable_title.Text = "Edit Resume";
            iseditmode = true;
            Populatefields(resume_toedit);

        }

        private void Populatefields(Resume_details resume_toedit)
        {
            lb_id.Text = resume_toedit.id.ToString();
            edu_tb.Text = resume_toedit.Education_level;
            cont_tb.Text = resume_toedit.Contact_number;
            hobby_tb.Text = resume_toedit.Hobbies;
            email_tb.Text = resume_toedit.Email;
            exper_tb.Text = resume_toedit.PriorWork_Experiences;
            qualifica_tb.Text = resume_toedit.Qualifications;
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {
            if (iseditmode == true)
            {
                try
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

                    MessageBox.Show("Resume was successfully Edited");

                    Close();
                }
                catch (Exception)
                {


                    MessageBox.Show("error");
                }
            }
            else

                try
                {
                    var add_resume = new Resume_details
                    {
                        Education_level = edu_tb.Text,
                        Contact_number = cont_tb.Text,
                        Hobbies = hobby_tb.Text,
                        Email = email_tb.Text,
                        PriorWork_Experiences = exper_tb.Text,
                        Qualifications = qualifica_tb.Text


                    };

                    _db.Resume_details.Add(add_resume);
                    _db.SaveChanges();

                    MessageBox.Show("Resume was successfully added");

                    Close();


                }
                catch (Exception)
                {

                    MessageBox.Show("error");
                    
                    // throw;
                }


        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
