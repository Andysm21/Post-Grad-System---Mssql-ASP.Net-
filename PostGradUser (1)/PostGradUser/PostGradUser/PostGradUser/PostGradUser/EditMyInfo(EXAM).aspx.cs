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
    public partial class EditMyInfo_EXAM_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (TextBox1.Text.Length < 40 && TextBox2.Text.Length < 30)
            {
                String name = TextBox1.Text.ToString();
                String fieldOfWork = TextBox2.Text.ToString();
                if (TextBox2.Text.ToString() == "" | TextBox1.Text.ToString() == "")
                {
                    string text = "Please Provide correct Data or go Back if you don't want to Edit your Info";
                    System.Windows.MessageBox.Show(text);
                }
                else
                {
                    SqlCommand editMyProfileExaminer = new SqlCommand("editMyProfileExaminer", conn);
                    editMyProfileExaminer.CommandType = CommandType.StoredProcedure;
                    editMyProfileExaminer.Parameters.Add(new SqlParameter("@examinerID", Int32.Parse(Session["UserId"].ToString())));

                    editMyProfileExaminer.Parameters.Add(new SqlParameter("@name", name));
                    editMyProfileExaminer.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOfWork));

                    conn.Open();

                    editMyProfileExaminer.ExecuteNonQuery();
                    conn.Close();
                    string text = "Info edited successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Examinerpage.aspx");
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "Your input is too long";
                form1.Controls.Add(label);
            }
        }
    }
}