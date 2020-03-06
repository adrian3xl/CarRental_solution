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
    public partial class Jobseeker_addresume : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Jobseeker_addresume()
        {
            InitializeComponent();
            _db= new Jobapp_dbEntities();
       
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            var Job_Seeker_Accountview = new Job_Seeker_Accountview();
            Job_Seeker_Accountview.Show();
        }
    }
}
