﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void OldPasswordtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPasswordtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conS = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True";
                string query = "UPDATE Login_tbl SET Password='" + NewPasswordtxtBox.Text + "' where UserName= 'UserName' and Password='" + OldPasswordtxtBox.Text + "'";
                SqlConnection conDB = new SqlConnection(conS);
                SqlCommand cmdDB = new SqlCommand(query, conDB);
                //Inserting values into the Login database

                    if (NewPasswordtxtBox.Text == RePasswordtxtBox.Text)
                    {
                        try
                        {
                            cmdDB.Connection = conDB;
                            conDB.Open();
                            cmdDB.CommandText = query;
                            cmdDB.ExecuteNonQuery();
                            MessageBox.Show("Changed successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu MenuF = new Menu();
                            MenuF.Show();
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sorry for the inconvenience. An unexpected error occurred." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password does not match." , "Passoword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            
            //The block of code that handles an exception when the application cannot connect to the database
            catch (SqlException ex)
            {
                MessageBox.Show("Sorry for the inconvenience. An unexpected error occur." + ex.Message, "Unable to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RePasswordtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkpwd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
