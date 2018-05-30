using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
        }

        protected void GridResult()
        {
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Intializing the winform
            Appointment a = new Appointment();
            //Show the winform
            a.Show();
            //Hiding current form
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void View_Appointments_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'capture_DetailsDataSet.Patienttbl' table. You can move, or remove it, as needed.
            this.patienttblTableAdapter.Fill(this.capture_DetailsDataSet.Patienttbl);

        }



        private void fillByTToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
