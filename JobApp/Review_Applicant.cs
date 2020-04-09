using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Review_Applicant : Form
    {

        private readonly Jobapp_dbEntities _db;
        private int Id;

        public Review_Applicant()
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
                                Job_SeekerID = q.Jobseeker_id

                            }).ToList();

                            Applicant_view.DataSource = application;
                            Applicant_view.Columns["Resume_details"].HeaderText = "Resume Details";
                            // gv_appstatus_list.Columns["Resume_details"].HeaderText = "Resume Details";
                            Applicant_view.Columns["Job_title"].HeaderText = "Job Title";
                            Applicant_view.Columns["Application_status"].HeaderText = "Application Status";
                            Applicant_view.Columns["ID"].Visible = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"error: {err}");
                            // throw;
                        }

                    }

                



        
    }
}
