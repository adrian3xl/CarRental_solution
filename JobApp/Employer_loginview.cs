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
    public partial class Employer_loginview : Form
    {
       private readonly Jobapp_dbEntities _db;
        public Employer_loginview()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }



        private void Enter_emp_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var company_name =Company_name_tb.Text;
                var password = company_pass_tb.Text;
                var IsValid = true;

                if (string.IsNullOrWhiteSpace(company_name) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Required field is empty");
                }

                else
                {
                    var Employer_details = _db.Employer_details.FirstOrDefault(q => q.Company_name == company_name && q.Password == password);




                    if (IsValid)
                    {
                        MessageBox.Show("Welcome ");

                        Employer_accountview Employer_accountview = new Employer_accountview();

                        Employer_accountview.Show();
                        //job_Seeker_Accountview.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
