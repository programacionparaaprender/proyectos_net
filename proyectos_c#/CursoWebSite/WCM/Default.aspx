<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 11px;
        }
        .auto-style3 {
            height: 11px;
            width: 133px;
        }
        .auto-style4 {
            width: 133px;
        }
        .auto-style5 {
            height: 11px;
            width: 252px;
        }
        .auto-style6 {
            width: 252px;
        }
        .auto-style7 {
            height: 206px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style7">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Username</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtUN" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUN" ErrorMessage="Please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPW" ControlToValidate="txtCon" ErrorMessage="Not Match" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Confirm Pasword</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCon" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">E-mail</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEM" runat="server" TextMode="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEM" ErrorMessage="Not E mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6">
                    <asp:Button ID="btnReg" runat="server" Text="Add User" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
