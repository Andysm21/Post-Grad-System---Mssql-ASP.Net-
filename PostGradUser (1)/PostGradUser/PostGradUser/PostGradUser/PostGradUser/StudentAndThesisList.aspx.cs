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
    public partial class StudentAndThesisList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
           
                int SupId = Int16.Parse(Session["UserId"].ToString());

                SqlCommand ViewSupStudentsYears = new SqlCommand("ViewSupStudentsYears", conn);
                ViewSupStudentsYears.CommandType = CommandType.StoredProcedure;

                ViewSupStudentsYears.Parameters.Add(new SqlParameter("@supervisorID", SupId));
                conn.Open();

                SqlCommand GetTable = new SqlCommand("ViewSupStudentsYears", conn);
                GetTable.Parameters.AddWithValue("@supervisorID", Int16.Parse(Session["UserId"].ToString()));
                GetTable.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = GetTable.ExecuteReader(CommandBehavior.CloseConnection);
            if (!rdr.HasRows)
            {
                Label label = new Label();
                label.Text = "You don't have any students";
                SUPTHE.Controls.Add(label);
            }
            /*while (rdr.Read())
            {
                String Student_Names = rdr.GetString(rdr.GetOrdinal("firstName")) + " " + rdr.GetString(rdr.GetOrdinal("lastName"));
                int Years = rdr.GetInt32(rdr.GetOrdinal("years"));
                Label name = new Label();
                name.Text = "Student Name  :  " + Student_Names + "<br />";
                Label years = new Label();
                years.Text = "Years :   " + Years + "<br />";
                Label Seperator = new Label();
                Seperator.Text = "------------------------------------------------" + "<br />";
                Info.Controls.Add(Seperator);

                Info.Controls.Add(name);
                Info.Controls.Add(years);

                Info.Controls.Add(Seperator);

            }*/
            conn.Close();
            conn.Open();

            SqlDataReader dr;
            using (ViewSupStudentsYears)
            {
                dr = ViewSupStudentsYears.ExecuteReader(CommandBehavior.CloseConnection);
                if (!dr.HasRows)
                {
                    Response.Write("No Students exist");
                }
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }

                conn.Close();

               // ViewSupStudentsYears.ExecuteNonQuery();
                conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Supervisorpage.aspx");
        }
    }
}