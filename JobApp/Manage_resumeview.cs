using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Manage_resumeview : Form
    {
        private readonly Jobapp_dbEntities _db;
        private int _jsId;
        public Manage_resumeview(int jsID)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            _jsId = jsID;
        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            var add_Edit_Jobseeker_Resume = new Add_Edit_Jobseeker_resume(_jsId)
            {
                MdiParent = this.MdiParent
            };
            add_Edit_Jobseeker_Resume.Show();
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = (int)dgv_resumeview.SelectedRows[0].Cells["ID"].Value;
                var resume = _db.Resume_details.FirstOrDefault(q => q.id == ID);

                Add_Edit_Jobseeker_resume add_Edit_Jobseeker_Resume = new Add_Edit_Jobseeker_resume(resume)
                {
                    MdiParent = this.MdiParent
                };
                add_Edit_Jobseeker_Resume.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                //throw;
            }
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = (int)dgv_resumeview.SelectedRows[0].Cells["ID"].Value;
                var resume = _db.Resume_details.FirstOrDefault(q => q.id == ID);

                _db.Resume_details.Remove(resume);
                _db.SaveChanges();
                MessageBox.Show("Delete was successful");

                dgv_resumeview.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("error");
                // throw;
            }
        }

        private void Manage_resumeview_Load(object sender, EventArgs e)
        {
            try
            {
                var Resume_details = _db.Resume_details.Select(q => new
                {
                     q.id,
                    q.Education_level,
                    q.Qualifications,
                    q.PriorWork_Experiences,
                    q.Hobbies,
                    q.Contact_number,
                    q.Email


                }).ToList();


                dgv_resumeview.DataSource = Resume_details;

                dgv_resumeview.Columns["Education_level"].HeaderText = "Education Leve";
                dgv_resumeview.Columns["Qualifications"].HeaderText = "Qualifications";
                dgv_resumeview.Columns["PriorWork_Experiences"].HeaderText = "PriorWork Experiences";
                dgv_resumeview.Columns["Hobbies"].HeaderText = "Hobbies";
                dgv_resumeview.Columns["Contact_number"].HeaderText = "Contact Number";
                dgv_resumeview.Columns["Email"].HeaderText = "Email Address";
                dgv_resumeview.Columns["ID"].Visible = false;

            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }


        }
        public void PopulateGrid()
        {
            var Resume_details = _db.Resume_details.Select(q => new
            {
                q.id,
                q.Education_level,
                q.Qualifications,
                q.PriorWork_Experiences,
                q.Hobbies,
                q.Contact_number,
                q.Email


            }).ToList();


            dgv_resumeview.DataSource = Resume_details;

            dgv_resumeview.Columns["Education_level"].HeaderText = "Education Leve";
            dgv_resumeview.Columns["Qualifications"].HeaderText = "Qualifications";
            dgv_resumeview.Columns["PriorWork_Experiences"].HeaderText = "PriorWork Experiences";
            dgv_resumeview.Columns["Hobbies"].HeaderText = "Hobbies";
            dgv_resumeview.Columns["Contact_number"].HeaderText = "Contact Number";
            dgv_resumeview.Columns["Email"].HeaderText = "Email Address";
            dgv_resumeview.Columns["ID"].Visible = false;
        }
        private void refresh_bt_Click(object sender, EventArgs e)
        {

            PopulateGrid();
        }
    }
}
