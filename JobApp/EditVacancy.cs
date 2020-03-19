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
    public partial class EditVacancy : Form
    {
        private int vacan_id;
        private readonly Jobapp_dbEntities _db;

        public EditVacancy()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        public EditVacancy(int id)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            vacan_id = id;
            Populate();
        }
        
        public void Populate()
        {
            // MessageBox.Show($"{vacan_id}");
            var vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == vacan_id);

            JobTitle.Text = vacancy.Job_title;
            JobDesc.Text = vacancy.Job_Discription;
            JobReq.Text = vacancy.Job_Requirements;
            JobLevel.Text = vacancy.Job_level;
            EmpType.Text = vacancy.Employment_type;
            //Deadline.Value = vacancy.Submit_deadline;
            JobCat.Text = vacancy.Job_category;


        }

        private void SaveChangesVacancy(object sender, EventArgs e)
        {
            var vac = _db.Vacancy_details.FirstOrDefault(q => q.id == vacan_id);

             vac.Job_title  = JobTitle.Text;
             vac.Job_Discription = JobDesc.Text;
             vac.Job_Requirements = JobReq.Text;
             vac.Job_level = JobLevel.Text;
             vac.Employment_type = EmpType.Text;
            //Deadline.Value = vacancy.Submit_deadline;
            vac.Job_category = JobCat.Text;

            _db.SaveChanges();

           }
    }
}
