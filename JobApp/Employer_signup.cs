using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Employer_signup : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Employer_signup()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        private void Create_emp_bt_Click(object sender, EventArgs e)
        {
            try
            {
                var company_name = compan_name_tb.Text;
                var company_background = companinfo_tb.Text;
                var company_location = compan_loca_tb.Text;
                var company_contact_number = company_contact_tb.Text;
                int workforce = int.Parse(work_force_tb.Text);
                var company_email = company_email_tb.Text;
                var industry_type = industry_type_tb.Text;
                var password = password_tb.Text;

                if (string.IsNullOrWhiteSpace(company_name) || string.IsNullOrWhiteSpace(company_email) || string.IsNullOrWhiteSpace(company_background) || string.IsNullOrWhiteSpace(company_location) || string.IsNullOrWhiteSpace(company_contact_number) || string.IsNullOrWhiteSpace(industry_type))
                {
                    // IsValid = false;
                    MessageBox.Show("Error, required fields were not populated");

                }
                if (workforce == 0)
                {
                    MessageBox.Show("Error, required fields were not populated");
                }
                else
                {
                    var Employer_details = new Employer_details
                    {
                        Company_name = company_name,
                        Company_background = company_background,
                        Company_locatiion = company_location,
                        Campany_contact_number = company_contact_number,
                        Workforce_number = workforce,
                        Company_Email = company_email,
                        Industry_type = industry_type,
                        Password = password
                    };

                    _db.Employer_details.Add(Employer_details);
                    _db.SaveChanges();

                    MessageBox.Show("Registration was successful");
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
