using System.Windows.Forms;

namespace JobApp
{
    public partial class BrowseJobs : Form
    {
        private readonly Jobapp_dbEntities _db;
        public BrowseJobs()
        {
            InitializeComponent();
            //user_name_tb.Text
            _db = new Jobapp_dbEntities();
        }

        private void search_bt_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (System.Exception)
            {
                MessageBox.Show("try again");
                //   throw;
            }
        }
    }
}
