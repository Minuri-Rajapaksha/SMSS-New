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
    public class substituteDA
    {
        smss_web_service_app srv;
        DataTable dt;
        readXML XMLReader;
        
       


        public DataTable absentTeachersMon()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                query = XMLReader.readXMLtxt("absentTeachers","~/DATA/XML/substituteXML.xml");
                
                query = query.Replace("@from","1");
                query = query.Replace("@to","8");
                query = query.Replace("@a", "5");
                query = query.Replace("@b", "8");
                query = query.Replace("@c", "1");
                query = query.Replace("@d", "4");
                
                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable absentTeachersTues()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
             
                query = XMLReader.readXMLtxt("absentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "9");
                query = query.Replace("@to", "16");
                query = query.Replace("@a", "13");
                query = query.Replace("@b", "16");
                query = query.Replace("@c", "9");
                query = query.Replace("@d", "12");
               


                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable absentTeachersWed()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("absentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "17");
                query = query.Replace("@to", "24");
                query = query.Replace("@a", "21");
                query = query.Replace("@b", "24");
                query = query.Replace("@c", "17");
                query = query.Replace("@d", "20");
                

                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable absentTeachersThus()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
              
                query = XMLReader.readXMLtxt("absentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "25");
                query = query.Replace("@to", "32");
                query = query.Replace("@a","29");
                query = query.Replace("@b", "32");
                query = query.Replace("@c", "25");
                query = query.Replace("@d", "28");
              
                dt = srv.Search(query);
               

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable absentTeachersFri()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("absentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "33");
                query = query.Replace("@to", "40");
                query = query.Replace("@a", "37");
                query = query.Replace("@b", "40");
                query = query.Replace("@c", "33");
                query = query.Replace("@d", "36");
                

                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }


        public DataTable presentTeachersMon()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "1");
                query = query.Replace("@to", "8");
                query = query.Replace("@a", "1");
                query = query.Replace("@b", "4");
                query = query.Replace("@c", "5");
                query = query.Replace("@d", "8");
                

                dt = srv.Search(query);//return the techer_id,class_id,slot_id,subject_type_name,subject_code and leave_category_id
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public DataTable presentTeachersTues()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "9");
                query = query.Replace("@to", "16");
                query = query.Replace("@a", "9");
                query = query.Replace("@b", "12");
                query = query.Replace("@c", "13");
                query = query.Replace("@d", "16");
               

                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable presentTeachersWed()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
               
                query = XMLReader.readXMLtxt("presentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "17");
                query = query.Replace("@to", "24");
                query = query.Replace("@a", "17");
                query = query.Replace("@b", "20");
                query = query.Replace("@c", "21");
                query = query.Replace("@d", "24");
                
                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
    

        public DataTable presentTeachersThus()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "25");
                query = query.Replace("@to", "32");
                query = query.Replace("@a", "25");
                query = query.Replace("@b", "28");
                query = query.Replace("@c", "29");
                query = query.Replace("@d", "32");

                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }


        public DataTable presentTeachersFri()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTeachers", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "33");
                query = query.Replace("@to", "40");
                query = query.Replace("@a", "33");
                query = query.Replace("@b", "36");
                query = query.Replace("@c", "37");
                query = query.Replace("@d", "40");
               

                
                dt = srv.Search(query);
            
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable distinctPresntMon()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("distictpresentTchrs", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "1");
                query = query.Replace("@to", "8");
                query = query.Replace("@a", "1");
                query = query.Replace("@b", "4");
                query = query.Replace("@c", "5");
                query = query.Replace("@d", "8");


                dt = srv.Search(query);//return the teacher_id of present teachers
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;

        }
        public DataTable distinctPresntTues()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("distictpresentTchrs", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "9");
                query = query.Replace("@to", "16");
                query = query.Replace("@a", "9");
                query = query.Replace("@b", "12");
                query = query.Replace("@c", "13");
                query = query.Replace("@d", "16");


                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable distinctPresntWed()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
              
                query = XMLReader.readXMLtxt("distictpresentTchrs", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "17");
                query = query.Replace("@to", "24");
                query = query.Replace("@a", "17");
                query = query.Replace("@b", "20");
                query = query.Replace("@c", "21");
                query = query.Replace("@d", "24");

                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }


        public DataTable distinctPresntThus()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("distictpresentTchrs", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "25");
                query = query.Replace("@to", "32");
                query = query.Replace("@a", "25");
                query = query.Replace("@b", "28");
                query = query.Replace("@c", "29");
                query = query.Replace("@d", "32");

                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        


        
        public DataTable distinctPresntFri()
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("distictpresentTchrs", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "33");
                query = query.Replace("@to", "40");
                query = query.Replace("@a", "33");
                query = query.Replace("@b", "36");
                query = query.Replace("@c", "37");
                query = query.Replace("@d", "40");
              
                dt = srv.Search(query);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }


        public DataTable findTechrTTMon(substituteCLZ obj)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTchsTT", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "1");
                query = query.Replace("@to", "8");
                query = query.Replace("@a", "1");
                query = query.Replace("@b", "4");
                query = query.Replace("@c", "5");
                query = query.Replace("@d", "8");
                query = query.Replace("@e", obj.present_teacher);

                dt = srv.Search(query);//return the techer_id,class_id,slot_id,subject_type_name,subject_code and leave_category_id
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public DataTable findTechrTTTues(substituteCLZ obj)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
               
                query = XMLReader.readXMLtxt("presentTchsTT", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "9");
                query = query.Replace("@to", "16");
                query = query.Replace("@a", "9");
                query = query.Replace("@b", "12");
                query = query.Replace("@c", "13");
                query = query.Replace("@d", "16");
                query = query.Replace("@e", obj.present_teacher);

                dt = srv.Search(query);

            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable findTechrTTWedn(substituteCLZ obj)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
               
                query = XMLReader.readXMLtxt("presentTchsTT", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "17");
                query = query.Replace("@to", "24");
                query = query.Replace("@a", "17");
                query = query.Replace("@b", "20");
                query = query.Replace("@c", "21");
                query = query.Replace("@d", "24");
                query = query.Replace("@e", obj.present_teacher);
                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }


        public DataTable findTechrTTThurs(substituteCLZ obj)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                
                query = XMLReader.readXMLtxt("presentTchsTT", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "25");
                query = query.Replace("@to", "32");
                query = query.Replace("@a", "25");
                query = query.Replace("@b", "28");
                query = query.Replace("@c", "29");
                query = query.Replace("@d", "32");
                query = query.Replace("@e", obj.present_teacher);
                dt = srv.Search(query);


            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
        public DataTable findTechrTTFri(substituteCLZ obj)
        {
            string query = "";
            try
            {
                srv = new smss_web_service_app();
                XMLReader = new readXML();
                //query = readXML("presentTchsTT");
                query = XMLReader.readXMLtxt("presentTchsTT", "~/DATA/XML/substituteXML.xml");
                query = query.Replace("@from", "33");
                query = query.Replace("@to", "40");
                query = query.Replace("@a", "33");
                query = query.Replace("@b", "36");
                query = query.Replace("@c", "37");
                query = query.Replace("@d", "40");
                query = query.Replace("@e",obj.present_teacher);
                dt= srv.Search(query);
            }
            catch(Exception exc)
            {
                throw exc;
            }
            return dt;   
        }


       
    }


}
