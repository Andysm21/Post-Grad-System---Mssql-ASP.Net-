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
namespace MileStone3
{
    public partial class AddGrade_EXAM_ : System.Web.UI.Page
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

                if (TextBox3.Text.ToString() == "" | TextBox1.Text.ToString() == "")
                {
                    string text = "Please Provide correct Data";
                    System.Windows.MessageBox.Show(text);
                }
                else
                {
                    int ThesisSerialNo = Int32.Parse(TextBox1.Text.ToString());
                    DateTime date = Calendar1.SelectedDate;


                    SqlCommand LookForThesis = new SqlCommand("ThesisMatchDefDate", conn);
                    LookForThesis.CommandType = CommandType.StoredProcedure;
                    LookForThesis.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                    LookForThesis.Parameters.Add(new SqlParameter("@DefDate", date));

                    SqlParameter success = LookForThesis.Parameters.Add("@Present", SqlDbType.Bit);
                    success.Direction = System.Data.ParameterDirection.Output;
                    conn.Open();

                    LookForThesis.ExecuteNonQuery();
                    conn.Close();

                    if (success.Value.ToString() == "True")
                    {

                        decimal grade = decimal.Parse(TextBox3.Text.ToString());

                        SqlCommand AddDefenseGrade = new SqlCommand("AddDefenseGrade", conn);
                        AddDefenseGrade.CommandType = CommandType.StoredProcedure;

                        AddDefenseGrade.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                        AddDefenseGrade.Parameters.Add(new SqlParameter("@DefenseDate", date));
                        AddDefenseGrade.Parameters.Add(new SqlParameter("@grade", grade));

                        conn.Open();

                        AddDefenseGrade.ExecuteNonQuery();
                        conn.Close();
                        string text = "Grade added to defense successfully";
                        System.Windows.MessageBox.Show(text);
                        Response.Redirect("Examinerpage.aspx");
                    }
                    else
                    {
                        string text = "Invalid Thesis Serial Number Or Defense Date and Thesis Serial Number do not match";
                        System.Windows.MessageBox.Show(text);
                    }
                }
            }
            catch (SqlTypeException e1)
            {
                Label label = new Label();
                label.Text = "Please choose a date";
                form1.Controls.Add(label);
            }
            catch (FormatException e1)
            {
                Label label = new Label();
                label.Text = "The thesis serial number has to be an integer";
                form1.Controls.Add(label);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}