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

namespace SMSSnew
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void butLogin_Click1(object sender, EventArgs e)
        {
            HomeBIZ home = new HomeBIZ();
            string type;
            userCLZ objUser = new userCLZ(txtUName.Text, txtPWord.Text);
            bool login = home.login(objUser);

            if (login == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('You have successfully logged in');", true);
                type = home.getUserType(objUser);

                Session["username"] = txtUName.Text;

                if (type == "TCH")
                {
                    Response.Redirect("Home_Teacher.aspx");
                }
                else if (type == "PRN")
                {
                    Response.Redirect("Home_V_Principal.aspx");
                }
                else if (type == "SUB")
                {
                    Response.Redirect("Home_S_T_Operator.aspx");
                }
                else if (type == "STU")
                {
                    Response.Redirect("Home_Student.aspx");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('Please Try Again !');", true);
            }
        }

        //protected void butReset_Click(object sender, EventArgs e)
        //{
        //    if (IsPostBack){
        //        txtUName.Text = " ";
        //        txtPWord.Text = "";
        //        txtPWord.Attributes["placeholder"] = " ";
        //    }
        //}

        protected void butForgotPWord_Click(object sender, EventArgs e)
        {
           // Response.Redirect("ForgotPassword.aspx?UserName=" + txtUName.Text);
            Response.Redirect("ForgotPassword.aspx");
        } 
    }
}
