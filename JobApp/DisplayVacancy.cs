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
    public partial class Display_Vacancy : Form
    {
        private readonly Jobapp_dbEntities _db;

        /*  public Display_Vacancy()
          {
              InitializeComponent();

              _db = new Jobapp_dbEntities();
          }*/

        private int Emp_id;

        public Display_Vacancy(int id)
        {
            InitializeComponent();

            Emp_id = id;
            _db = new Jobapp_dbEntities();

        }


        private void Display_vacancy_Load(object sender, EventArgs e)
        {
          var details = _db.Vacancy_details.Where(q=>q.Employers_id == Emp_id).ToList();
            vacancy.DataSource = details;
           // DisplayId();
        }

        public void DisplayId()
        {
            throw new NotImplementedException();
        }

        private void CreateNew(object sender, EventArgs e)
        {
            var NewVacancy = new Add_Vacancy(Emp_id);
            NewVacancy.MdiParent = this.MdiParent;
            NewVacancy.Show();
        }

      //  vacancy

        private void Edit_Vacancy(object sender, EventArgs e)
        {

            var ID = (int)vacancy.SelectedRows[0].Cells["id"].Value;
            var change_vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == ID);

            var EditVacancy = new EditVacancy(change_vacancy)
            {
                MdiParent = this.MdiParent
            };
            EditVacancy.ShowDialog();


            //  var change_vacancy = (int) vacancy.SelectedRows[0].Cells["id"].Value;

            //  var edit = new EditVacancy(change_vacancy);
            //  edit.Show();

        }

        private void prev_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_bt_Click(object sender, EventArgs e)
        {
            var ID = (int)vacancy.SelectedRows[0].Cells["id"].Value;
            var change_vacancy = _db.Vacancy_details.FirstOrDefault(q => q.id == ID);

            _db.Vacancy_details.Remove(change_vacancy);
            _db.SaveChanges();
            MessageBox.Show("Delete was successful");


        }


        public void PopulateGrid()
        {
            var details = _db.Vacancy_details.Where(q => q.Employers_id == Emp_id).ToList();
            vacancy.DataSource = details;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Please exit window and enter back in to see updates");
            PopulateGrid();
        }
    }
}
