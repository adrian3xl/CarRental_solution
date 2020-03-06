using System;
using System.Windows.Forms;

namespace JobApp
{
    public partial class Job_Seeker_Accountview : Form
    {
        private readonly Jobapp_dbEntities _db;

        public Job_Seeker_Accountview()
        {
        }

        public Job_Seeker_Accountview(string user_name)
        {

            InitializeComponent();
            _db = new Jobapp_dbEntities();
            user_name_tb.Text = user_name;
        }

        private void BrowseJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BrowseJobs = new BrowseJobs();
            BrowseJobs.Show();
        }

     //   private void addResumeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
         // var Education_level;
          //  var Qualifications;
           // var experience;
         //  var Hobbies;
         //   var Contact;
          // var Email;
      //  }

       
       
    }
}
