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
    public partial class Examinerregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (ExEmail.Text != "" && ExPass.Text != "")
            {
                if (ExFname.Text.Length <= 20 && ExLname.Text.Length <= 20 && ExPass.Text.Length <= 20 && ExFieldofWork.Text.Length <= 20 && ExEmail.Text.Length <= 50)
                {
                    string F_name = ExFname.Text;
                    string L_name = ExLname.Text;
                    string Email = ExEmail.Text;
                    string pass = ExPass.Text;
                    string FieldOfWork = ExFieldofWork.Text;
                    int Isnational = 0;
                    if (ExIsNational.SelectedItem.Value == "Yes")
                    {
                        Isnational = 1;
                    }
                    SqlCommand RegProc = new SqlCommand("ExaminerRegister", conn);
                    RegProc.CommandType = CommandType.StoredProcedure;

                    RegProc.Parameters.Add(new SqlParameter("@first_name", F_name));
                    RegProc.Parameters.Add(new SqlParameter("@last_name", L_name));
                    RegProc.Parameters.Add(new SqlParameter("@email", Email));
                    RegProc.Parameters.Add(new SqlParameter("@password", pass));
                    RegProc.Parameters.Add(new SqlParameter("@fieldOfWork", FieldOfWork));
                    RegProc.Parameters.Add(new SqlParameter("@isNational", Isnational));

                    conn.Open();
                    RegProc.ExecuteNonQuery();
                    Response.Write("Done");
                    string text = "You have registered successfully";
                    System.Windows.MessageBox.Show(text);
              
                    Response.Redirect("Login.aspx");
                    conn.Close();

                }
                else
                {
                    Label label = new Label();
                    label.Text = "Your inputs are out of bounds, make sure your firs and last name, password and field of work are less than 20 characters and your email is less than 50 characters";
                    ExaminerRegistration.Controls.Add(label);
                }

            }
            else
            {
                Label label = new Label();
                label.Text = "Please make sure to provide an email and Password";
                ExaminerRegistration.Controls.Add(label);

            }
        }
    }
}