﻿using System;
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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }


      




        private void searchBtn_Click(object sender, EventArgs e)
        {



            
        }

        private void savePbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conS = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Capture_Details.mdf;Integrated Security=True";
                //Inserting values into the patient database
                string query = "INSERT INTO Patienttbl(Name, Surname, Contact) VALUES (@Name, @Surname, @Contact)";
                using (SqlConnection conDB = new SqlConnection(conS))
                {
                    using (SqlCommand cmdDB = new SqlCommand(query, conDB))
                    {
                        cmdDB.CommandType = CommandType.Text;
                        cmdDB.Parameters.AddWithValue("@Name", nametxtB.Text);
                        cmdDB.Parameters.AddWithValue("@Surname", surnametxtB.Text);
                        cmdDB.Parameters.AddWithValue("@Contact", cnumtxtB.Text);
                        conDB.Open();
                        try
                        {
                            cmdDB.ExecuteNonQuery();
                            MessageBox.Show("Saved successfully.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Couldn't save to the database." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conDB.Close();
                        }

                    }

                }
            }
            //The block of code that handles an exception when the application cannot connect to the database
            catch (SqlException ex)
            {
                MessageBox.Show("Sorry for the inconvenience. An unexpected error occur." + ex.Message, "Unable to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                //Clearing all the values after button is clicked
                nametxtB.Text = "";
                surnametxtB.Text = "";
                cnumtxtB.Text = "";
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            Search searchF = new Search();
            searchF.Show();
        }


        private void menuBtn_Click(object sender, EventArgs e)
        {
 
            Menu menuF = new Menu();
            menuF.Show();
            this.Hide();
        }

       
    }
}
