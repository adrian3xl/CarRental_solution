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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                string customer_firstname = txtbox_firstname.Text;
                string customer_lastname = txtbox_firstname.Text;
                double cost = Convert.ToDouble(txtbox_cost.Text);
                var date_Rented = daterented.Value;
                var date_return = datereturned.Value;
                var owner_name = txtbox_owner.Text;
                var id_num = txtbox_id_number.Text;
                var typeofcar = drpbox_cartype.Text; /*var can be used instead of int,double,string etc*/
                var isValid = true;

                if (String.IsNullOrEmpty(customer_firstname)
                        || String.IsNullOrEmpty(customer_lastname)
                        || daterented == null
                        || String.IsNullOrEmpty(drpbox_cartype.Text))
                       
                {
                    isValid = true;

                }
                       

                if (txtbox_firstname == null ||
                    txtbox_lastname == null ||
                    drpbox_cartype == null)
                {

                    isValid = false;
                    MessageBox.Show("incomplete");

                }

                if (daterented.Value > datereturned.Value)
                {
                    isValid = false;
                    MessageBox.Show("Invalid date entered for a date");
                }



                if (isValid)
                {
                    MessageBox.Show($"customer name is : {customer_firstname} {customer_lastname}\n\r" +

                    $"Owner of car:{txtbox_owner}\n\r" +
                   $"cost: {txtbox_cost}\n\r" +
                   $"date rented to owner: {daterented}\n\r" +
                   $"date returned to owner: {datereturned}\n\r" +
                   $"ID number is:{txtbox_id_number}\n\r" +
                   $"Type of car : {drpbox_cartype}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
