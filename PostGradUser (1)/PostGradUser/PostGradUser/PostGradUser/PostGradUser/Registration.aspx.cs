using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    public partial class Registration1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StudentClick(object sender, EventArgs e)
        {


            Response.Redirect("Studentregister.aspx");
        }

        protected void SupervisorClick(object sender, EventArgs e)
        {
            Response.Redirect("Supervisorregister.aspx");
        }

        protected void ExaminerClick(object sender, EventArgs e)
        {
            Response.Redirect("Examinerregister.aspx");
        }
    }
}