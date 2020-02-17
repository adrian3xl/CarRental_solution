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
    public partial class Add_Edit_Cars : Form
    {
        private readonly CarRental_DBEntities _carRental_DBEntities;
        public Add_Edit_Cars()
        {
            _carRental_DBEntities = new CarRental_DBEntities();
            InitializeComponent();
        }

        private void Save_change_btn_Click(object sender, EventArgs e)
        {

            string make = tbox_make.Text;
            string model = tbox_model.Text;
           // int year = tbox_year;
           // string vin = tbox_vin.Text;
            var LicensePlateNumber = tbox_license;





            if (string.IsNullOrEmpty(tbox_make.Text) || string.IsNullOrWhiteSpace
             (tbox_model.Text))

            {
                MessageBox.Show("Please ensure that you " + "provide a make and a model");

            } else
            {
                Type_of_car car = new Type_of_car
                {

                    Make = make,
                    Model = model,
                    // Year = year,
                    // VIN = vin,
                  //LicensePlateNumber = LicensePlateNumber




                };
                

                


            }

        }
    }
}
