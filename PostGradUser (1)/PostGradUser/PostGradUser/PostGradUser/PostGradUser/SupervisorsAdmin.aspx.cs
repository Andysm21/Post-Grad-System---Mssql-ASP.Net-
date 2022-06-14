using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradUser
{
    public partial class Supervisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
          
            SqlDataReader dr;
            conn.Open();
                using (SqlCommand AdminListSup = new SqlCommand("AdminListSup", conn))
                {
                    dr = AdminListSup.ExecuteReader(CommandBehavior.CloseConnection);
                if (!dr.HasRows)
                {
                    Response.Write("No supervisors exist");
                } 
                GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            conn.Close();
          
        }
    }
}