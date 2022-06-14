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
    public partial class Studentregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (StudPass.Text != "" && StudEmail.Text != "")
            {
                if (StudFname.Text.Length <= 20 && StudLname.Text.Length <= 20 && StudPass.Text.Length <= 30 && StudFaculty.Text.Length <= 30 && StudEmail.Text.Length <= 50 && StudAddress.Text.Length <= 50)
                {
                    string F_name = StudFname.Text;
                    string L_name = StudLname.Text;
                    string pass = StudPass.Text;
                    string faculty = StudFaculty.Text;
                    int Gucian = 1;
                    if (GUCAINBIT.SelectedItem.Value == "No")
                    {
                        Gucian = 0;
                    }


                    string Email = StudEmail.Text;
                    string Address = StudAddress.Text;

                    SqlCommand RegProc = new SqlCommand("studentRegister", conn);
                    RegProc.CommandType = CommandType.StoredProcedure;

                    RegProc.Parameters.Add(new SqlParameter("@first_name", F_name));
                    RegProc.Parameters.Add(new SqlParameter("@last_name", L_name));
                    RegProc.Parameters.Add(new SqlParameter("@password", pass));
                    RegProc.Parameters.Add(new SqlParameter("@faculty", faculty));
                    RegProc.Parameters.Add(new SqlParameter("@Gucian", Gucian));
                    RegProc.Parameters.Add(new SqlParameter("@email", Email));
                    RegProc.Parameters.Add(new SqlParameter("@address", Address));

                    conn.Open();
                    RegProc.ExecuteNonQuery();
                    string text = "You have registered successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Login.aspx");
                    conn.Close();
                }
                else
                {
                    Label label = new Label();
                    label.Text = "Your inputs are out of bounds, make sure your first and last name are less than 20 characters, your password and faculty name are less than 30 characters and your email and address are less than 50 characters";
                    StudentRegister.Controls.Add(label);
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "Please make sure to provide an email and Password";
                StudentRegister.Controls.Add(label);

            }
        }
    }

}