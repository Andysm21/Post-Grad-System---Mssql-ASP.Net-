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
    public partial class publication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back(object sender, EventArgs e)
        {
            String type = (String) Session["Type"];
            if (type == "Gucian")
            {
                Response.Redirect("Gucianpage.aspx");

            }
            if (type == "NonGucian")
            {
                Response.Redirect("NonGucianpage.aspx");
            }
        }

            protected void ADDPUB(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlConnection conn = sqlConnection;

            string host = TextBox2.Text;
            DateTime publicaDate = Calendar1.SelectedDate;
            string title = TextBox1.Text;
            string place = TextBox3.Text;
            Boolean accepted = ToBoolean(RadioButtonList1.SelectedValue);
            string text;
            try
            {
                if (TextBox2.Text.ToString() == "" | TextBox1.Text.ToString() == "" | TextBox3.Text.ToString() == "" | RadioButtonList1.SelectedValue == null)
                {
                    text = "Please fill missing inputs";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Publication.aspx");

                }
                else
                {
                    SqlCommand addP = new SqlCommand("addPublication", conn);
                    addP.CommandType = CommandType.StoredProcedure;

                    addP.Parameters.Add(new SqlParameter("@host", SqlDbType.VarChar)).Value = host;
                    addP.Parameters.Add(new SqlParameter("@pubDate", SqlDbType.DateTime)).Value = publicaDate;
                    addP.Parameters.Add(new SqlParameter("@title", SqlDbType.VarChar)).Value = title;
                    addP.Parameters.Add(new SqlParameter("@place", SqlDbType.VarChar)).Value = place;
                    addP.Parameters.Add(new SqlParameter("@accepted", SqlDbType.Bit)).Value = accepted;



                    conn.Open();
                    addP.ExecuteNonQuery();
                    conn.Close();

                    text = "Successful Entry";
                    System.Windows.MessageBox.Show(text);
                    Response.Redirect("Publication.aspx");
                }
            }
            catch (SqlTypeException e1)
            {
                Label label = new Label();
                label.Text = "Please choose a date";
                form1.Controls.Add(label);
            }

        }

        private bool ToBoolean(string selectedValue)
        {
            if (selectedValue == "Yes")
                return true;
            else
                return false;
        }


        protected void LINKPUB(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlConnection conn = sqlConnection;
           
            try
            {

                if (TextBox4.Text.ToString() == "" | TextBox5.Text.ToString() == "")
                {
                    string text = "Please fill missing inputs";
                    System.Windows.MessageBox.Show(text);
                   Response.Redirect("Publication.aspx");

                }
               
                else
                {
                
                    int pubID = Int16.Parse(TextBox4.Text);
                    int thesisID = Int16.Parse(TextBox5.Text);

                    SqlCommand addP = new SqlCommand("linkPubThesis", conn);
                    addP.CommandType = CommandType.StoredProcedure;

                    addP.Parameters.Add(new SqlParameter("@thesisSerialNo", SqlDbType.Int)).Value = thesisID;
                    addP.Parameters.Add(new SqlParameter("@PubID", SqlDbType.Int)).Value = pubID;
                    addP.Parameters.Add(new SqlParameter("@sid", SqlDbType.Int)).Value = Session["UserId"];
                    SqlParameter success = addP.Parameters.Add("@success", SqlDbType.Bit);
                    success.Direction = System.Data.ParameterDirection.Output;

                    conn.Open();
                    addP.ExecuteNonQuery();
                    conn.Close();

                    if (success.Value.ToString() == "True")
                    {
                        string text = "Successful Entry";
                        System.Windows.MessageBox.Show(text);
                        Response.Redirect("Publication.aspx");
                    }

                    else
                    {
                       string text = "ThesisID/PubID doesn't Exist";
                        System.Windows.MessageBox.Show(text);
                        Response.Redirect("Publication.aspx");
                    }
                }
                
            }
           
            catch (FormatException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please Enter a number');", true);
                Response.Redirect("Publication.aspx");
            }

        }
    }
}