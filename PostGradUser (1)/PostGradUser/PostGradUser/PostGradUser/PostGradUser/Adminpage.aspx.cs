using System;
using System.Web.UI;

namespace PostGradUser
{
    public partial class Admin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Supervisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupervisorsAdmin.aspx");

        }

        protected void Thesis_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThesisAdmin.aspx");
        }

        protected void IssuePay_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssuePayAdmin.aspx");
        }

        protected void IssueInstal_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueInstaladmin.aspx");

        }
        protected void UpdateExt_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateExtAdmin.aspx");

        }
    }
}