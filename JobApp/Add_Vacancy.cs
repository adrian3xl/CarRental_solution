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
    public partial class Add_Vacancy : Form
    {
        private int emp_id;
        private readonly Jobapp_dbEntities _db;

        public Add_Vacancy(int id)
        {
            InitializeComponent();
            emp_id = id;
            _db = new Jobapp_dbEntities();
        }

        private void AddNewVacancy(object sender, EventArgs e)
        {
            var title = JobTitle1.Text;
            var JobReq = JobRequirement.Text;
            var Desc = JobDescription.Text;
            var lvl = JobLvl.Text;
            var empType = employType.Text;
            var Deadline = DeadlineDate.Value;
            var Cate = JobCategory.Text;


            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(JobReq) || string.IsNullOrWhiteSpace(Desc) || string.IsNullOrWhiteSpace(lvl) || string.IsNullOrWhiteSpace(empType) || string.IsNullOrWhiteSpace(Cate))
            {
                // IsValid = false;
                MessageBox.Show("Fill out allw fields");

            }
            else
            {
                var vacancy_detal_details = new Vacancy_details
                {
                    Job_title = title,
                    Job_Discription = Desc,
                    Job_Requirements = JobReq,
                    Job_level = lvl,
                    Employment_type = empType,
                    Submit_deadline = Deadline,
                    Job_category = Cate,
                    Employers_id = emp_id
                };

                _db.Vacancy_details.Add(vacancy_detal_details);
                _db.SaveChanges();
                MessageBox.Show("Vacancy have been saved");
            }
        }
    }
}
