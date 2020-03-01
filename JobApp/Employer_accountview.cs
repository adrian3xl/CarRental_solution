using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Employer_accountview : Form
    {
        //ivate readonly Jobapp_dbEntities _db;
        public Employer_accountview()
        {

            //b = new Jobapp_dbEntities();

            InitializeComponent();

        }

        private void Employer_accountview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobapp_dbDataSet.Employer_details' table. You can move, or remove it, as needed.
            this.employer_detailsTableAdapter.Fill(this.jobapp_dbDataSet.Employer_details);

/*
            var company_name = company_name_tb.Text;
            var company_background = compan_bk_tb.Text;
            var company_location = compa_loca_tb.Text;
            var company_contact_number = comp_num_tb.Text;
            var workforce = w_force_tb;
            var company_email = comp_email_tb.Text;
            var industry_type = indust_type_tb.Text;
            Show();

   */


        }
    }
}
