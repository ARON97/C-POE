using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string constr = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\PatientDetails.mdf;Integrated Security=True";
            //Establishing a connection
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("BookAppointment"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", nametxtb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", surnametxtb.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNo", phoneNotxtb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Date", Date.Text.Trim());
                        cmd.Connection = con;
                        con.Open();
                        ID = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
                string message = string.Empty;
                switch (ID)
                {
                    case -1:
                        message = "Surname already exists";
                        break;
                    case -2:
                        message = "Phone number already exists";
                        break;
                    default:
                        message = "Appointment Booked Succesfully";
                        break;
                }
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('"+ message + "');", true);
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Date.Text = Calendar1.SelectedDate.ToString();
        }
    }
}