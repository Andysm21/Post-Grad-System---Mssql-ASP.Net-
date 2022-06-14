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
    public partial class IssuePayAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try {
                if (serialN.Text != "" && amount.Text != "" && fundperc.Text != "" && noOFInstal.Text != "")
                {
                    int serialNumber = Int16.Parse(serialN.Text);
                    double amount1 = Double.Parse(amount.Text);
                    double fund = Double.Parse(fundperc.Text);
                    int instal = Int16.Parse(noOFInstal.Text);
                    SqlCommand AdminIssueThesisPayment = new SqlCommand("AdminIssueThesisPayment", conn);
                    AdminIssueThesisPayment.CommandType = CommandType.StoredProcedure;
                    AdminIssueThesisPayment.Parameters.Add(new SqlParameter("@ThesisSerialNo", serialNumber));
                    AdminIssueThesisPayment.Parameters.Add(new SqlParameter("@amount", amount1));
                    AdminIssueThesisPayment.Parameters.Add(new SqlParameter("@noOfInstallments", instal));
                    AdminIssueThesisPayment.Parameters.Add(new SqlParameter("@fundPercentage", fund));
                    SqlParameter success = AdminIssueThesisPayment.Parameters.Add("@success", SqlDbType.Bit);
                    success.Direction = System.Data.ParameterDirection.Output;
                    conn.Open();
                    AdminIssueThesisPayment.ExecuteNonQuery();
                    if (success.Value.ToString() == "True")
                    {
                        Label count = new Label();
                        count.Text = "Payment was added successfully";
                        form1.Controls.Add(count);
                    }
                    else
                    {
                        Label count = new Label();
                        count.Text = "Invalid input try again";
                        form1.Controls.Add(count);
                    }
                    conn.Close();


                }

                else
                {
                 
                    Label count = new Label();
                    count.Text = "You have to enter all inputs";
                    form1.Controls.Add(count);
                
                }
            }
            catch (FormatException e1)
            {
                Label count = new Label();
                count.Text = "Please enter valid inputs, all inputs should be numerical";
                form1.Controls.Add(count);
            }
            }
    }
}