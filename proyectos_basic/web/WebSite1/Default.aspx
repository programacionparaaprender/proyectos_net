<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>


<%@Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>



        </ContentTemplate>

    </asp:UpdatePanel>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" />
    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>

    </div>
    </form>
</body>
</html>
