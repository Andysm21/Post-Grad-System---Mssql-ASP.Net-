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
    public partial class GUCIANPHONE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                int phone = Int32.Parse(GUCPHONE.Text);
                string id = Session["UserId"].ToString();

                SqlCommand Mob = new SqlCommand("addMobile", conn);
                Mob.CommandType = CommandType.StoredProcedure;

                Mob.Parameters.Add(new SqlParameter("@ID", id));
                Mob.Parameters.Add(new SqlParameter("@mobile_number", phone));


                conn.Open();
                Mob.ExecuteNonQuery();
                conn.Close();

                if (Session["Type"].ToString() == "Gucian")
                {
                    string text = "Phone number added successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Gucianpage.aspx");
                }
                else
                {
                    string text = "Phone number added successfully";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("NonGucianpage.aspx");

                }
            }
            catch (FormatException e1)
            {
                Label label = new Label();
                label.Text = "Please enter a number";
                form1.Controls.Add(label);
            }
            catch (SqlException e1)
            {
                Label label = new Label();
                label.Text = "This number already exists";
                form1.Controls.Add(label);
            }
            
        }

    }
}