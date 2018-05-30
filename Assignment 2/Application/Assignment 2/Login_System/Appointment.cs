using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_System
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        public static void createTable()
        {
            //Create the table. SQL command to create a table
            string createString = "CREATE TABLE Appointmenttbl (Name VARCHAR(50), Date VARCHAR(50), Start_Time VARCHAR(50))";
            //The sql connection to connect to the database
            SqlConnection con = new SqlConnection("Server=ARON; Integrated Security = SSPI; database= Appointments.mdf");

            SqlCommand create = new SqlCommand(createString, con);

            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }

        public void createDB()
        {
            String str;
        //Creating a server connection
        SqlConnection conDB = new SqlConnection("Server=ARON; Integrated Security = SSPI; database= master");
        
            //Creating the database
        str = "CREATE DATABASE Appointment ON PRIMARY" + "(NAME = Appointment_Data, " + "FILENAME = 'C:\\Appointment.mdf' ," +
        "SIZE = 2MB, FILEGROWTH = 10%)" + "LOG ON (NAME =Appointment_log, " + "FILENAME = 'C:\\AppointmentLog.1df', " + "SIZE = 1MB" +
        "MAXSIZE = 5MB, " + "FILEGROWTH = 10%)";
        //Creating the database command so that the database can be filled
        SqlCommand com = new SqlCommand(str, conDB);
        
            conDB.Open();
            com.ExecuteNonQuery();
        

        
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            string conS = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Capture_Details.mdf;Integrated Security=True";
            //Inserting values into the Appointmenttbl
            string query = "insert into Appointtbl(Name, Date, Start_Time) VALUES (@Name, @Date, @Start_Time)";
            using (SqlConnection conDB = new SqlConnection(conS))
            {
                using (SqlCommand cmdDB = new SqlCommand(query, conDB))
                {
                    cmdDB.CommandType = CommandType.Text;
                    //Storing the values entered into database
                    cmdDB.Parameters.AddWithValue("@Name", nameTxtb.Text);
                    cmdDB.Parameters.AddWithValue("@Date", dateTxtb.Text);
                    cmdDB.Parameters.AddWithValue("@Start_Time", timeTxtb.Text);
                    conDB.Open();
                    cmdDB.ExecuteNonQuery();
                    conDB.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Appointments VA = new View_Appointments();
            VA.Show();
            this.Hide();
        }
    }
}
