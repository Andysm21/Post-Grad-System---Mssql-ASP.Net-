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
    public partial class AddExaminerDef_SUP_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                if (TextBox2.Text.ToString() == "" | TextBox3.Text.ToString() == "" | TextBox1.Text.ToString() == "" | TextBox4.Text.ToString() == "" | TextBox5.Text.ToString() == "")
                {
                    string text = "Please Provide correct Data";
                    System.Windows.MessageBox.Show(text);
                }
                else
                {
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
                            DateTime date = Convert.ToDateTime(TextBox2.Text.ToString());
                            String ExaminerName = TextBox3.Text.ToString();
                            String Password = TextBox4.Text.ToString();
                            int nationalBit = 0;
                            if (DropDownList1.SelectedItem.Value == "Yes")
                            {
                                nationalBit = 1;
                            }
                            String fieldOfWork = TextBox5.Text.ToString();
                            SqlCommand AddExaminer = new SqlCommand("AddExaminer", conn);
                            AddExaminer.CommandType = CommandType.StoredProcedure;

                            AddExaminer.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                            AddExaminer.Parameters.Add(new SqlParameter("@DefenseDate", date));
                            AddExaminer.Parameters.Add(new SqlParameter("@ExaminerName", ExaminerName));
                            AddExaminer.Parameters.Add(new SqlParameter("@Password", Password));
                            AddExaminer.Parameters.Add(new SqlParameter("@National", nationalBit));
                            AddExaminer.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOfWork));

                            conn.Open();

                            AddExaminer.ExecuteNonQuery();
                            conn.Close();
                            string text = "Examiner added to defense successfully";
                            System.Windows.MessageBox.Show(text);
                            Response.Redirect("Supervisorpage.aspx");
                        }
                        else
                        {
                            string text = "Invalid Thesis Serial Number";
                            System.Windows.MessageBox.Show(text);
                        }
                    }
                    catch (FormatException e1)
                    {
                        Label count = new Label();
                        count.Text = "The thesis serial number has to be a number and the date has to be in mm/dd/yyyy format";
                        form1.Controls.Add(count);
                    }
                    catch(SqlException e1)
                    {
                        Label count = new Label();
                        count.Text = "Either the defense date or the thesis serial number is wrong, please check your inputs and try again";
                        form1.Controls.Add(count);
                    }



                }
            }
        }
    }
}