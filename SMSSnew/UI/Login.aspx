<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SMSSnew._Default" %>

<%@ Register Src="smss_controller.ascx" TagName="smss_controller" TagPrefix="uc2" %>
<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login Page</title>
</head>
<body>
    <div class="container">
        <form id="Form1" class="well span11 text-center" runat="server">
        <uc2:smss_controller ID="smss_controller" runat="server" />
        <br />
        <table class="table container text-left">
            <tr>
                <td>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label">User Name:</asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtUName" runat="server" class="span4" type="username" placeholder="Type your Username..."
                        MaxLength="20" Height="27px" TabIndex="1" />
                </td>
                <td>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtUName">
                You need to type your Username
                    </asp:RequiredFieldValidator>
                    <br />
                    <asp:CustomValidator runat="server" ID="CustomValidator2" ControlToValidate="txtUName"
                        Text="Username length should be more than 6 digits" ClientValidationFunction="clientValidate"
                        Display="Dynamic">
                    </asp:CustomValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtPWord"
                        ValidationExpression="[a-zA-Zs0-9]{6,20}$" AutoPostBack="true" Display="Static"
                        ErrorMessage="Username must contain only Alpha-Numeric Characters" EnableClientScript="False"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label">Password:</asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtPWord" runat="server" class="span4" placeholder="Type your Password..."
                        TextMode="Password" MaxLength="20" Height="27px" TabIndex="2" />
                </td>
                <td>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtPWord">
            You need to type your Password
                    </asp:RequiredFieldValidator>
                    <br />
                    <asp:CustomValidator runat="server" ID="CustomValidator1" ControlToValidate="txtPWord"
                        Text="Password length should be more than 6 digits" ClientValidationFunction="clientValidate"
                        Display="Dynamic">
                    </asp:CustomValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtPWord"
                        ValidationExpression="[a-zA-Zs0-9]{6,20}$" AutoPostBack="true" Display="Static"
                        ErrorMessage="Password must contain only Alpha-Numeric Characters" EnableClientScript="False"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td class="style1" width="50%">
                    <p  align="left" >
                        <asp:Button ID="butLogin" runat="server" OnClick="butLogin_Click1" Text="Login" class="btn btn-primary"
                            TabIndex="3" Width="120px" />
                        <br />
                        <br />
                        <asp:Button ID="butForgotPWord" runat="server" class="btn btn-link" OnClick="butForgotPWord_Click"
                            Text="Did You Forgot Your Password?" TabIndex="5" Width="237px" />
                    </p>
                </td>
            </tr>
        </table>
        </form>
    </div>

    <script src="js/bootstrap.js"></script>

    <script type="text/javascript">
        function clientValidate(sender, args) {
            if (args.Value.length < 6) {
                args.IsValid = false;
            }
        }
    </script>

</body>
</html>
