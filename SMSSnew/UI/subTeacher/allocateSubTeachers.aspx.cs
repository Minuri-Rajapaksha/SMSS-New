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
using System.Collections.Generic;

using SMSSnew.CLASSES;
using SMSSnew.DATA;
using System.Diagnostics;

namespace SMSSnew.UI.subTeacher
{
    public partial class allocateSubTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //when the page loads the date picker loads the current date
                DateTime currentDate = new DateTime();
                currentDate = DateTime.Now;
                datepicker.SelectedDate = currentDate;
            }

        }

      

       

        protected void AbsentTeachrBtn_Click(object sender, EventArgs e)//when button clicks ,selects absent teachers from db and loads the data to radgrid table 
        {
            substituteDA mysub;

            try
            {
                DataTable dt1 = new DataTable();
             
                string dayofweek = System.DateTime.Now.DayOfWeek.ToString();
                if (dayofweek == "Monday")
                {
                    mysub = new substituteDA();
                    dt1 = mysub.absentTeachersMon();
                    RadGrid1.DataSource = dt1;
                    RadGrid1.DataBind();
                }


                if (dayofweek == "Tuesday")
                {
                    mysub = new substituteDA();
                    dt1 = mysub.absentTeachersTues();
                    RadGrid1.DataSource = dt1;
                    RadGrid1.DataBind();
                }

                if (dayofweek == "Wednesday")
                {
                    mysub = new substituteDA();
                    dt1 = mysub.absentTeachersWed();
                    RadGrid1.DataSource = dt1;
                    RadGrid1.DataBind();

                }

                if (dayofweek == "Thursday")
                {
                    mysub = new substituteDA();
                    dt1 = mysub.absentTeachersThus();
                    RadGrid1.DataSource = dt1;
                    RadGrid1.DataBind();
                }


                if (dayofweek == "Friday")//select present teachers from db and they are set to display in the radgrid 
                {
                    mysub = new substituteDA();
                    dt1 = mysub.absentTeachersFri();
                    RadGrid1.DataSource = dt1;
                    RadGrid1.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        protected void PresentTeachrBtn_Click(object sender, EventArgs e)
        {
            
            substituteDA mysub2;
            {
                try
                {
                    DataTable dt2 = new DataTable();
                    string dayofweek = System.DateTime.Now.DayOfWeek.ToString();
                    if (dayofweek == "Monday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.presentTeachersMon();
                        RadGrid2.DataSource = dt2;
                        RadGrid2.DataBind();
                    }


                    if (dayofweek == "Tuesday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.presentTeachersTues();
                        RadGrid2.DataSource = dt2;
                        RadGrid2.DataBind();
                    }

                    if (dayofweek == "Wednesday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.presentTeachersWed();
                        RadGrid2.DataSource = dt2;
                        RadGrid2.DataBind();

                    }

                    if (dayofweek == "Thursday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.presentTeachersThus();
                        RadGrid2.DataSource = dt2;
                        RadGrid2.DataBind();
                    }


                    if (dayofweek == "Friday")//select present teachers from db and they are set to display in the radgrid
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.presentTeachersFri();
                        substituteCLZ obj1 = new substituteCLZ();
                        RadGrid2.DataSource = dt2;
                        RadGrid2.DataBind();
                    }

                }
                    
                catch (Exception ex)
                {
                    throw ex;
                }


            }

        }

        protected void SelectPrstTchrsBtn_Click(object sender, EventArgs e)//when the button clicks,load the present teachers which are filtered from db to the drop down list 
        {
            substituteDA mysub2;
            {
                try
                {

                    DataTable dt2 = new DataTable();
                    string dayofweek = System.DateTime.Now.DayOfWeek.ToString();
                    if (dayofweek == "Monday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.distinctPresntMon();
                       
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string prstTchrs = dt2.Rows[i][0].ToString();
                            Present_teher_Dp_dwn.Items.Insert(i, prstTchrs.ToString());
                        }

                    }


                    if (dayofweek == "Tuesday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.distinctPresntTues();

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string prstTchrs = dt2.Rows[i][0].ToString();
                            Present_teher_Dp_dwn.Items.Insert(i, prstTchrs.ToString());
                        }
                        
                    }

                    if (dayofweek == "Wednesday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.distinctPresntWed();
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string prstTchrs = dt2.Rows[i][0].ToString();
                            Present_teher_Dp_dwn.Items.Insert(i, prstTchrs.ToString());
                        }

                    }

                    if (dayofweek == "Thursday")
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.distinctPresntThus();
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string prstTchrs = dt2.Rows[i][0].ToString();
                            Present_teher_Dp_dwn.Items.Insert(i, prstTchrs.ToString());
                        }
                    }


                    if (dayofweek == "Friday")//load the present teachers which are filtered from db to the drop down list 
                    {
                        mysub2 = new substituteDA();
                        dt2 = mysub2.distinctPresntFri();

                        
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            string prstTchrs = dt2.Rows[i][0].ToString();
                            Present_teher_Dp_dwn.Items.Insert(i, prstTchrs.ToString());
                        }
                    }
                
            }
                catch(Exception e1){
                    throw e1;
                    }

                
           
                }
            }

        protected void FreeslotsofselectedTchrsBtn_Click(object sender, EventArgs e)
        {
            string dayofweek = System.DateTime.Now.DayOfWeek.ToString();
            DataTable dt2 = new DataTable();
            int[] myArray = new int[7];
            int key = 0;
       
            string presnt_teacher = Present_teher_Dp_dwn.SelectedValue;
            string[] pt = presnt_teacher.Split(':');
            string pst_T = pt[0];

            substituteCLZ obj = new substituteCLZ(pst_T);
            substituteDA mysub3 = new substituteDA();


           
            if (dayofweek == "Monday")
            {
                dt2 = mysub3.findTechrTTMon(obj);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    int no = Convert.ToInt32(dt2.Rows[j][1]);
                    myArray[key] = no;
                    key++;
                }

                int upperlimit = 9;

                int[] b = new int[upperlimit];
                for (int i = 0; i < myArray.Length; i++)
                {
                    b[myArray[i]] = 1;
                }

                for (int k = 1; k < upperlimit; k++)
                {
                    if (b[k] == 0)
                    {
                        ListBox1.Items.Add(k.ToString());
                    }
                }
            }

            if (dayofweek == "Tuesday")
            {
                dt2 = mysub3.findTechrTTTues(obj);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    int no = Convert.ToInt32(dt2.Rows[j][1]);
                    myArray[key] = no;
                    key++;
                }

                int upperlimit = 17;

                int[] b = new int[upperlimit];
                for (int i = 0; i < myArray.Length; i++)
                {
                    b[myArray[i]] = 1;
                }

                for (int k = 9; k < upperlimit; k++)
                {
                    if (b[k] == 0)
                    {
                        ListBox1.Items.Add(k.ToString());
                    }
                }
            }


            if (dayofweek == "Wednesday")
            {
                dt2 = mysub3.findTechrTTWedn(obj);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    int no = Convert.ToInt32(dt2.Rows[j][1]);
                    myArray[key] = no;
                    key++;
                }

                int upperlimit = 25;

                int[] b = new int[upperlimit];
                for (int i = 0; i < myArray.Length; i++)
                {
                    b[myArray[i]] = 1;
                }

                for (int k = 17; k < upperlimit; k++)
                {
                    if (b[k] == 0)
                    {
                        ListBox1.Items.Add(k.ToString());
                    }
                }
            }

            if (dayofweek == "Thursday")
            {
                dt2 = mysub3.findTechrTTThurs(obj);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    int no = Convert.ToInt32(dt2.Rows[j][1]);
                    myArray[key] = no;
                    key++;
                }

                int upperlimit = 33;

                int[] b = new int[upperlimit];
                for (int i = 0; i < myArray.Length; i++)
                {
                    b[myArray[i]] = 1;
                }

                for (int k = 25; k < upperlimit; k++)
                {
                    if (b[k] == 0)
                    {
                        ListBox1.Items.Add(k.ToString());
                    }
                }
            } 
            
            if (dayofweek == "Friday")
            {
                dt2 = mysub3.findTechrTTFri(obj);
                //store all the slots of present teachers' in the myArray[] (today slots) 
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    int no = Convert.ToInt32(dt2.Rows[j][1]);
                    myArray[key] = no;  
                    key++;
                }

                int upperlimit = 41;

                int[] b = new int[upperlimit];
                for (int i = 0; i < myArray.Length; i++)
                {
                    b[myArray[i]] = 1;
                }

                for (int k = 33; k < upperlimit; k++)
                {
                    if (b[k] == 0)
                    {
                        ListBox1.Items.Add(k.ToString());
                    }
                }
            } 

           
        }
           
        }
    }
        




    

        
     
