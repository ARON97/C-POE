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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //This assigns todays date and time to the text property of the label
            this.datelbl.Text = DateTime.Now.ToLongDateString();
            this.timelbl.Text = DateTime.Now.ToLongTimeString();
        
        }

        private void PassWtxtb_TextChanged(object sender, EventArgs e)
        {
            //Set to no text
            
            //The Password Character is an asterisk
            PassWtxtb.PasswordChar = '*';

            PassWtxtb.MaxLength = 8;
        }

        private void chkpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpwd.Checked)
                PassWtxtb.PasswordChar = '\0';
            else
                PassWtxtb.PasswordChar = '*';
        }

        private void UserNtxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginFrm loginF = new LoginFrm();
            Patient patientF = new Patient();

            //Progress bar starting
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            var updatedLines = new List<string>();
            using (StreamReader reader = new StreamReader(@"C:\Users\Aron\Desktop\ARON\C#\K.txt"))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    int counter = 1;
                    updatedLines.Add(line);
                    //Spliting the username and password using a Split metthod
                    string[] data = line.Split(':');
                    if (data[0] == UserNtxtbx.Text.Trim() && data[1] == PassWtxtb.Text.Trim())
                    {
                        MessageBox.Show("LOGIN SUCCESSFULLY", "PROGRAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        patientF.Show(); 
                        reader.ReadToEnd();
                        counter++;
                        break;
                    }
                    //Else statement for invalid username or password
                    else 
                    {

                            MessageBox.Show("INVALID USERNAME OR PASSWORD", "PROGRAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                            UserNtxtbx.Text = "";
                            PassWtxtb.Text = "";
                            break;
                    } 
                       
                        
                    }
                reader.Close();

                }
                
            }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
