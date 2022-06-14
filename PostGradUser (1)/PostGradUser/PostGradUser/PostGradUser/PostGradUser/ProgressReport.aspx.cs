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
using System.Windows;


namespace MS3
{
    public partial class ProgressReport : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ADDPROG(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlConnection conn = sqlConnection;

            try
            {
                if (TextBox2.Text.ToString() == "" | TextBox4.Text.ToString() == "")
                {
                    string text = "Please fill missing inputs";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("ProgressReport.aspx");

                }
               
         
                else
                {
                    int thesisID = Int16.Parse(TextBox4.Text);
                    DateTime date = Calendar2.SelectedDate;
                    int progNo = Int16.Parse(TextBox2.Text);
                    SqlCommand addP = new SqlCommand("AddProgressReport", conn);
                    addP.CommandType = CommandType.StoredProcedure;
                    addP.Parameters.Add(new SqlParameter("@thesisSerialNo", SqlDbType.Int)).Value = thesisID;
                    addP.Parameters.Add(new SqlParameter("@progressReportDate", SqlDbType.DateTime)).Value = date;
                    addP.Parameters.Add(new SqlParameter("@studentID", SqlDbType.Int)).Value = Session["UserId"];
                    addP.Parameters.Add(new SqlParameter("@progressReportNo", SqlDbType.Int)).Value = progNo;

                    SqlParameter success = addP.Parameters.Add("@success", SqlDbType.Bit);
                    success.Direction = System.Data.ParameterDirection.Output;

                    conn.Open();
                    addP.ExecuteNonQuery();
                    conn.Close();

                    if (success.Value.ToString() == "True")
                    {
                        string text  = "Successful Entry";
                        MessageBox.Show(text);
                    }

                    else
                    {
                        string text = "Invalid Thesis ID or progress report number exists ";
                        MessageBox.Show(text);
                    }
                }
               
            }
            catch (SqlTypeException e1)
            {
                Label label = new Label();
                label.Text = "Please choose a date";
                form2.Controls.Add(label);
            }
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please Enter a number');", true);
                Response.Redirect("ProgressReport.aspx");
            }
            // string text = "Please Enter a number";
            // System.Windows.MessageBox.Show(text);

        }

        protected void FILLPROG(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlConnection conn = sqlConnection;
            string text;
            try
            {

                if (TextBox6.Text.ToString() == "" | TextBox1.Text.ToString() == "" | TextBox3.Text.ToString() == "" | TextBox5.Text.ToString() == "")
                {
                    text = "Please fill missing inputs";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("ProgressReport.aspx");

                }
                

                else
                {
                    int thesisID = Int16.Parse(TextBox6.Text);
                    int state = Int16.Parse(TextBox3.Text);
                    int progNo = Int16.Parse(TextBox1.Text);
                    String desc = TextBox5.Text;
                    SqlCommand addP = new SqlCommand("FillProgressReport", conn);
                    addP.CommandType = CommandType.StoredProcedure;
                    addP.Parameters.Add(new SqlParameter("@studentID", SqlDbType.Int)).Value = Session["UserId"];
                    addP.Parameters.Add(new SqlParameter("@thesisSerialNo", SqlDbType.Int)).Value = thesisID;
                    addP.Parameters.Add(new SqlParameter("@state", SqlDbType.Int)).Value = state;
                    addP.Parameters.Add(new SqlParameter("@progressReportNo", SqlDbType.Int)).Value = progNo;
                    addP.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar)).Value = desc;

                    SqlParameter success = addP.Parameters.Add("@success", SqlDbType.Bit);
                    success.Direction = System.Data.ParameterDirection.Output;



                    conn.Open();
                    addP.ExecuteNonQuery();
                    conn.Close();

                    if (success.Value.ToString() == "True")
                    {
                        text = "Successful Entry";
                        MessageBox.Show(text);
                        Response.Redirect("ProgressReport.aspx");
                    }

                    else
                    {
                        text = "Wrong Thesis ID or progress report not yours";
                        MessageBox.Show(text);
                        Response.Redirect("ProgressReport.aspx");
                    }
                }
                

                

            }
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please Enter a number');", true);
                Response.Redirect("ProgressReport.aspx");
            }

        }

        protected void Back(object sender, EventArgs e)
        {
            String type = (String)Session["Type"];
            if (type == "Gucian")
            {
                Response.Redirect("Gucianpage.aspx");

            }
            if (type == "NonGucian")
            {
                Response.Redirect("NonGucianpage.aspx");
            }
        }
    }
}