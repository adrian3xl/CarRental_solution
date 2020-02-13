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
    public partial class Vehicle_Listing : Form
    {

        private readonly CarRental_DBEntities _db;
        public Vehicle_Listing()
        {
            InitializeComponent();
            _db = new CarRental_DBEntities();
        }

        private void Vehicle_Listing_Load(object sender, EventArgs e)
        {
            var car = _db.Type_of_car.ToList();
            dataGrid_forcars.DataSource=car;
            dataGrid_forcars.Columns[0].HeaderText = "ID";
            dataGrid_forcars.Columns[1].HeaderText = "NAME";

        }
    }
}
