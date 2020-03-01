using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Jobseeker_vacancy_view : Form
    {
        public Jobseeker_vacancy_view()
        {
            InitializeComponent();
        }

        private void Jobseeker_vacancy_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobapp_dbDataSet.Vacancy_details' table. You can move, or remove it, as needed.
            this.vacancy_detailsTableAdapter.Fill(this.jobapp_dbDataSet.Vacancy_details);

        }
    }
}
