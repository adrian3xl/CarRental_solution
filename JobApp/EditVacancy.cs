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

        public EditVacancy(Vacancy_details change_vacancy)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            Populate(change_vacancy);
        }

        
        
        public void Populate(Vacancy_details change_vacancy)
        {
            // MessageBox.Show($"{vacan_id}");
            // var change_vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == vacan_id);
            lb_id.Text = change_vacancy.id.ToString();
            JobTitle.Text = change_vacancy.Job_title;
            JobDesc.Text = change_vacancy.Job_Discription;
            JobReq.Text = change_vacancy.Job_Requirements;
            JobLevel.Text = change_vacancy.Job_level;
            EmpType.Text = change_vacancy.Employment_type;
            Deadline.Text = change_vacancy.Submit_deadline.ToString();
            JobCat.Text = change_vacancy.Job_category;


        }

        private void SaveChangesVacancy(object sender, EventArgs e)
        {
            var Id = int.Parse(lb_id.Text);
            var vac = _db.Vacancy_details.FirstOrDefault(q => q.id == Id);

             vac.Job_title  = JobTitle.Text;
             vac.Job_Discription = JobDesc.Text;
             vac.Job_Requirements = JobReq.Text;
             vac.Job_level = JobLevel.Text;
             vac.Employment_type = EmpType.Text;
            vac.Submit_deadline=Deadline.Value;
            vac.Job_category = JobCat.Text;

            _db.SaveChanges();

           }
    }
}
