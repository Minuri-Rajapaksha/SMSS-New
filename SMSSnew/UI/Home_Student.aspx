<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_Student.aspx.cs" Inherits="SMSSnew.UI.Home_Student" %>

<%@ Register Src="smss_controller.ascx" TagName="smss_controller" TagPrefix="uc1" %>
<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Student page</title>
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <uc1:smss_controller ID="smss_controller" runat="server" />
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Student</h4>
        <br />
        <table class="table container text-left">
            <tr>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButProfile" runat="server" 
                            ImageUrl="~/IMAGES/student.png"  class="img-rounded imgsz" 
                            onclick="ImageButton1_Click"/>
                        <br />
                        <h6>
                    My Profile
                </td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButTTable" runat="server" 
                            ImageUrl="~/IMAGES/timetable.png"  class="img-rounded imgsz" 
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
