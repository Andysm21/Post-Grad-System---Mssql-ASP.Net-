using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;


namespace MileStone3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            string mail = UserEmail.Text;
            string pass = Userpassword.Text;

            SqlCommand loginProc = new SqlCommand("userLogin", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@email", mail));
            loginProc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter id = loginProc.Parameters.Add("@id", SqlDbType.Int);
            SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.VarChar, 20);

            id.Direction = System.Data.ParameterDirection.Output;
            type.Direction = System.Data.ParameterDirection.Output;

            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Bit);
            sucess.Direction = System.Data.ParameterDirection.Output;

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();




            if (sucess.Value.ToString() == "True")
            {
                String typeVar = type.Value.ToString();
                int IdVar = Int32.Parse(id.Value.ToString());
                Session["Type"] = typeVar;
                Session["UserId"] = IdVar;
                if (typeVar == "Gucian")
                {
                    string text = "You have logged in successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Gucianpage.aspx");

                }
                if (typeVar == "NonGucian")
                {
                    string text = "You have logged in successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("NonGucianpage.aspx");

                }
                if (typeVar == "Admin")
                {
                    string text = "You have logged in successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Adminpage.aspx");

                }
                if (typeVar == "Examiner")
                {
                    string text = "You have logged in successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Examinerpage.aspx");

                }
                if (typeVar == "Supervisor")
                {
                    string text = "You have logged in successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Supervisorpage.aspx");
                }
            }
            else
            {
                string text = "Wrong Email / Password or User data does not exist so please Register";
                MessageBox.Show(text);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}
