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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
        }


        private void watermark_Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password ChangeF = new Change_Password();
            ChangeF.Show();
            this.Hide();
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {



            
        }

        private void savePbtn_Click(object sender, EventArgs e)
        {
           //Initializing the stream writer method 
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Aron\Desktop\ARON\C#\Patients.txt", true))
            {
                //fORMATING THE TEXT FILE USING A FORMAT METHOD
                string c1 = nametxtB.Text;
                string c2 = surnametxtB.Text;
                string c3 = cnumtxtB.Text;
                sw.WriteLine(string.Format("{0}#{1}#{2}", new object[] { c1, c2, c3 }));
                MessageBox.Show("Details have been saved");

                //Clearing all the values after button is clicked
                nametxtB.Text = "";
                surnametxtB.Text = "";
                cnumtxtB.Text = "";

            }

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            //Displays an OpenFileDialog so that the user can select a file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open text file";
            openFileDialog1.Filter = "TXT Files|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
            }
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            Search searchF = new Search();
            searchF.Show();
        }

        private void saveRbtn_Click(object sender, EventArgs e)
        {
            //Displays a SaveFileDialog so that the user can save the file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT Files|*.txt";
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.ShowDialog();

            //Checks if the file name is empty
            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
            }
        }

       
    }
}
