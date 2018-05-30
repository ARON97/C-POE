using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_System
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capture_DetailsDataSet.Patienttbl' table. You can move, or remove it, as needed.
            this.patienttblTableAdapter.Fill(this.capture_DetailsDataSet.Patienttbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menuF = new Menu();
            menuF.Show();
            this.Hide();
        }

        private void watermark_Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByContactToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patienttblTableAdapter.FillByContact(this.capture_DetailsDataSet.Patienttbl, surnameToolStripTextBox.Text, contactToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience. An unexpected error occur." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Formatting the DataGrid
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            //Formatting the selection style of the datagrid
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

        }

     
    }
}
