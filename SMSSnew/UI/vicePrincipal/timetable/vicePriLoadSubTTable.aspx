<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vicePriLoadSubTTable.aspx.cs"
    Inherits="SMSSnew.UI.vicePriLoadSubTTable" %>

<link href="../../css/StyleSheet.css" rel="stylesheet" type="text/css" />

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="css/StyleSheet.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="well span11 text-center">
        <h4 class="text-info">
            Requested Leaves</h4>
        <table width="100%" class="table container text-left">
            <tr>
                <td>
                    <telerik:RadGrid ID="RadGrid1" runat="server" Skin="WebBlue">
                        <MasterTableView>
                            <RowIndicatorColumn Visible="False">
                                <HeaderStyle Width="20px"></HeaderStyle>
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Visible="False" Resizable="False">
                                <HeaderStyle Width="20px"></HeaderStyle>
                            </ExpandCollapseColumn>
                            <EditFormSettings>
                                <PopUpSettings ScrollBars="None"></PopUpSettings>
                            </EditFormSettings>
                        </MasterTableView>
                    </telerik:RadGrid>
                </td>
            </tr>
        </table>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        </form>
    </div>
</body>
</html>
