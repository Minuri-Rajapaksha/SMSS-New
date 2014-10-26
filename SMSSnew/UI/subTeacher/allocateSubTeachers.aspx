<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allocateSubTeachers.aspx.cs" Inherits="SMSSnew.UI.subTeacher.allocateSubTeachers" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<link href="../../css/StyleSheet.css" rel="stylesheet" type="text/css" />

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 250px;
            height: 51px;
        }
        .style2
        {
            height: 51px;
        }
    </style>
</head>
<body>

    <div class="container">
    <form id="form1" runat="server" class="well span11 text-center">
    <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>	
 
    <h4 class="text-info">Substitute Teacher Allocation</h4>
<table class="table container">
<tr>
<td class="Colwidth"><br />
<asp:Label ID="Label5" runat="server" Text="Date" ></asp:Label><br />
</td>
<td><br />
                                    <telerik:RadDatePicker ID="datepicker" 
            runat="server" Skin="WebBlue" Culture="English (United States)">
                                        <DateInput InvalidStyleDuration="100" LabelCssClass="radLabelCss_WebBlue" Skin="WebBlue" class="span4">
                                        </DateInput>
                                        <Calendar Skin="WebBlue">
                                        </Calendar>
                                        <DatePopupButton CssClass="radPopupImage_WebBlue"></DatePopupButton>
                                    </telerik:RadDatePicker>
</td>
</tr>
<tr>
<td class="Colwidth"><br />
<asp:Button ID="AbsentTeachrBtn" runat="server" onclick="AbsentTeachrBtn_Click" 
        Text="Absent Teachers Details" class="btn btn-primary"/>
    </td>
<td>&nbsp; <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</td>
</tr>
</table>  

             
           <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False"
                        GridLines="None" AllowPaging="True" Skin="WebBlue" >
                        <MasterTableView GroupLoadMode="Client">
                            <RowIndicatorColumn Visible="False">
                                <HeaderStyle />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Resizable="False" Visible="False">
                                <HeaderStyle />
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="teacher_id" HeaderText="Absent Teacher ID" SortExpression="teacher_id"
                                    UniqueName="teacherId">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="class_id" HeaderText="Class ID" SortExpression="class_id"
                                    UniqueName="classid">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="slot_id" HeaderText="Slot ID" SortExpression="slot_id"
                                    UniqueName="slotid">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="subject_code" HeaderText="Subject Code" SortExpression="subject_code"
                                    UniqueName="subjectcode">
                                </telerik:GridBoundColumn>
                                  <telerik:GridBoundColumn DataField="subject_type_name" HeaderText="Subject Type Name" SortExpression="subject_type_name"
                                    UniqueName="subjecttypename">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="leave_category_id" HeaderText="Leave Category ID" SortExpression="leave_categort_id"
                                    UniqueName="leavecategoryid">
                                </telerik:GridBoundColumn>
                                <%--<telerik:GridTemplateColumn UniqueName="TemplateColumn">
                                    
                                </telerik:GridTemplateColumn>--%>
                            </Columns>
                            <%--<GroupByExpressions>
                                <telerik:GridGroupByExpression>
                                    <GroupByFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </GroupByFields>
                                    <SelectFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </SelectFields>
                                </telerik:GridGroupByExpression>
                            </GroupByExpressions>--%>
                            <EditFormSettings>
                                <PopUpSettings ScrollBars="None" />
                            </EditFormSettings>
                        </MasterTableView>
                    </telerik:RadGrid>
                        
           <br />
<table class="table container">


<tr>
<td class="style1">
<asp:Button ID="PresentTeachrBtn" runat="server" onclick="PresentTeachrBtn_Click" 
        Text="Present Teachers Details" class="btn btn-primary"/>
    <br />
    <%--<telerik:GridTemplateColumn UniqueName="TemplateColumn">
                                    
                                </telerik:GridTemplateColumn>--%>
    </td>
<td class="style2">
    <br />
</td>
</tr>
</table>  

              

             
           <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False"
                        GridLines="None" AllowPaging="True" Skin="WebBlue" >
                        <MasterTableView GroupLoadMode="Client">
                            <RowIndicatorColumn Visible="False">
                                <HeaderStyle />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Resizable="False" Visible="False">
                                <HeaderStyle />
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="teacher_id" HeaderText="Absent Teacher ID" SortExpression="teacher_id"
                                    UniqueName="teacherId">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="class_id" HeaderText="Class ID" SortExpression="class_id"
                                    UniqueName="classid">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="slot_id" HeaderText="Slot ID" SortExpression="slot_id"
                                    UniqueName="slotid">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="subject_code" HeaderText="Subject Code" SortExpression="subject_code"
                                    UniqueName="subjectcode">
                                </telerik:GridBoundColumn>
                                  <telerik:GridBoundColumn DataField="subject_type_name" HeaderText="Subject Type Name" SortExpression="subject_type_name"
                                    UniqueName="subjecttypename">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="leave_category_id" HeaderText="Leave Category ID" SortExpression="leave_categort_id"
                                    UniqueName="leavecategoryid">
                                </telerik:GridBoundColumn>
                                <%--<telerik:GridTemplateColumn UniqueName="TemplateColumn">
                                    
                                </telerik:GridTemplateColumn>--%>
                            </Columns>
                            <%--<GroupByExpressions>
                                <telerik:GridGroupByExpression>
                                    <GroupByFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </GroupByFields>
                                    <SelectFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </SelectFields>
                                </telerik:GridGroupByExpression>
                            </GroupByExpressions>--%>
                            <EditFormSettings>
                                <PopUpSettings ScrollBars="None" />
                            </EditFormSettings>
                        </MasterTableView>
                    </telerik:RadGrid>
                        
           <br/><br/>
             
<table class="table container">


<tr>
<td class="Colwidth">
<asp:Button ID="SelectPrstTchrsBtn" runat="server" onclick="SelectPrstTchrsBtn_Click" 
        Text="Select Present Teachers" class="btn btn-primary" Width="250px"/>
    <br /><br/>
    <%--<GroupByExpressions>
                                <telerik:GridGroupByExpression>
                                    <GroupByFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </GroupByFields>
                                    <SelectFields>
                                        <telerik:GridGroupByField FieldAlias="Status" FieldName="LEAVE_STATUS" HeaderValueSeparator=" : " />
                                    </SelectFields>
                                </telerik:GridGroupByExpression>
                            </GroupByExpressions>--%>
    <br />
<asp:Button ID="FreeslotsofselectedTchrsBtn" runat="server" onclick="FreeslotsofselectedTchrsBtn_Click" 
        Text="Free Slots Of Selected Teacher" class="btn btn-primary" Width="250px"/>
    </td>
<td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="Present_teher_Dp_dwn" runat="server">
    </asp:DropDownList>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
</td>
</tr>
   </table>

             
        <br />
                
           
           <br />
                
           
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
       </form>                 
           
           </div>
          

    
    </body>
</html>
