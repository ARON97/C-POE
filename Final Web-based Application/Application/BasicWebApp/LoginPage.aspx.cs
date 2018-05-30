using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Security;

namespace BasicWebApp
{
    public partial class FirstWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True";
            int ID = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Validate_User"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", usernametxtb);
                    cmd.Parameters.AddWithValue("@Password", passwordtxtb);
                    cmd.Connection = con;
                    con.Open();
                    ID = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                switch (ID)
                {
                    case -1:
                        Login1.FailureText = "Username and/or password is incorrect.";
                        break;
                    default:
                        FormsAuthentication.RedirectFromLoginPage(Login1.usernametxtb.Text);
                        break;
                }
        }

        protected void usernametxtb_TextChanged(object sender, EventArgs e)
        {

        }

        protected void passwordtxtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}