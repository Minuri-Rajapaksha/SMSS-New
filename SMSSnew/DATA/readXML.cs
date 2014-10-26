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

namespace SMSSnew.DATA
{
    public class readXML
    {
        //read queries from XML
        public string readXMLtxt(string queryID, string path)
        {
            string query = "";
            try
            {
                XmlReader reader = XmlReader.Create(HttpContext.Current.Server.MapPath(path));

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "scripts"))
                    {
                        if (reader.HasAttributes)
                        {
                            query = reader.GetAttribute(queryID);
                            if (query != null)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return query;
        }
    }
}
