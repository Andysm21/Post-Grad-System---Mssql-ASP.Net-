using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MileStone3
{
    public partial class Supervisorregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (SupPass.Text != "" && SupEmail.Text != "")
            {
                if (SupFname.Text.Length <= 20 && SupLname.Text.Length <= 20 && SupPass.Text.Length <= 30 && SupFaculty.Text.Length <= 30 && SupEmail.Text.Length <= 50)
                {
                    string F_name = SupFname.Text;
                    string L_name = SupLname.Text;
                    string pass = SupPass.Text;
                    string faculty = SupFaculty.Text;
                    string Email = SupEmail.Text;

                    SqlCommand RegProc = new SqlCommand("supervisorRegister", conn);
                    RegProc.CommandType = CommandType.StoredProcedure;

                    RegProc.Parameters.Add(new SqlParameter("@first_name", F_name));
                    RegProc.Parameters.Add(new SqlParameter("@last_name", L_name));
                    RegProc.Parameters.Add(new SqlParameter("@password", pass));
                    RegProc.Parameters.Add(new SqlParameter("@faculty", faculty));
                    RegProc.Parameters.Add(new SqlParameter("@email", Email));

                    conn.Open();
                    RegProc.ExecuteNonQuery();
                    conn.Close();
                    string text = "You have registered successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Login.aspx");
                }
            
            else
                {
                    Label label = new Label();
                    label.Text = "Your inputs are out of bounds, make sure your first and last name are less than 20 characters, your password and faculty name are less than 30 characters and your email is less than 50 characters";
                    SupervisorRegister.Controls.Add(label);
                }

            }
            else
            {
                Label label = new Label();
                label.Text = "Please make sure to provide an email and Password";
                SupervisorRegister.Controls.Add(label);

            }
        }

    }
}