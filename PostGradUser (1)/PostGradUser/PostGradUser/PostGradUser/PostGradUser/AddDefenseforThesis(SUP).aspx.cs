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
    public partial class AddDefenseforThesis_SUP_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (TextBox2.Text.ToString() == "" | TextBox3.Text.ToString() == "" | TextBox1.Text.ToString() == "")
            {
                string text = "Please Provide correct Data";
                System.Windows.MessageBox.Show(text);
            }
            else
            {
                try
                {
                    int ThesisSerialNo = Int32.Parse(TextBox1.Text.ToString());
                    String Location = TextBox3.Text.ToString();
                    DateTime date = Convert.ToDateTime(TextBox2.Text.ToString());

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
                        if (Session["Type"].ToString() == "Gucian")
                        {
                            SqlCommand AddDefenseGucian = new SqlCommand("AddDefenseGucian", conn);
                            AddDefenseGucian.CommandType = CommandType.StoredProcedure;

                            AddDefenseGucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                            AddDefenseGucian.Parameters.Add(new SqlParameter("@DefenseDate", date));
                            AddDefenseGucian.Parameters.Add(new SqlParameter("@DefenseLocation", Location));
                            conn.Open();

                            AddDefenseGucian.ExecuteNonQuery();
                            conn.Close();
                            string text = "Defense added to thesis successfully";
                            System.Windows.MessageBox.Show(text);
                            Response.Redirect("Supervisorpage.aspx");
                        }
                        else
                        {
                            SqlCommand AddDefenseNonGucian = new SqlCommand("AddDefenseNonGucian", conn);
                            AddDefenseNonGucian.CommandType = CommandType.StoredProcedure;

                            AddDefenseNonGucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                            AddDefenseNonGucian.Parameters.Add(new SqlParameter("@DefenseDate", date));
                            AddDefenseNonGucian.Parameters.Add(new SqlParameter("@DefenseLocation", Location));

                            SqlCommand LookFordefense = new SqlCommand("LookFordefense", conn);
                            LookFordefense.CommandType = CommandType.StoredProcedure;

                            LookFordefense.Parameters.Add(new SqlParameter("@thesisSerialNo", ThesisSerialNo));
                            LookFordefense.Parameters.Add(new SqlParameter("@defdate", date));
                            SqlParameter success2= LookFordefense.Parameters.Add(new SqlParameter("@Present", SqlDbType.Bit));
                            success2.Direction = System.Data.ParameterDirection.Output;

                            conn.Open();
                            LookFordefense.ExecuteNonQuery();
                            if (success2.Value.ToString() == "False")
                            {

                                AddDefenseNonGucian.ExecuteNonQuery();
                                conn.Close();
                                string text = "Defense added to thesis successfully";
                                System.Windows.MessageBox.Show(text);
                                Response.Redirect("Supervisorpage.aspx");
                            }
                            else
                            {
                                string text = "Defense already added before";
                                MessageBox.Show(text);
                            }
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
}