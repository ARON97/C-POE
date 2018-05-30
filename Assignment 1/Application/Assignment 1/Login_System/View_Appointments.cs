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
            //Initializing the SqlConnection
            var con = new SqlConnection(@"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Captur.mdf;Integrated Security=True");


            var dTable = new DataTable();
            //Using DataAdapter to fill the datagrid
            var dAdapt = new SqlDataAdapter("SELECT * FROM Appointmentbl WHERE  = Surname AND Contact", con);
            //Using DataAdapter to fill the datagrid
            dAdapt.Fill(dTable);
            dataGridView1.DataSource = dTable;

            //Allowing the user to add/edit/delete using commandbuilder
            SqlCommandBuilder scb = SqlCommandBuilder();


            //Formatting the DataGrid
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            //Formatting the selection style of the datagrid
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
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
    }
}
