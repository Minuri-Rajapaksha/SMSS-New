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
using SMSSnew.CLASSES;
using System.Collections;

namespace SMSSnew.DATA
{
    public class LeaveApplicationListDA
    {
        static smss_web_service_app srv = new smss_web_service_app();
        static readXML XMLreader = new readXML();
        static string query = "";
       

        // should be in leave app list
        public string countAvailableAndPendingLeaves(string teacherID)
        {
            string numOfLeaves = "";
            DataTable dataTable = new DataTable();

            try
            {             
                query = XMLreader.readXMLtxt("countAvailablePendingLeaves", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHERID", teacherID);
                dataTable = srv.Search(query);

                for (int i = 0; i < 6; i++ )
                {
                    if (dataTable.Rows[0][i].ToString() == "null" || dataTable.Rows[0][i].ToString() == "")
                    {
                        if (i == 0)
                            numOfLeaves = maxLeaves("maxCas").ToString();
                        else if(i == 1)
                            numOfLeaves = numOfLeaves + "," + maxLeaves("maxMedi").ToString();
                        else
                            numOfLeaves = numOfLeaves + "," + "0";
                    }
                    else
                    {
                        if (i == 0)
                            numOfLeaves = (maxLeaves("maxCas") - Double.Parse(dataTable.Rows[0][i].ToString())).ToString();
                        else if (i == 1)
                            numOfLeaves = numOfLeaves + "," + (maxLeaves("maxMedi") - Double.Parse(dataTable.Rows[0][i].ToString())).ToString();
                        else
                            numOfLeaves = numOfLeaves + "," + dataTable.Rows[0][i].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numOfLeaves;
        }



        // should be in leave app list
        public double maxLeaves(string leave_type)
        {
            DataTable dataTable = new DataTable();
            
            try
            {
                string query = XMLreader.readXMLtxt(leave_type, "~/DATA/XML/LeaveXML.xml");
                srv = new smss_web_service_app();
                dataTable = srv.Search(query);
                if (dataTable.Rows[0]["MAX_DAYS"].ToString() == "null" || dataTable.Rows.Count == 0 || dataTable.Rows[0]["MAX_DAYS"].ToString() == "")
                {
                    return 0;
                }
                else
                    return double.Parse(dataTable.Rows[0]["MAX_DAYS"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    

        // should be in leave app list
        public DataTable loadTeacherLeaves(string teacherId)
        {
            srv = new smss_web_service_app();
            XMLreader = new readXML();
            DataTable dt;
            string query;

            try
            {
                query = XMLreader.readXMLtxt("loadTeacherRequestedLeaves", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@teacherID", teacherId);

                dt = srv.Search(query);
                return dt;              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // should be in leave app list
        public DataTable loadLeavesToVPrincipal()
        {
            srv = new smss_web_service_app();
            XMLreader = new readXML();
            DataTable dt;
            string query;

            try
            {
                query = XMLreader.readXMLtxt("loadRequestedLeavesToVPrincipal", "~/DATA/XML/LeaveXML.xml");
                dt = srv.Search(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // should be in leave app list
        public string countAvailableAndPendingForSpecialMedical(string teacherID)
        {
            string numOfLeaves = "";
            DataTable dataTable = new DataTable();

            try
            {
                query = XMLreader.readXMLtxt("countAvailableForSpecialMedical", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHERID", teacherID);
                dataTable = srv.Search(query);

                for (int i = 0; i < 4; i++)
                {
                    if (dataTable.Rows[0][i].ToString() == "null" || dataTable.Rows[0][i].ToString() == "")
                    {
                        if (i == 0)
                            numOfLeaves = maxLeaves("maxMedi").ToString();
                        else if (i == 1)
                            numOfLeaves = numOfLeaves + "," + "0";
                        else if (i == 2)
                            numOfLeaves = numOfLeaves + "," + maxLeaves("maxMedi").ToString();
                        else if (i == 3)
                            numOfLeaves = numOfLeaves + "," + maxLeaves("maxMedi").ToString();                       
                    }
                    else
                    {
                        if (i == 0)
                            numOfLeaves = (maxLeaves("maxMedi") - Double.Parse(dataTable.Rows[0][i].ToString())).ToString();
                        else if (i == 3 || i == 2)
                            numOfLeaves = numOfLeaves + "," + (maxLeaves("maxMedi") - Double.Parse(dataTable.Rows[0][i].ToString())).ToString();
                        else
                            numOfLeaves = numOfLeaves + "," + dataTable.Rows[0][i].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numOfLeaves;
        }
    }
}
