using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MileStone3
{
    public partial class Examinerpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddComment(EXAM).aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGrade(EXAM).aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditMyInfo(EXAM).aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListAllInfo(EXAM).aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchForThesis(EXAM).aspx");
        }
    }
}