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

using SMSSnew.DATA;


namespace SMSSnew.UI
{
    public partial class vicePriLoadSubTTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //   LeaveDA obj1;

            try
            {
                DataTable leaveGrid = new DataTable();
         //       obj1 = new LeaveDA();

        //        leaveGrid = obj1.vicePrinLeaveHand();
                //RadGrid1.DataSource = leaveGrid;
                //RadGrid1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
