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
    public partial class Manage_resumeview : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Manage_resumeview()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {

        }

        private void edit_bt_Click(object sender, EventArgs e)
        {

        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {

        }

        private void Manage_resumeview_Load(object sender, EventArgs e)
        {
            try
            {
                var Resume_details = _db.Resume_details.Select(q => new
                {
                    ID = q.id,
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
    }
}
