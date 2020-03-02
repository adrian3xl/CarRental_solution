using System;
using System.Linq;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Jobseeker_vacancy_view : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Jobseeker_vacancy_view()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        private void Jobseeker_vacancy_view_Load(object sender, EventArgs e)
        {
            var vacancy_view = _db.Vacancy_details.ToList();
            DV_vacancy.DataSource = vacancy_view;

        }
    }
}
