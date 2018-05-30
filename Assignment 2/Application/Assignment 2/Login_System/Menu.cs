using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCaptureP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient patientF = new Patient();
            patientF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment AF = new Appointment();
            AF.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search searchF = new Search();
            searchF.Show();
        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password ChangeF = new Change_Password();
            ChangeF.Show();
            this.Hide();
        }
    }
}
