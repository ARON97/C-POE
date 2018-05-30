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
            var path = @"C:\Users\Aron\Desktop\ARON\C#\K.txt";
            var origanalLines = File.ReadAllLines(path);

            var updatedLines = new List<string>();
            foreach (var line in origanalLines)
            {
                string[] infos = line.Split(':');
                if (infos[0] == userNametxtBox.Text)
                {
                    //Update value
                    infos[1] = (int.Parse(infos[1]) + 1).ToString(NewPasswordtxtBox.Text);
                }
                updatedLines.Add(string.Join(",", infos));
            }

            File.WriteAllLines(path, updatedLines);
            if (NewPasswordtxtBox.Text.Trim() == RePasswordtxtBox.Text.Trim())
            {

                MessageBox.Show("LOGIN SUCCESSFULLY", "PROGRAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("INVALID USERNAME OR PASSWORD", "PROGRAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
