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
    public partial class Thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataReader dr;
            SqlCommand AdminViewOnGoingTheses = new SqlCommand("AdminViewOnGoingTheses", conn);
            AdminViewOnGoingTheses.CommandType = CommandType.StoredProcedure;
            SqlParameter thesesCount = AdminViewOnGoingTheses.Parameters.Add("@thesesCount", SqlDbType.Int);
            thesesCount.Direction = ParameterDirection.Output;
            conn.Open();
            AdminViewOnGoingTheses.ExecuteNonQuery();
            using (SqlCommand AdminViewAllTheses = new SqlCommand("AdminViewAllTheses", conn))
            {
                dr = AdminViewAllTheses.ExecuteReader(CommandBehavior.CloseConnection);
                if (!dr.HasRows)
                {
                    Response.Write("No thesies exist");
                }
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
            Label count = new Label();
            count.Text = thesesCount.Value.ToString();
            form1.Controls.Add(count);
            conn.Close();
        }
    }
}