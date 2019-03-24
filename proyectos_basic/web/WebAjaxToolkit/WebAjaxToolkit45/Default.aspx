<%@ Page Title="Home Page" Langua
ge="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebAjaxToolkit45._Default" %>

<%@Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div></div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>



        </ContentTemplate>

    </asp:UpdatePanel>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
