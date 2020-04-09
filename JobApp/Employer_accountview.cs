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

            /*Popup pictureBox1 = new Popup();

              pictureBox1.Show();
              */
            
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

     
        private void CompBack_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Reminder_icon.Show(953, 2);
        }

        private void ManageApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicant_status Review_Applicant = new Applicant_status();

            Review_Applicant.ShowDialog();

        }
    }
}
