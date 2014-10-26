<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vicePrinEditSubjectDetails2.aspx.cs"
    Inherits="SMSSnew.UI.vicePrincipal.timetable.dataEntry.vicePrinEditSubjectDetails2" %>

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
                    Subject Weight:
                </td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    Total Slots:
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label1" runat="server" Text="6"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label2" runat="server" Text="7"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label3" runat="server" Text="8"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label4" runat="server" Text="9"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label5" runat="server" Text="10"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox5" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                </td>
                <td class="Colwidth3">
                    <asp:Label ID="Label6" runat="server" Text="11"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox6" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="span2"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="table container">
            <tr>
                <td class="Colwidth2">
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="APPLY CHANGES" CssClass="btn btn-warning"
                        Font-Bold="True" Width="153px" />
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
