using System;
using System.Linq;
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

                string company_name = Company_name_tb.Text.Trim();
                string password = company_pass_tb.Text;
                bool IsValid = true;
                var Employer_details = _db.Employer_details.FirstOrDefault(q => q.Company_name == company_name && q.Password == password);

                if (Employer_details == null)
                {
                    IsValid = false;
                    MessageBox.Show("Invalid user name and password entered");



                }

                if (IsValid)
                {

                    MessageBox.Show("Welcome ");

                    Employer_accountview Employer_accountview = new Employer_accountview();

                    Employer_accountview.Show();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please re-enter username and password");
                //throw;
            }
        }
    }
}
