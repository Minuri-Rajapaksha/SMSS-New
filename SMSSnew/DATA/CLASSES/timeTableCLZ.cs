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
using System.Collections;
using SMSSnew.BIZ;
using SMSSnew.CLASSES;

namespace SMSSnew.DATA.CLASSES
{
     
    public class timeTableCLZ
    {
        public string class_id;
        public string[,] input_records;

      
        DataTable dt;

        static smss_web_service_app srv = new smss_web_service_app();
        static readXML XMLreader = new readXML();
        //static readXML XMLreader = new readXML();

        TimetableBIZ ttBIZ = new TimetableBIZ();

        

        public timeTableCLZ()
        {
        }
        public timeTableCLZ(String c)
        {
            this.class_id = c;
        }

        public void setClassID(String CID)
        {

            this.class_id = CID;
        }

        public void setInputRecords(String CID)
        {
           input_records= getInputRecords(CID);
            
        }

        public String[,] getInputRecords()
        {
            return input_records ;

        }

        public void createTT(string[,] rd)
        {
            String gid, cid, scod, slot, tid, slot1;

            int s, j, i, m, dd;

            //...........................METHOD..................................
            int k = 0;
            int p = Convert.ToInt32(rd[k, 4]);   // # of periods to be assigned

            ArrayList conflict_slot = new ArrayList();

            for (j = 1; j < 9; j++)
            {
                for (i = 1; i < 6; i++)
                {

                    //int conflict_slot;
                    if (p != 0)  // tot_periods != 0
                    {
                        scod = rd[k, 2];
                        gid = "6";
                        cid = rd[k, 3];
                        tid = rd[k, 0];

                        if (conflict_slot.Count != 0)
                        {
                            for (m = 0; m <= conflict_slot.Count; m++)
                            {
                                if ((conflict_slot.Count == 0) || (p == 0))
                                    break;
                                s = (int)conflict_slot[0];
                                slot1 = s.ToString();
                                if ((ttBIZ.hasTeacherConflict(tid, slot1) == false))
                                {

                                    recInsert(gid, cid, slot1, scod, tid);
                                    Console.Write(gid + "\t" + cid + "\t" + tid + "\t" + slot1 + "\t" + scod + "\n");

                                    p = p - 1;
                                    conflict_slot.Remove(s);
                                    m = m - 1;
                                    continue;
                                }
                                else
                                    continue;
                            }
                            if (p == 0)
                            {
                                k = k + 1;
                                scod = rd[k, 2];
                                gid = "6";
                                cid = rd[k, 3];
                                tid = rd[k, 0];
                                p = Convert.ToInt32(rd[k, 4]);
                            }
                        }
                        s = 8 * i - 7 + (j - 1);

                        if (scod == "S9")
                        {
                            if (Aesthetic_already_assigned(cid, "S9") == true || p != Convert.ToInt32(rd[k, 4]))
                            {
                                bool b;

                                b = Aesthetic_clash(s.ToString(), cid, "S9");
                                if (b == true)
                                {
                                    Aesthetic(s.ToString(), cid, "S9");
                                    Console.Write(gid + "\t" + cid + "\t" + s + "\t" + scod + "\n");
                                    p = p - 1;
                                }
                                else
                                    break;

                            }
                            else
                            {
                                // k = k + 1;
                                p = 0;
                                // break;
                            }

                        }
                        else
                        {
                            slot = s.ToString();

                            if ((ttBIZ.hasClassConflict(cid, slot) == true))
                            {
                                continue;
                            }


                            if ((ttBIZ.hasTeacherConflict(tid, slot) == true))
                            {
                                conflict_slot.Add(s);
                                continue;
                            }

                            recInsert(gid, cid, slot, scod, tid);
                            Console.Write(gid + "\t" + cid + "\t" + tid + "\t" + slot + "\t" + scod + "\n");

                            p = p - 1;
                        }

                    }
                    else
                    {
                        //if (k < rd.Length)
                        if (k < rd.GetLength(0))
                        {
                            k = k + 1;
                            scod = rd[k, 2];
                            gid = "6";
                            cid = rd[k, 3];
                            tid = rd[k, 0];

                            p = Convert.ToInt32(rd[k, 4]);

                            if (conflict_slot.Count != 0)
                            {
                                for (m = 0; m <= conflict_slot.Count; m++)
                                {
                                    if ((conflict_slot.Count == 0) || (p == 0))
                                        break;
                                    s = (int)conflict_slot[0];
                                    slot1 = s.ToString();
                                    if ((ttBIZ.hasTeacherConflict(tid, slot1) == false))
                                    {

                                        recInsert(gid, cid, slot1, scod, tid);
                                        Console.Write(gid + "\t" + cid + "\t" + tid + "\t" + slot1 + "\t" + scod + "\n");

                                        p = p - 1;
                                        conflict_slot.Remove(s);
                                        m = m - 1;
                                        continue;
                                    }
                                    else
                                        continue;
                                }
                                if (p == 0)
                                {
                                    k = k + 1;
                                    scod = rd[k, 2];
                                    gid = "6";
                                    cid = rd[k, 3];
                                    tid = rd[k, 0];
                                    p = Convert.ToInt32(rd[k, 4]);
                                }
                            }
                            s = 8 * i - 7 + (j - 1);
                            if (scod == "S9")
                            {
                                // Console.Write(".....");
                                if (Aesthetic_already_assigned(cid, "S9") == true || p != Convert.ToInt32(rd[k, 4]))
                                {

                                    if (Aesthetic_clash(s.ToString(), cid, "S9") == true)
                                    {
                                        Aesthetic(s.ToString(), cid, "S9");
                                        Console.Write(gid + "\t" + cid + "\t" + s + "\t" + scod + "\n");
                                        p = p - 1;
                                    }
                                    else
                                        break;

                                }
                                else
                                {
                                    // k = k + 1;
                                    p = 0;
                                    // break;
                                }

                            }
                            else
                            {

                                slot = s.ToString();

                                if ((ttBIZ.hasClassConflict(cid, slot) == true))
                                {
                                    continue;
                                }


                                if ((ttBIZ.hasTeacherConflict(tid, slot) == true))
                                {
                                    conflict_slot.Add(s);
                                    continue;
                                }

                                recInsert(gid, cid, slot, scod, tid);
                                Console.Write(gid + "\t" + cid + "\t" + tid + "\t" + slot + "\t" + scod + "\n");

                                p = p - 1;
                            }

                        }
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("k=" + k + "p=" + p);
            //  if ((rd.Length - 1 != k) && (conflict_slot.Count != 0))

            if (((rd.GetLength(0) - 1 != k) && (conflict_slot.Count != 0) && (p != 0)) || ((rd.GetLength(0) - 1 != k) && (conflict_slot.Count != 0) && (p == 0)) || ((rd.GetLength(0) - 1 == k) && (conflict_slot.Count != 0) && (p != 0)))
            {
                Console.WriteLine("length=" + rd.GetLength(0));

                for (i = k + 1; i < rd.GetLength(0); i++)
                {
                    int k1 = p;
                    int x = 0;

                    if (x > conflict_slot.Count - 1)
                        break;

                    if (k1 != 0)
                        i = k;

                    scod = rd[i, 2];
                    gid = "6";
                    cid = rd[i, 3];
                    tid = rd[i, 0];
                    if (k1 == 0)
                        p = Convert.ToInt32(rd[i, 4]);
                    else
                        p = k1;

                    while (p != 0)
                    {

                        s = (int)conflict_slot[x];
                        slot1 = s.ToString();

                        //.............

                        bool b1 = (ttBIZ.hasTeacherConflict(tid, slot1) == false);    //f  //
                        bool b2 = (ttBIZ.hasTeacherConflict(tid, slot1) == true); //t
                        bool b3 = (ttBIZ.isSelfStudies(tid) == true); //t
                        bool b4 = b2 && b3;     //t
                        bool b5 = b1 || b4;//t

                        if (((ttBIZ.hasTeacherConflict(tid, slot1) == false)) || (((ttBIZ.hasTeacherConflict(tid, slot1) == true)) && (ttBIZ.isSelfStudies(tid) == true)))
                        {

                            recInsert(gid, cid, slot1, scod, tid);
                            Console.Write(gid + "\t" + cid + "\t" + tid + "\t" + slot1 + "\t" + scod + "\n");
                            p = p - 1;

                            conflict_slot.Remove(s);

                        }
                        else
                        {
                            if (x < conflict_slot.Count - 1)
                                x = x + 1;
                            else
                            {
                                p = 0;
                                break;
                            }
                        }
                    }

                }

            }
        }


        //......................ttDA................................
        public void recInsert(String gID, String cID, String sID, String sCode, String tID)
        {

            string query1 = "", query2 = "";
            try
            {
                //srv = new smss_web_service_app();
                //XMLreader = new readXML();
                query1 = XMLreader.readXMLtxt("InsertToSlotAllocation", "~/DATA/XML/TimetableXML.xml");

                query1 = query1.Replace("@gID", gID);
                query1 = query1.Replace("@cID", cID);
                query1 = query1.Replace("@sID", sID);
                query1 = query1.Replace("@sCode", sCode);
                srv.Modify(query1);

               // srv.Search(query1);

                query2 = XMLreader.readXMLtxt("InsertToTeacherAssignedToSlot", "~/DATA/XML/TimetableXML.xml");

                query2 = query2.Replace("@tID", tID);
                query2 = query2.Replace("@cID", cID);
                query2 = query2.Replace("@sID", sID);
                srv.Modify(query2);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
           
        }

        public DataTable teacherConflict(string tID, string sID)
        {
            string query = "";
            DataTable dt = new DataTable();
            try
            {

                query = XMLreader.readXMLtxt("GetTeacherConflict", "~/DATA/XML/TimetableXML.xml");
                query = query.Replace("@tID", tID);
                query = query.Replace("@sID", sID);

                dt = srv.Search(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


       public DataTable classConflict(string cID, string sID)
        {
            string query = "";
            DataTable dt = new DataTable();
            try
            {

                query = XMLreader.readXMLtxt("GetClassConflict", "~/DATA/XML/TimetableXML.xml");
                query = query.Replace("@cID", cID);
                query = query.Replace("@sID", sID);

                dt = srv.Search(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public  bool Aesthetic_clash(string timeslot, string classid, string subjectid)
        {
            DataTable dt;
            DataTable dt1;

            string query1 = "", query2 = "", query3 = "";

            try
            {
                //Aesthetic_already_assigned(classid, subjectid);
                query1 = XMLreader.readXMLtxt("GetSubjectType", "~/DATA/XML/TimetableXML.xml");
                query1 = query1.Replace("@subject", subjectid);
                dt = srv.Search(query1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    query2 = XMLreader.readXMLtxt("GetAestheticTeachers", "~/DATA/XML/TimetableXML.xml");
                    query2 = query2.Replace("@sub1", Convert.ToString(dt.Rows[i][0]));
                    query2 = query2.Replace("@class_id", classid);
                    dt1 = srv.Search(query2);

                    query3 = XMLreader.readXMLtxt("GetAestheticTeachersClash", "~/DATA/XML/TimetableXML.xml");
                    query3 = query3.Replace("@teacher", Convert.ToString(dt1.Rows[0][0]));
                    //query3=query3.Replace("@class",classid);
                    query3 = query3.Replace("@slot", timeslot);

                    DataTable dt2 = srv.Search(query3);

                    if (dt2.Rows.Count > 0)
                    {
                        return false;
                        //break;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;

        }

        public void Aesthetic(string timeslot, string classid, string subject_id)
        {
            DataTable dt;
            DataTable dt1;

            string query1 = "", query2 = "", query3 = "", query4 = "", query5 = "", query6 = "";
            try
            {

                query1 = XMLreader.readXMLtxt("GetSubjectGroups", "~/DATA/XML/TimetableXML.xml");
                query1 = query1.Replace("@class_id", classid);
                query1 = query1.Replace("@subject_id", subject_id);
                dt = srv.Search(query1);
                string groupid = Convert.ToString(dt.Rows[0][0]);

                query3 = XMLreader.readXMLtxt("GetGradeID", "~/DATA/XML/TimetableXML.xml");
                query3 = query3.Replace("@class_id", classid);
                DataTable dt2 = srv.Search(query3);

                query2 = XMLreader.readXMLtxt("GetSubjectGroupClasses", "~/DATA/XML/TimetableXML.xml");
                query2 = query2.Replace("@group_id", groupid);
                query2 = query2.Replace("@subject_id", subject_id);
                query2 = query2.Replace("@grade_id", Convert.ToString(dt2.Rows[0][0]));
                dt1 = srv.Search(query2);


                                

                for (int i = 0; i < dt1.Rows.Count; i++)
                {

                    query4 = XMLreader.readXMLtxt("InsertToSlotAllocation", "~/DATA/XML/TimetableXML.xml");
                    query4 = query4.Replace("@gID", Convert.ToString(dt2.Rows[0][0]));
                    query4 = query4.Replace("@cID", Convert.ToString(dt1.Rows[i][0]));
                    query4 = query4.Replace("@sID", timeslot);
                    query4 = query4.Replace("@sCode", subject_id);

                    

                    srv.Modify(query4);

                }
                query5 = XMLreader.readXMLtxt("query6", "~/DATA/XML/TimetableXML.xml");
                query5 = query5.Replace("@class_id", classid);
                query5 = query5.Replace("@subject_id", subject_id);


                DataTable dt4 = srv.Search(query5);

                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        query6 = XMLreader.readXMLtxt("InsertToTeacherAssignedToSlot", "~/DATA/XML/TimetableXML.xml");
                        query6 = query6.Replace("@tID", Convert.ToString(dt4.Rows[i][0]));
                        query6 = query6.Replace("@cID", Convert.ToString(dt1.Rows[j][0]));
                        query6 = query6.Replace("@sID", timeslot);

                        srv.Modify(query6);
                    }
                }

            }

            catch (Exception Exception)
            {

                throw Exception;
            }

        }


        public bool Aesthetic_already_assigned(string classid, string subject_id)
        {
          
            DataTable dt1;
            string query = "";
            //DataTable dt2;
            //DataTable dt3;
            //DataTable dt4;
            // string assigned="no";

            try
            {
                query = XMLreader.readXMLtxt("GetAlreadyAssignedAesthetic", "~/DATA/XML/TimetableXML.xml");
                query = query.Replace("@class_id", classid);
                query = query.Replace("@subject_id", subject_id);
                dt1 = srv.Search(query);
                //string groupid = Convert.ToString(dt1.Rows[0][0]);

                if (dt1.Rows.Count > 0)
                {
                    return false;
                }
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }



        public  String[,] getInputRecords(string cID)
        {
            int i, j;
            
            string query = "";
            String[,] table;
            DataTable dt = new DataTable();
            try
            {

                query = XMLreader.readXMLtxt("GetOrderedInputRecords", "~/DATA/XML/TimetableXML.xml");
                query = query.Replace("@cID", cID);
                dt = srv.Search(query);

                table = new String[dt.Rows.Count, 6];

                for (i = 0; i < dt.Rows.Count; i++)
                {
                    for (j = 0; j < 6; j++)
                    {
                        table[i, j] = dt.Rows[i][j].ToString();

                        // Console.Write(table[i, j] + "\t");
                    }
                    //Console.Write("\n");
                }
                // Console.ReadLine();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return table;

        }

        // ..........................................Loaded To vicePrinTtCreate Interface.............................................

       

        public DataTable loadGrade()
        {
            string query = "";
            try
            {
               
                query = XMLreader.readXMLtxt("loadGrade", "~/DATA/XML/TimetableXML.xml");
                dt = srv.Search(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

       public DataTable loadClassID(classCLZ objClass)
        {
            string query = "";
            try
            {

                query = XMLreader.readXMLtxt("loadClassID", "~/DATA/XML/TimetableXML.xml");
                query = query.Replace("@gradeID", objClass.grade_id);

                dt = srv.Search(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }




       // ..........................................VIEW CLASS TIMETABLE.............................................


       public void viewClassTimetable(string class_id)
       {
          
           string query = "";
           try
           {
               int mon = 1;
               int tue = 9;
               int wed = 17;
               int thu = 25;
               int fri = 33;

               query = XMLreader.readXMLtxt("create_temporary", "~/DATA/XML/timetableXML.xml");
               srv.Modify(query);

               for (int i = 0; i <= 7; i++)
               {
                   srv = new smss_web_service_app();


                   query= XMLreader.readXMLtxt("insert_temporary", "~/DATA/XML/timetableXML.xml");

                   query = query.Replace("@class_id", class_id);
                   query = query.Replace("@mon", mon.ToString());
                   query = query.Replace("@tue", tue.ToString());
                   query = query.Replace("@wed", wed.ToString());
                   query = query.Replace("@thu", thu.ToString());
                   query = query.Replace("@fri", fri.ToString());


                   srv.Modify(query);

                   mon = mon + 1;
                   tue = tue + 1;
                   wed = wed + 1;
                   thu = thu + 1;
                   fri = fri + 1;


               }
               

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public DataTable loadClassTimetableToGrid()
       {
           dt = new DataTable();
           
           string query = "";

           query = XMLreader.readXMLtxt("loadClassTimetable", "~/DATA/XML/timetableXML.xml");
           dt = srv.Search(query);

           query = XMLreader.readXMLtxt("drop_temporary", "~/DATA/XML/timetableXML.xml");
           srv.Modify(query);

           return dt;

                    


       }



        // ..........................................VIEW TEACHER TIMETABLE.............................................

       
        public void viewTeacherTimetable(string teacher_id)
       {
        //   xmlReader = new readXML();
         //  srv = new smss_web_service_app();
           string query = "";
           string query1 = "";
           try
           {
              
               query1 = XMLreader.readXMLtxt("createTemporyTable", "~/DATA/XML/timetableXML.xml");
               srv.Modify(query1);

               int mon = 1;
               int tue = 9;
               int wed = 17;
               int thu = 25;
               int fri = 33;

               for (int i = 0; i <= 7; i++)
               {
                   srv = new smss_web_service_app();


                   query = XMLreader.readXMLtxt("insert_tempory", "~/DATA/XML/timetableXML.xml");

                   query = query.Replace("@teacher_id", teacher_id);
                   query = query.Replace("@mon", mon.ToString());
                   query = query.Replace("@tue", tue.ToString());
                   query = query.Replace("@wed", wed.ToString());
                   query = query.Replace("@thu", thu.ToString());
                   query = query.Replace("@fri", fri.ToString());


                   srv.Modify(query);
                   mon = mon + 1;
                   tue = tue + 1;
                   wed = wed + 1;
                   thu = thu + 1;
                   fri = fri + 1;


               }
               

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public DataTable loadTeacherTimetableToGrid()
       {
           dt = new DataTable();
         //  xmlReader = new readXML();
         //  srv = new smss_web_service_app();
           string query = "";
           string query1 = "";

           query = XMLreader.readXMLtxt("loadTeacherTimetable", "~/DATA/XML/timetableXML.xml");
           dt = srv.Search(query);
           query1 = XMLreader.readXMLtxt("deleteTemporyTable", "~/DATA/XML/timetableXML.xml");
           srv.Modify(query1);

           return dt;

       }

       public DataTable loadTeacherIdCbo()
       {
           dt = new DataTable();
           //   XmlReader = new readXML();
           //  srv = new smss_web_service_app();
           string query = "";


           query = XMLreader.readXMLtxt("loadTeacherIds", "~/DATA/XML/timetableXML.xml");
           dt = srv.Search(query);


           return dt;

       }

        

    }

}
