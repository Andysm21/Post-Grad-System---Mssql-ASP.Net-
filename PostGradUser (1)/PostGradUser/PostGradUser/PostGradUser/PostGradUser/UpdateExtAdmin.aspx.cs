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
    public partial class UpdateExtAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                int serialText = Int16.Parse(serialN.Text);
                SqlCommand AdminUpdateExtension = new SqlCommand("AdminUpdateExtension", conn);
                AdminUpdateExtension.CommandType = CommandType.StoredProcedure;
                AdminUpdateExtension.Parameters.Add(new SqlParameter("@ThesisSerialNo", serialText));
                SqlParameter success = AdminUpdateExtension.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                AdminUpdateExtension.ExecuteNonQuery();
                if (success.Value.ToString() == "1")
                {
                    Label count = new Label();
                    count.Text = "Thesis " + serialN.Text + " is extended successfully";
                    form1.Controls.Add(count);

                }
                else
                {
                    Label count = new Label();
                    count.Text = "Thesis " + serialN.Text + " doesn't exist please check your inputs and try again";
                    form1.Controls.Add(count);
                }
                conn.Close();
            }
            catch(FormatException e1)
            {
                Label count = new Label();
                count.Text = "Please enter a number";
                form1.Controls.Add(count);
            }
        }
    }
}