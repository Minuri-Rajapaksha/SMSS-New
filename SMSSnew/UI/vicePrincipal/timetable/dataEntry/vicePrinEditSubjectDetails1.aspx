<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vicePrinEditSubjectDetails1.aspx.cs"
    Inherits="SMSSnew.UI.vicePrincipal.timetable.dataEntry.vicePrinEditSubjectDetails1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edit Subject Details</title>
    <link href="../../../../css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Edit Subject Details</h4>
        <br />
        <table class="table container">
            <tr>
                <td class="Colwidth2">
                    Subject Name:
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    Subject Code:
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="EDIT" Font-Bold="True" CssClass="btn btn-warning" />
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
