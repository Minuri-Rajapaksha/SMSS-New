using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace SMSSnew.UI
{
    public partial class Home_Teacher : System.Web.UI.Page
    {
        public static string userName;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              // userName = Session["username"].ToString();
                userName = Session["username"].ToString();
            }
        }

        protected void imgButProfile_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("profiles/TeacherProfile.aspx");
        }

        protected void imgButLeave_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("teacher/LeaveHome.aspx");
        }

        protected void imgButTTable_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("teacher/teacherTimeTable.aspx");
        }

        
    }
}
