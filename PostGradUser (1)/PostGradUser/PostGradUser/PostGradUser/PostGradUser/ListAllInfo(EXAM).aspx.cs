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
    public partial class ListAllInfo_EXAM_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int ExamID = Int16.Parse(Session["UserId"].ToString());

            SqlCommand ListExaminer = new SqlCommand("ListExaminer", conn);
            ListExaminer.CommandType = CommandType.StoredProcedure;

            ListExaminer.Parameters.Add(new SqlParameter("@examinerID", ExamID));
            conn.Open();

            SqlCommand GetTable = new SqlCommand("ListExaminer", conn);
            GetTable.Parameters.AddWithValue("@examinerID", ExamID);
            GetTable.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader rdr = GetTable.ExecuteReader(CommandBehavior.CloseConnection);
            SqlDataReader dr;
            while (rdr.Read())
            {
                /* String Student_Names = rdr.GetString(rdr.GetOrdinal("StudentName"));
                 String SupName = rdr.GetString(rdr.GetOrdinal("SupervisorName"));
                 String Title = rdr.GetString(rdr.GetOrdinal("title"));

                 Label snamel = new Label();
                 snamel.Text = "Student Name:  " + Student_Names + "<br />";
                 Label supnamel = new Label();
                 supnamel.Text = "SuperVisor Name:  " + SupName + "<br />";
                 Label Titlel = new Label();
                 Titlel.Text = "Title:  " + Title + "<br />";
                 Label Seperator = new Label();
                 Seperator.Text = "------------------------------------------------" + "<br />";
                 INFO.Controls.Add(Seperator);

                 INFO.Controls.Add(Titlel);
                 INFO.Controls.Add(snamel);
                 INFO.Controls.Add(supnamel);
                 INFO.Controls.Add(Seperator);*/

                

            }
            conn.Close();
            conn.Open();
            using (ListExaminer)
            {
                dr = ListExaminer.ExecuteReader(CommandBehavior.CloseConnection);
                if (!dr.HasRows)
                {
                    Response.Write("No Data exists");
                }
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
            //ListExaminer.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Examinerpage.aspx");
        }
    }
}