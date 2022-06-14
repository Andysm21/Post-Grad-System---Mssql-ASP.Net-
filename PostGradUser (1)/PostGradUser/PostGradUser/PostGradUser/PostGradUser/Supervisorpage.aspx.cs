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
    public partial class Supervisorpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentAndThesisList.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentPub(SUP).aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDefenseforThesis(SUP).aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddExaminerDef(SUP).aspx");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("EvalProgRep(SUP).aspx");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("CancelThesis(SUP).aspx");

        }
    }
}