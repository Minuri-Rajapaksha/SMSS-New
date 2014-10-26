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

namespace SMSSnew.CLASSES
{
    public class userCLZ
    {

        public string user_name;
        public string password;
        public string user_type;

        public userCLZ()
        {
        }

        public userCLZ(string Uname, string Pword)
        {
            user_name = Uname;
            password = Pword;
        }

        public userCLZ(string Uname, string Pword, string Utype)
        {
            user_name = Uname;
            password = Pword;
            user_type = Utype;
        }
    }
}
