using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Employer_accountview : Form
    {
        private readonly Jobapp_dbEntities _db;
       private int Id;
        public Employer_accountview(int ID)
        {

            _db = new Jobapp_dbEntities();
            Id = ID;
            InitializeComponent();
            Populate();
        }

        private void Employer_accountview_Load(object sender, EventArgs e)
        {


          /*  var company_name = company_name_tb.Text;
            var company_background = compan_bk_tb.Text;
            var company_location = compa_loca_tb.Text;
            var company_contact_number = comp_num_tb.Text;
            var workforce = w_force_tb;
            var company_email = comp_email_tb.Text;
            var industry_type = indust_type_tb.Text;*/

            

        }

        private void mainWindow_MenuItem_Click(object sender, EventArgs e)
        {

        }

       private void Show_vacancies(object sender, EventArgs e)
        {

            var vacancy = new Display_Vacancy(Id);
            vacancy.MdiParent = this.MdiParent;
            vacancy.Show();

        }

       public void Populate()
        {
            var user = _db.Employer_details.FirstOrDefault(q => q.id == Id);

            CompName.Text = user.Company_name;
            ContactNumber.Text = user.Campany_contact_number;
            CompEmail.Text = user.Company_Email;
            compLoc.Text = user.Company_locatiion;
            IndType.Text = user.Industry_type;
            WorkNum.Text = user.Workforce_number.ToString();
            CompBack.Text = user.Company_background;
        }

        private void CompName_Click(object sender, EventArgs e)
        {

        }

      
    }
}
