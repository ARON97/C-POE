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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool searchFound = false;
            string line;
            StreamReader file = new StreamReader(@"C:\Users\Aron\Desktop\ARON\C#\Patients.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] f = line.Split(':');
                if (line.Contains(watermark_Textbox1.Text))
                {
                    searchFound = true;
                    listBox1.Items.Add(line);
                }
                else if(searchFound == false)
                {
                    MessageBox.Show("INVALID SEARCH", "PROGRAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            file.Close();
            watermark_Textbox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
