using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Employer_accountview : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Employer_accountview()
        {

            _db = new Jobapp_dbEntities();

            InitializeComponent();

           
        }

        private void Employer_accountview_Load(object sender, EventArgs e)
        {
            try
            {
                var company_name = company_name_tb.Text;
                var company_background = compan_bk_tb.Text;
                var company_location = compa_loca_tb.Text;
                var company_contact_number = comp_num_tb.Text;
                int workforce = int.Parse(w_force_tb.Text);
                var company_email = comp_email_tb.Text;
                var industry_type = indust_type_tb.Text;



                var Employer_details = new Employer_details
                {

                    Company_name = company_name,
               
                };
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }

            
            
        }
    }
}
