<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="SMSSnew.UI.ForgotPassword" %>
<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Forgot Password Page</title>
</head>

<body>
    
  <div class="container">
    
    <form id="Form1" class="well span11 text-center" runat="server">
    
    <h4 class="text-info">Forgot Password</h4><br />
    
	<table class="table container text-left">
	
	<tr>
	<td class="Colwidth"><br />Question:
    </td>
	<td><br />
        <asp:TextBox ID="txtQuestion" runat="server" ReadOnly="True" Width="223px" 
            Height="26px"></asp:TextBox>
    </td>       
    </tr>
    
    <tr>
	<td class="Colwidth"><br />Type your answer:
    </td>
	<td><br />
        <asp:TextBox ID="txtAnswer" runat="server" class="span4" 
            placeholder="Type your answer..." Width="222px" Height="26px" ></asp:TextBox>
    </td>       
    </tr>
       
    <tr>
	<td class="Colwidth"><br />
        <asp:Button ID="butEnter" runat="server" Text="ENTER" class="btn btn-primary"
            onclick="butEnter_Click" />
    </td>
	<td><br />
       <asp:Button ID="butReset" runat="server" Text="RESET"  class="btn btn-primary"/> 
    </td>       
    </tr> 
		
	</table>
	
	</form>	

	</div>
  
    <script src="js/bootstrap.js"></script>
    
</body>
</html>
