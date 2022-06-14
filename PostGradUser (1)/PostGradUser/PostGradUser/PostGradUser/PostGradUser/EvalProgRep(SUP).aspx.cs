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
    public partial class EvalProgRep_SUP_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            if (TextBox2.Text.ToString() == "" | TextBox3.Text.ToString() == "")
            {
                string text = "Please Provide correct Data";
                System.Windows.MessageBox.Show(text);
            }
            else
            {
                try {
                    int ThesisSerialNo = Int32.Parse(TextBox2.Text.ToString());

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
                        int ProgRep = Int32.Parse(TextBox3.Text.ToString());
                        SqlCommand LookForProgress = new SqlCommand("LookForProgress", conn);
                        LookForProgress.CommandType = CommandType.StoredProcedure;
                        LookForProgress.Parameters.Add(new SqlParameter("@progressID", ProgRep));
                        SqlParameter successProg = LookForProgress.Parameters.Add("@Present", SqlDbType.Bit);
                        successProg.Direction = System.Data.ParameterDirection.Output;
                        conn.Open();

                        LookForProgress.ExecuteNonQuery();
                        conn.Close();
                        if (successProg.Value.ToString() == "True")
                        {
                            int SupID = Int32.Parse(Session["UserId"].ToString());
                            int Eval = Int16.Parse(DropDownList1.SelectedItem.Value);

                            SqlCommand EvaluateProgressReport = new SqlCommand("EvaluateProgressReport", conn);
                            EvaluateProgressReport.CommandType = CommandType.StoredProcedure;

                            EvaluateProgressReport.Parameters.Add(new SqlParameter("@supervisorID", SupID));
                            EvaluateProgressReport.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                            EvaluateProgressReport.Parameters.Add(new SqlParameter("@progressReportNo", ProgRep));
                            EvaluateProgressReport.Parameters.Add(new SqlParameter("@evaluation", Eval));


                            conn.Open();

                            EvaluateProgressReport.ExecuteNonQuery();
                            conn.Close();
                            string text = "Progress Report evaluated successfully";
                            System.Windows.MessageBox.Show(text);
                            Response.Redirect("Supervisorpage.aspx");
                        }
                        else
                        {
                            string text = "Invalid Progress Report Number";
                            MessageBox.Show(text);
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
                    label.Text = "The thesis serial number and the progress report number has to be integers";
                    form1.Controls.Add(label);
                }
                }
        }
    }
}