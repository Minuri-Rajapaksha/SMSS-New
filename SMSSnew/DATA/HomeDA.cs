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

using System.Xml;
using SMSSnew.smss_web_reference;
using SMSSnew.CLASSES;

namespace SMSSnew.DATA
{
    public class HomeDA
    {
        smss_web_service_app srv;
        DataTable dt;
        readXML XMLreader;

        //handle dataflow between database for the login
        public DataTable login(userCLZ objUser)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLreader = new readXML();
                query = XMLreader.readXMLtxt("login", "~/DATA/XML/homeXML.xml");

                query = query.Replace("@username", objUser.user_name);
                query = query.Replace("@password", objUser.password);

                dt = srv.Search(query);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        //handle dataflow between database for getting usertype to redirect to next page
        public DataTable getUserType(userCLZ objUser)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLreader = new readXML();
                query = XMLreader.readXMLtxt("getUserType", "~/DATA/XML/homeXML.xml");

                query = query.Replace("@username", objUser.user_name);

                dt = srv.Search(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        //handle dataflow between database for getting security questions and answers
        public DataTable getSecQues(userCLZ objUser)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLreader = new readXML();
                query = XMLreader.readXMLtxt("getSecData", "~/DATA/XML/homeXML.xml");
                
                query = query.Replace("@username", objUser.user_name);

                dt = srv.Search(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        //handle dataflow between database for sending mails
        public DataTable loadReceiverMailAndPassword(userCLZ objUser)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLreader = new readXML();
                query = XMLreader.readXMLtxt("getReceiverMailAndPassword", "~/DATA/XML/homeXML.xml");

                query = query.Replace("@username", objUser.user_name);

                dt = srv.Search(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        

    }
}
