<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vicePrinTimetable.aspx.cs"
    Inherits="SMSSnew.UI.vicePrincipal.timetable.vicePrinTimetable" %>

<%@ Register Src="../../smss_controller.ascx" TagName="smss_controller" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Timetable</title>
    <link href="../../../css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <uc1:smss_controller ID="smss_controller1" runat="server" />
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Timetable</h4>
        <br />
        <table class="table container">
            <tr>
                <asp:Image ID="Image3" runat="server" />
                <td>
                    <br />
                    <center>
                        <asp:Image ID="Image1" runat="server" CssClass="img-rounded imgsz" ImageUrl="~/IMAGES/ad.png" />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Create Timetable" CssClass="btn btn-link"
                            Font-Bold="True" onclick="Button1_Click" /></center>
                    <br />
                </td>
                <td>
                    <br />
                    <center>
                        <asp:Image ID="Image2" runat="server" CssClass="img-rounded imgsz" ImageUrl="~/IMAGES/viw.png" />
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="View Timetable" CssClass="btn btn-link"
                            Font-Bold="True" onclick="Button2_Click" /></center>
                    <br />
                </td>
                <td>
                    <br />
                    <center>
                        <asp:Image ID="Image4" runat="server" CssClass="img-rounded imgsz" ImageUrl="~/IMAGES/del.png" />
                        <br />
                        <asp:Button ID="Button3" runat="server" Text="Delete Timetable" CssClass="btn btn-link"
                            Font-Bold="True" /></center>
                    <br />
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
