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
    public partial class CancelThesis_SUP_ : System.Web.UI.Page
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
                int ThesisSerialNo = Int32.Parse(TextBox1.Text.ToString());

                SqlCommand LookForThesis = new SqlCommand("LookForThesis", conn);
                LookForThesis.CommandType = CommandType.StoredProcedure;
                LookForThesis.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                SqlParameter success = LookForThesis.Parameters.Add("@Present", SqlDbType.Bit);
                success.Direction = System.Data.ParameterDirection.Output;


                conn.Open();

                LookForThesis.ExecuteNonQuery();
                conn.Close();
                if (success.Value.ToString() == "True")
                {

                    SqlCommand CancelThesis = new SqlCommand("CancelThesis", conn);
                    CancelThesis.CommandType = CommandType.StoredProcedure;

                    CancelThesis.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                    SqlParameter successB = CancelThesis.Parameters.Add("@output", SqlDbType.Bit);
                    successB.Direction = System.Data.ParameterDirection.Output;


                    conn.Open();

                    CancelThesis.ExecuteNonQuery();
                    conn.Close();
                    if (successB.Value.ToString() == "False")
                    {
                        Label1.Text = "Couldnot cancel thesis";
                    }
                    else
                    {
                        string text = "Thesis cancelled successfully";
                        System.Windows.MessageBox.Show(text);
                        Response.Redirect("Supervisorpage.aspx");
                    }
                }
                else
                {
                    string text = "Invalid Thesis Serial Number";
                    MessageBox.Show(text);
                }
            }
            catch (FormatException e1)
            {
                Label label = new Label();
                label.Text = "The thesis serial number has to be an integer";
                form1.Controls.Add(label);
            }
        }
    }
}