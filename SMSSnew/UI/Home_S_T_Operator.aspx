<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_S_T_Operator.aspx.cs"
    Inherits="SMSSnew.UI.Home_S_T_Operator" %>

<%@ Register Src="smss_controller.ascx" TagName="smss_controller" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Substitute Teacher Operator Page</title>
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <uc1:smss_controller ID="smss_controller" runat="server" />
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Substitute Teacher Operator</h4>
        <br />
        <table class="table container text-left">
            <tr>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButProfile" runat="server" ImageUrl="~/IMAGES/operator.png"
                            class="img-rounded imgsz" onclick="imgButProfile_Click" />
                        <br />
                        <h6>
                    My Profile
                </td>
                <td>
                    <center>
                        <asp:ImageButton ID="imgButSubTchr" runat="server" ImageUrl="~/IMAGES/relief.png"
                            class="img-rounded imgsz" />
                        <br />
                        <h6>
                    Substitute Teacher
                </td>
            </tr>
        </table>
        </form>
    </div>

    <script src="js/bootstrap.js"></script>

</body>
</html>
