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

using MySql.Data.MySqlClient;
using System.Data;

namespace SMSSnew.DATA
{
    public class DBconnection
    {
        protected static string connectionString = " server=localhost; User Id= root; Password= 1234; Persist Security Info= True; database= test ";
        protected static MySqlConnection connection = new MySqlConnection(connectionString);

        //open connection to database
        protected bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: break;

                    case 1045:  break;
                }
                return false;
            }
        }

        //Close connection
        protected bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        //not return any data
        protected void Modify(String query)
        {
            this.CloseConnection();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }


        //return data
        public DataTable Search(String query)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("testColumn");
            DataRow testRow = dt.NewRow();
            testRow["testColumn"] = "test";
            dt.Rows.Add(testRow);

            try
            {
                this.CloseConnection();
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataAdapter a = new MySqlDataAdapter(cmd))
                {
                    a.Fill(dt);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Dispose();
            }

            CloseConnection();
            return dt;
        }
    }
}
