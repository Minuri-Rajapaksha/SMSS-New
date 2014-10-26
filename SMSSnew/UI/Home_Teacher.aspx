<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_Teacher.aspx.cs" Inherits="SMSSnew.UI.Home_Teacher" %>

<%@ Register src="smss_controller.ascx" tagname="smss_controller" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Teacher Page</title>
</head>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        
        <p align="left">
            <table width="100%">
                <tr>
                    <td align="left">
                        &nbsp;</td>
                    <td align="right">
                        <asp:LinkButton ID="lnkBtnLogout" runat="server" PostBackUrl="~/UI/Login.aspx" 
                            Font-Underline="True"><h5>Logout</h5></asp:LinkButton>
                    </td>
                </tr>
            </table>
            
        </p>
        <uc2:smss_controller ID="smss_controller" runat="server" />
        
        <h4 class="text-info">
            Teacher</h4>
        <br />
        <table class="table container text-left">
            <tr>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButProfile" runat="server" 
                            ImageUrl="~/IMAGES/teachers.png" class="img-rounded imgsz" 
                            onclick="imgButProfile_Click"/>
                        <br />
                        <h6>
                    My Profile
                </td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButLeave" runat="server" ImageUrl="~/IMAGES/leave.png" 
                            class="img-rounded imgsz" onclick="imgButLeave_Click" />
                        <br />
                        <h6>
                    Leave Request
                </td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButTTable" runat="server" 
                            ImageUrl="~/IMAGES/timetable.png" class="img-rounded imgsz" 
                            onclick="imgButTTable_Click" />
                        <br />
                        <h6>
                    Timetable
                </td>
            </tr>
        </table>
        </form>
    </div>

    <script src="js/bootstrap.js"></script>

</body>
</html>
