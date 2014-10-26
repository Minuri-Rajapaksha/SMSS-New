<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentProfile.aspx.cs"
    Inherits="SMSSnew.UI.profiles.StudentProfile" %>

<link href="../../css/StyleSheet.css" rel="stylesheet" type="text/css" />

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>My Profile Student</title>
</head>

<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            My Profile - Student</h4>
        <br />
        <table class="table container text-left">
            <tr>
                <td class="Colwidth">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/IMAGES/student.png" class="img-rounded imgsz" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    Name with Initials:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    Grade:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    Class:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    Address:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    Telephone No:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    E-mail:
                </td>
                <td>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="Colwidth">
                    <br />
                    To Change Username, Password:
                </td>
                <td>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Click Here" CssClass="btn btn-primary"
                        PostBackUrl="~/ChangeUnamePwrd.aspx" />
                </td>
            </tr>
        </table>
        </form>
    </div>

    <script src="js/bootstrap.js"></script>

</body>
</html>
