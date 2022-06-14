using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS3
{
    public partial class NONGUCIAN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewProfile(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand student = new SqlCommand("viewMyProfile", conn);
            student.CommandType = CommandType.StoredProcedure;
            student.Parameters.Add(new SqlParameter("@studentId", Int16.Parse(Session["UserId"].ToString())));

            conn.Open();
            SqlDataReader rdr = student.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();
        }

        protected void ViewCourses(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand student = new SqlCommand("ViewCourse", conn);
            student.CommandType = CommandType.StoredProcedure;
            student.Parameters.Add(new SqlParameter("@studentID", Int16.Parse(Session["UserId"].ToString())));

            conn.Open();
            SqlDataReader rdr = student.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }
        protected void ListTheses(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand student = new SqlCommand("listMythesesNonGucian", conn);
            student.CommandType = CommandType.StoredProcedure;
            student.Parameters.Add(new SqlParameter("@sid", Int16.Parse(Session["UserId"].ToString())));

            conn.Open();
            SqlDataReader rdr = student.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }

        protected void PROGPAGE(object sender, EventArgs e)
        {
            Response.Redirect("ProgressReport.aspx");

        }

        protected void PUBGPAGE(object sender, EventArgs e)
        {
            Response.Redirect("publication.aspx");

        }
        protected void AddPhone(object sender, EventArgs e)
        {
            Response.Redirect("StudentPhone.aspx");
        }


    }
}
