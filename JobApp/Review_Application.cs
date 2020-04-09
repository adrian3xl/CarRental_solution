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
    public partial class Review_Application : Form
    {
        private readonly Jobapp_dbEntities _db;
        public Review_Application()
        {
            _db = new Jobapp_dbEntities();
            InitializeComponent();
        }

        public Review_Application(Job_Applications_details Review)
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();
            Populatefields(Review);

        }

        private void Populatefields(Job_Applications_details Review)
        {
            lb_id.Text = Review.id.ToString();
            Status_tb.Text = Review.Application_status;
           
        }




        private void Submit_bt_Click(object sender, EventArgs e)
        {

            try
            {
                var id = int.Parse(lb_id.Text);
                var Job_Applications_details = _db.Job_Applications_details.FirstOrDefault(q => q.id == id);
               
                Job_Applications_details.Application_status = Status_tb.Text;
                _db.SaveChanges();

                MessageBox.Show("Resume was successfully Edited");

                Close();
            }
            catch (Exception)
            {


                MessageBox.Show("error");
            }





        }
    }
}
