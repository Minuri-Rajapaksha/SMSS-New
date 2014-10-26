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

namespace SMSSnew.DATA
{
    public class LeaveApplicationDA
    {
        static smss_web_service_app srv = new smss_web_service_app();
        static readXML XMLreader = new readXML();
        
        static DataTable leaveTable = new DataTable();

        private string teacherID;
        private string leaveID;
        private DateTime startDate;
        private DateTime endDate;
        private double duration;
        private string reason;
        private int status;
        private string leaveTypeId;
        private string leaveCategoryId;
        private string absentTimePeriod;

        public void setTeacherID(string teacherID)
        {
            this.teacherID = teacherID;
        }
        public void setLeaveID(string LeaveID)
        {
            this.leaveID = LeaveID;
        }
        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public void setDuration(double duration)
        {
            this.duration = duration;
        }
        public void setReason(string reason)
        {
            this.reason = reason;
        }
        public void setStatus(int status)
        {
            this.status = status;
        }
        public void setleaveTypeId(string leaveTypeId)
        {
            this.leaveTypeId = leaveTypeId;
        }
        public void setleaveCategoryId(string leaveCategoryId)
        {
            this.leaveCategoryId = leaveCategoryId;
        }
        public void setAbsentTimePeriod(string absentTimePeriod)
        {
            this.absentTimePeriod = absentTimePeriod;
        }



        public void addLeaveToDB(LeaveApplicationDA leaveObj)
        {
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("addLeave", "~/DATA/XML/LeaveXML.xml");
                leaveObj.leaveID = getLeaveId(teacherID).ToString();

                query = query.Replace("@TEACHER_ID", leaveObj.teacherID);
                query = query.Replace("@LEAVE_ID", leaveObj.leaveID.ToString());
                query = query.Replace("@START_DATE",  leaveObj.startDate.ToString("yyyy/M/d"));
                query = query.Replace("@END_DATE",  leaveObj.endDate.ToString("yyyy/M/d"));
                query = query.Replace("@DURATION", leaveObj.duration.ToString());
                query = query.Replace("@REASON", leaveObj.reason);
                query = query.Replace("@STATUS", leaveObj.status.ToString());
                query = query.Replace("@LEAVE_TYPE_ID", leaveObj.leaveTypeId);
                query = query.Replace("@LEAVE_CATEGORY_ID", leaveObj.leaveCategoryId);
                query = query.Replace("@ABSENT_TIME_PERIOD", leaveObj.absentTimePeriod);

                srv.Modify(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteLeave(string teacherId, string leaveId)
        {
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("deleteLeave", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHER_ID", teacherId);
                query = query.Replace("@LEAVE_ID", leaveId);

                srv.Modify(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateLeaveStatus(string teacherId, string leaveId, int status)
        {
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("updateLeaveStatus", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHER_ID", teacherId);
                query = query.Replace("@LEAVE_ID", leaveId);
                query = query.Replace("@STATUS", status.ToString());

                srv.Modify(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getLeaveId(string teacherId)
        {
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("getLeaveId", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@TEACHER_ID", teacherId);
                leaveTable = srv.Search(query);
                if (leaveTable.Rows[0]["LEAVE_ID"].ToString() == "null" || leaveTable.Rows[0]["LEAVE_ID"].ToString() == "")
                {
                    return 1;
                }
                else
                {
                    return (Int32.Parse(leaveTable.Rows[0]["LEAVE_ID"].ToString()) + 1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // validate whether a holiday
        public string validateWhetherHoliDay(DateTime Date)
        {
            string message = "";
            string query = "";
           
                    try
                    {
                        query = XMLreader.readXMLtxt("checkWhetherHoliday", "~/DATA/XML/LeaveXML.xml");
                        query = query.Replace("@REQUESTING_DATE", Date.ToString("yyyy/M/d"));
                     
                        leaveTable = srv.Search(query);

                        if (leaveTable.Rows.Count > 0)
                            message = leaveTable.Rows[0][0].ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return message;
        }

        public string validateLeaveRequestedEarlier(DateTime Date, string teacher_id)
        {
            string message = "";
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("checkLeaveRequestedEarlier", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@REQUESTING_DATE", Date.ToString("yyyy/M/d"));
                query = query.Replace("@TEACHER_ID", teacher_id);

                leaveTable = srv.Search(query);

                if (leaveTable.Rows.Count > 0)
                    message = "Date Requested Earlier";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return message;
        }

        public string validateRequstedDateGreaterThanToday(DateTime Date)
        {
            string message = "";

            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;

            TimeSpan diffBetweenTwoDays = (Date - currentDate);

            if (Convert.ToInt32(diffBetweenTwoDays.TotalDays) < 0)
                message = "You have requesting already passed date !";

            return message;
        }

        public string validateWhetherMoreThanThreeForParticularDay(DateTime Date)
        {
            string message = "";
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("validateWhetherMoreThanThreeForParticularDay", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@REQUESTING_DATE", Date.ToString("yyyy/M/d"));

                leaveTable = srv.Search(query);

                if (leaveTable.Rows.Count >= 3)
                    message = "Three teachers have already requested short leaves for this day.";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return message;
        }

        public string validateWhetherMoreThanTwoForMonth(DateTime Date, string teacher_id)
        {
            string message = "";
            string query = "";
            try
            {
                query = XMLreader.readXMLtxt("validateWhetherMoreThanTwoForMonth", "~/DATA/XML/LeaveXML.xml");
                query = query.Replace("@REQUEST_DATE", Date.ToString("yyyy/M/d"));
                query = query.Replace("@TEACHERID", teacher_id);

                leaveTable = srv.Search(query);

                if (leaveTable.Rows.Count >= 2)
                    message = "Sorry! You have already taken two short leaves for this month.";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return message;
        }


        public string validateSpecialMedDurationHasEarlyRequests(DateTime FromDate, DateTime ToDate, string teacher_id)
        {
            string message = "";
            string query = "";
            try
            {
                for (DateTime i = FromDate; i <= ToDate; i = i.AddDays(1))
                {
                    query = XMLreader.readXMLtxt("checkLeaveRequestedEarlier", "~/DATA/XML/LeaveXML.xml");
                    query = query.Replace("@REQUESTING_DATE", i.ToString("yyyy/M/d"));
                    query = query.Replace("@TEACHER_ID", teacher_id);
                    leaveTable = srv.Search(query);

                    if (leaveTable.Rows.Count > 0)
                    {
                        message = "Sorry! Requesting Duration contains already requested dates. If you need to continue please delete leave " + leaveTable.Rows[0][0].ToString() + " and try again.";
                        break;
                    }
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return message;
        }

        // count duration excluding holidays and weekends
        public int countDurationBetweenTwoDays(DateTime FromDate, DateTime ToDate, string teacher_id)
        {
            string holiday="";
            bool weekend;
            int countDays=0;

            try
            {
                for (DateTime i = FromDate; i <= ToDate; i = i.AddDays(1))
                {
                    holiday = validateWhetherHoliDay(i);
                    weekend = validateWhetherWeekendDay(i);

                    if (holiday == "" && weekend == true)
                    {
                        countDays++;
                    }
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return countDays;
        }

        public bool validateWhetherWeekendDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return false;
            }
            else
                return true;
        }
    }
}
