<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_V_Principal.aspx.cs"
    Inherits="SMSSnew.UI.Home_V_Principal" %>

<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
<%@ Register src="smss_controller.ascx" tagname="smss_controller" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Vice Principal Page</title>
</head>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
                        
                <uc1:smss_controller ID="smss_controller1" runat="server" />
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Vice Principal</h4>
        <br />
        <table class="table container text-left">
            <tr>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButProfile" runat="server" 
                            ImageUrl="~/IMAGES/vprincipalF.png" class="img-rounded imgsz" 
                            onclick="imgButProfile_Click" />
                        <h6>
                    My Profile</td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButLeave" runat="server" ImageUrl="~/IMAGES/leave.png" 
                            class="img-rounded imgsz" onclick="imgButLeave_Click"/>
                        <br />
                        <h6>
                    Leave Application Forms</td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButTTable" runat="server" 
                            ImageUrl="~/IMAGES/createttable.png" class="img-rounded imgsz" 
                            onclick="imgButTTable_Click" />
                        <h6>
                    Timetable</td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButSubTeacher" runat="server" 
                            ImageUrl="~/IMAGES/ttableedit.png" class="img-rounded imgsz" 
                            onclick="imgButSubTeacher_Click"/>
                        <br />
                        <h6>
                    Substitute Teacher</td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButDataEntry" runat="server" ImageUrl="~/IMAGES/table.png" class="img-rounded imgsz "/>
                        <br />
                        <h6>
                    Data Entry</td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgBUtUserAcc" runat="server" ImageUrl="~/IMAGES/uaccount.png" class="img-rounded imgsz "/>
                        <br />
                        <h6>
                    User Accounts</td>
            </tr>
        </table>
        </form>
    </div>

    <script src="js/bootstrap.js"></script>

</body>
</html>
