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
    public partial class ViewStudentPub_SUP_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            if (TextBox1.Text.ToString() == "")
            {
                string text = "Please Provide a Student ID";
                System.Windows.MessageBox.Show(text);
            }
            else
            {
                try
                {
                    int StudentID = Int32.Parse(TextBox1.Text.ToString());

                    SqlCommand ViewAStudentPublications = new SqlCommand("ViewAStudentPublications", conn);
                    ViewAStudentPublications.CommandType = CommandType.StoredProcedure;

                    ViewAStudentPublications.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                    conn.Open();

                    SqlCommand GetTable = new SqlCommand("ViewAStudentPublications", conn);
                    GetTable.Parameters.AddWithValue("@StudentID", StudentID);
                    GetTable.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader rdr = GetTable.ExecuteReader(CommandBehavior.CloseConnection);
                    if (!rdr.HasRows)
                    {
                        Label label = new Label();
                        label.Text = "student doesn't have any publications";
                        form1.Controls.Add(label);
                    }
                    SqlDataReader dr;
                    while (rdr.Read())
                    {
                        if (rdr.GetString(rdr.GetOrdinal("title"))== null ) {
                            Label NoData = new Label();
                            NoData.Text =  "No Data Found";
                            StudentPub.Controls.Add(NoData);
                        }
                        else {
                            /*String title = rdr.GetString(rdr.GetOrdinal("title"));
                            int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                            DateTime date = rdr.GetDateTime(rdr.GetOrdinal("dateOfPublication"));
                            String place = rdr.GetString(rdr.GetOrdinal("place"));
                            int accepted = Convert.ToInt32(rdr.GetBoolean(rdr.GetOrdinal("accepted")));
                            String host = rdr.GetString(rdr.GetOrdinal("host"));


                            Label Seperator = new Label();
                            Seperator.Text = "------------------------------------------------" + "<br />";
                            Label titlel = new Label();
                            titlel.Text = "Title: " + title + "     ," + "<br />";
                            Label idl = new Label();
                            idl.Text = "ID: " + id.ToString() + "     ," + "<br />";
                            Label datel = new Label();
                            datel.Text = "Date: " + date.ToString() + "     ," + "<br />";
                            Label placel = new Label();
                            placel.Text = "Place: " + place + "     ," + "<br />";
                            Label acceptedl = new Label();
                            acceptedl.Text = "Status: " + accepted.ToString() + "     ," + "<br />";
                            Label hostl = new Label();
                            hostl.Text = "Host: " + host + "     ," + "<br />";
                            Seperator.Text = "------------------------------------------------" + "<br />";

                            StudentPub.Controls.Add(Seperator);
                            StudentPub.Controls.Add(titlel);
                            StudentPub.Controls.Add(idl);
                            StudentPub.Controls.Add(datel);
                            StudentPub.Controls.Add(placel);
                            StudentPub.Controls.Add(acceptedl);
                            StudentPub.Controls.Add(hostl);
                            StudentPub.Controls.Add(Seperator);*/
                            //conn.Open();
  

                        }

                    }
                    conn.Close();
                  conn.Open();
                    using (ViewAStudentPublications)
                    {
                        dr = ViewAStudentPublications.ExecuteReader(CommandBehavior.CloseConnection);
                        if (!dr.HasRows)
                        {
                            Response.Write("No Data");
                        }
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                    }
                    conn.Close();
                    //ViewAStudentPublications.ExecuteNonQuery();
                    //conn.Close();
                }
                catch (FormatException e1)
                {
                    Label count = new Label();
                    count.Text = "The student ID has to be a number";
                    form1.Controls.Add(count);
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Supervisorpage.aspx");
        }
    }
}