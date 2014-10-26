using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using SMSSnew.smss_web_reference;

namespace SMSSnew.DATA
{
    public class HalfDayShortLeaveDA
    {
        static smss_web_service_app srv = new smss_web_service_app();
        static readXML XMLreader = new readXML();
        static string query = "";
        static DataTable leaveTable = new DataTable();


        public bool validateLeaveRequestedEarlier(DateTime requestingDate, string teacherId)
        {
 
            try
            {
                query = XMLreader.readXMLtxt("checkHalfShortLeaveRequestedEarlier", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHER_ID", teacherId);
                query = query.Replace("@REQUESTING_DATE", requestingDate.Date.ToString("yyyy/M/d"));

                leaveTable = srv.Search(query);
                if (leaveTable.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
