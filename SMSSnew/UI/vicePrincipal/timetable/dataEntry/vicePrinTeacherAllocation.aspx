<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vicePrinTeacherAllocation.aspx.cs"
    Inherits="SMSSnew.UI.vicePrincipal.timetable.dataEntry.vicePrinTeacherAllocation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Teacher Allocation</title>
    <link href="../../../../css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="text-right"><h5>Logout</h5></asp:HyperLink>
        <h4 class="text-info">
            Teacher Allocation</h4>
        <br />
        <table class="table container">
            <tr>
                <td class="Colwidth2">
                    Teacher ID:
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    Subject Type Name:
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
        </table>
        <table class="table container">
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        <span class="label">Grade</span></p>
                </td>
                <td>
                    <span class="label">A</span>
                </td>
                <td>
                    <span class="label">B</span>
                </td>
                <td>
                    <span class="label">C</span>
                </td>
                <td>
                    <span class="label">D</span>
                </td>
                <td>
                    <span class="label">E</span>
                </td>
                <td>
                    <span class="label">F</span>
                </td>
                <td>
                    <span class="label">G</span>
                </td>
                <td>
                    <span class="label">H</span>
                </td>
                <td>
                    <span class="label">I</span>
                </td>
                <td>
                    <span class="label">J</span>
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        6</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox5" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox6" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        7</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox11" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox14" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox16" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        8</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox21" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox23" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox24" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox25" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox26" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox27" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox28" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox29" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox30" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        9</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox31" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox32" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox33" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox34" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox35" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox36" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox37" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox38" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox39" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox40" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        10</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox41" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox42" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox43" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox44" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox45" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox46" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox47" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox48" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox49" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox50" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="Colwidth2">
                    <p class="text-center">
                        11</p>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox51" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox52" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox53" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox54" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox55" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox56" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox57" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox58" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox59" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox60" runat="server" />
                </td>
            </tr>
        </table>
        <table class="table container">
            <tr>
                <td class="Colwidth2">
                </td>
                <td><p class="text-right">
                    <asp:Button ID="Button1" runat="server" Text="ALLOCATE" Font-Bold="True" CssClass="btn btn-success" />
                </p> 
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
>
</html>
