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

using SMSSnew.BIZ;
using SMSSnew.CLASSES;

namespace SMSSnew.UI
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        HomeBIZ myHome = new HomeBIZ();
        public static string userName;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               userName = Session["username"].ToString();
            }

            userCLZ objUser = new userCLZ();
            objUser.user_name = "minuri";
            string question;
            question = myHome.loadSecData(objUser, "Question");
            txtQuestion.Text = question;

        }
        protected void butReset_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtAnswer.Text = " ";
                txtAnswer.Attributes["placeholder"] = " ";
            }
        }

        protected void butEnter_Click(object sender, EventArgs e)
        {
            string answer; 
            bool message =false;

            userCLZ objUser = new userCLZ();
            objUser.user_name = "minuri";
            answer = myHome.loadSecData(objUser, "Answer");
            
            if (answer == txtAnswer.Text)
            {
                message = myHome.fillAndSendMail(objUser);
                if(message == true)
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Password is sent successfully to your mail');", true);               
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Sending mail failure !');", true);               
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('You have entered an incorrect answer');", true);               
            }
        }

       

    }
}
