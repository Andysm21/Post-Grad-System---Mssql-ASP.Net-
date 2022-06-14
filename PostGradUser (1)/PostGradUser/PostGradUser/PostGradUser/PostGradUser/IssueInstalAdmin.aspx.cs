using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradUser
{
    public partial class IssueInstalAdmin : System.Web.UI.Page
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
                if (payID.Text != "" )
                {
                    int paymentID = Int16.Parse(payID.Text);
                    DateTime startDate1 = Calendar1.SelectedDate;
                    SqlCommand AdminIssueInstallPayment = new SqlCommand("AdminIssueInstallPayment", conn);
                    AdminIssueInstallPayment.CommandType = CommandType.StoredProcedure;
                    AdminIssueInstallPayment.Parameters.Add(new SqlParameter("@paymentID", paymentID));
                    AdminIssueInstallPayment.Parameters.Add(new SqlParameter("@InstallStartDate", startDate1));
                    SqlParameter success = AdminIssueInstallPayment.Parameters.Add("@success", SqlDbType.Int);
                    success.Direction = ParameterDirection.Output;
                    conn.Open();
                    AdminIssueInstallPayment.ExecuteNonQuery();
                    if (success.Value.ToString() == "1")
                    {
                        Label count = new Label();
                        count.Text = "Installments were added successfully";
                        form1.Controls.Add(count);
                    }
                    else
                    {
                        Label count = new Label();
                        count.Text = "Invalid input, try again";
                        form1.Controls.Add(count);
                    }
                    conn.Close();
                }

                else
                {
                    Label count = new Label();
                    count.Text = "You have to enter a payment id";
                    form1.Controls.Add(count);
                }
            }
            catch (FormatException e1)
            {
                Label count = new Label();
                count.Text = "The payment ID has to be a number";
                form1.Controls.Add(count);
            }
            catch(SqlException e1)
            {
                Label count = new Label();
                count.Text = "Installments with these date and payment id are already issued";
                form1.Controls.Add(count);
            }
            catch(SqlTypeException e1)
            {
                Label count = new Label();
                count.Text = "Please choose a date";
                form1.Controls.Add(count);
            }
        
    }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}