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
    public partial class SearchForThesis_EXAM_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String Keyword = TextBox1.Text;

                if (Keyword == "")
                {
                    string text = "Please Provide a set of proper keywords";
                    System.Windows.MessageBox.Show(text);
                }
                else
                {

                    SqlCommand SearchThesisExaminer = new SqlCommand("SearchThesisExaminer", conn);
                    SearchThesisExaminer.CommandType = CommandType.StoredProcedure;

                    SearchThesisExaminer.Parameters.Add(new SqlParameter("@title", Keyword));
                    conn.Open();

                    SqlCommand GetTable = new SqlCommand("SearchThesisExaminer", conn);
                    GetTable.Parameters.AddWithValue("@title", Keyword);
                    GetTable.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr;

                SqlDataReader rdr = GetTable.ExecuteReader(CommandBehavior.CloseConnection);
                if (!rdr.HasRows)
                {
                    Label label = new Label();
                    label.Text = "No thesis found with this keyword, please change your keyword and try again";
                    form1.Controls.Add(label);
                }
                else
                {

                    while (rdr.Read())
                    {
                        /*int SerNo = rdr.GetInt32(rdr.GetOrdinal("serialNumber"));
                        String field = rdr.GetString(rdr.GetOrdinal("field"));
                        String type = rdr.GetString(rdr.GetOrdinal("type"));
                        String Title = rdr.GetString(rdr.GetOrdinal("title"));
                        DateTime startdate = rdr.GetDateTime(rdr.GetOrdinal("startDate"));
                        DateTime enddate = rdr.GetDateTime(rdr.GetOrdinal("endDate"));
                        DateTime defdate = rdr.GetDateTime(rdr.GetOrdinal("defenseDate"));
                        int years = rdr.GetInt32(rdr.GetOrdinal("years"));
                        decimal grade = rdr.GetDecimal(rdr.GetOrdinal("grade"));
                        int PaymentID = rdr.GetInt32(rdr.GetOrdinal("payment_id"));
                        int No_ext = rdr.GetInt32(rdr.GetOrdinal("noOfExtensions"));

                        Label SerL = new Label();
                        SerL.Text = "Serial Number:  " + SerNo + "<br />";
                        Label fieldl = new Label();
                        fieldl.Text = "Field :  " + field + "<br />";
                        Label Titlel = new Label();
                        Titlel.Text = "Title:  " + Title + "<br />";
                        Label typel = new Label();
                        typel.Text = "Type:  " + type + "<br />";
                        Label StartDatel = new Label();
                        StartDatel.Text = "Start Date:  " + startdate + "<br />";
                        Label endDateL = new Label();
                        endDateL.Text = "End Date:  " + enddate + "<br />";
                        Label DefDatel = new Label();
                        DefDatel.Text = "Defense Date:  " + defdate + "<br />";
                        Label yearsl = new Label();
                        yearsl.Text = "Years:  " + years + "<br />";
                        Label Gradel = new Label();
                        Gradel.Text = "Grade:  " + grade + "<br />";
                        Label paymentL = new Label();
                        paymentL.Text = "Payment ID:  " + PaymentID + "<br />";
                        Label ExtL = new Label();
                        ExtL.Text = "No of Extensions:  " + No_ext + "<br />";

                        Label Seperator = new Label();
                        Seperator.Text = "------------------------------------------------" + "<br />";
                        INFO.Controls.Add(Seperator);

                        INFO.Controls.Add(SerL);
                        INFO.Controls.Add(fieldl);
                        INFO.Controls.Add(typel);
                        INFO.Controls.Add(Titlel);
                        INFO.Controls.Add(StartDatel);
                        INFO.Controls.Add(endDateL);
                        INFO.Controls.Add(DefDatel);
                        INFO.Controls.Add(yearsl);
                        INFO.Controls.Add(Gradel);
                        INFO.Controls.Add(paymentL);
                        INFO.Controls.Add(ExtL);
                        INFO.Controls.Add(Seperator);*/

                    }
                }


                    conn.Close();
                    conn.Open();
                using (SearchThesisExaminer)
                {
                    dr = SearchThesisExaminer.ExecuteReader(CommandBehavior.CloseConnection);
                    if (!dr.HasRows)
                    {
                        Response.Write("No Data exist");
                    }
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
                //SearchThesisExaminer.ExecuteNonQuery();
                    conn.Close();
              
                }
               
        
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Examinerpage.aspx");
        }
    }
}
