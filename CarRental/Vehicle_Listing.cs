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
            //var car = _db.Type_of_car.ToList();

            var car = _db.Type_of_car.Select(q => new { ID = q.id,
                q.Make,
                q.Model,
                q.Year,
                q.VIN,
                q.LicensePlateNumber
            }).ToList();



            dataGrid_forcars.DataSource=car;
            dataGrid_forcars.Columns["LicensePlateNumber"].HeaderText = "Plate Number";
            dataGrid_forcars.Columns["ID"].Visible=false;

        }

        private void Bt_add_Click(object sender, EventArgs e)
        {

        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            //int id=(int)dataGrid_forcars.SelectedRows[0].Cells["ID"].Value();
           // var car = _db.Type_of_car.FirstOrDefault(q => q.id);
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
