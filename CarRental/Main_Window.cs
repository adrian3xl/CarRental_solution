using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.MdiParent = this;
            Form1.Show();
        }

        private void vehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Listing vehicle_Listing = new Vehicle_Listing();
            vehicle_Listing.MdiParent = this;
            vehicle_Listing.Show();
        }
    }
}
