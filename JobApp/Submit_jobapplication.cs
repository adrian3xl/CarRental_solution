using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Submit_jobapplication : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Submit_jobapplication()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
        }

        public Submit_jobapplication(BrowseJobs browseJobs, Vacancy_details vacancy)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();

        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
