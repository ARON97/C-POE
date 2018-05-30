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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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
        //The Animation starts
        bool currentlyAnimating = false;
        //Updating the animation
        bool isAnimating = true;
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (isAnimating)
            {
                //Beginning the animation background
                AnimateImage();
                //Updating the frames
                ImageAnimator.UpdateFrames();
            }
            base.OnPaintBackground(e);
        }
        //Beginning the animation
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(this.BackgroundImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }
        private void OnFrameChanged(Object o, EventArgs e)
        {
            //Redraw frame
            this.Invalidate();
        }

        private void PassWtxtb_TextChanged(object sender, EventArgs e)
        {
            //Set to no text

            //The Password Character is an asterisk
            PassWtxtb.PasswordChar = '*';

            PassWtxtb.MaxLength = 4;
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

        string cs = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True";

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            LoginFrm loginF = new LoginFrm();
            Menu MenuF = new Menu();

            //Progress bar starting
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            //Throwing an exception in the try block when the database is not found
            try
            {
                //Establishing the connection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Login_tbl where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", UserNtxtbx.Text);
                cmd.Parameters.AddWithValue("@password", PassWtxtb.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //if count is 1, the open the menu form
                if (count == 1)
                {
                    MessageBox.Show("LOGIN SUCCESSFULLY", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu menuF = new Menu();
                    menuF.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username or password!!!", "Unsuccesful Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //The block of code that handles an exception when the application cannot connect to the database
            catch (SqlException ex)
            {
                MessageBox.Show("Sorry for the inconvenience. An unexpected error occur.", "Unable to connect to database" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
