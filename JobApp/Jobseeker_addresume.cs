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
        private bool issubmit_mode;
        private readonly Jobapp_dbEntities _db;
        public Jobseeker_addresume()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
             issubmit_mode=false;
    }
        public Jobseeker_addresume(Job_Applications_details addresume)
        {
            InitializeComponent();
            populateFields(addresume);

        }

        private void populateFields(Job_Applications_details addresume)
        {
            edu_tb.Text = addresume.Resume_details.Education_level;
            cont_tb.Text = addresume.Resume_details.Education_level;
            hobby_tb.Text = addresume.Resume_details.Hobbies;
            email_tb.Text = addresume.Resume_details.Email;
            exper_tb.Text = addresume.Resume_details.PriorWork_Experiences;
            qualifica_tb.Text = addresume.Resume_details.Qualifications;
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            var Job_Seeker_Accountview = new Job_Seeker_Accountview();
            Job_Seeker_Accountview.Close();
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {
            if (issubmit_mode)
            {

            }
            else
            {
                Close();
            }
        }
    }
}
