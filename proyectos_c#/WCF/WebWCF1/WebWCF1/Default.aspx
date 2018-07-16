<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebWCF1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>

    <div class="jumbotron">
        <button onclick="dowork()" class="btn btn-primary">DoWork</button>
    </div>
    <script type="text/javascript">
        function dowork() {
            //alert("Hello");
            $.ajax({
                url: "Service/Service1.svc/Dowork",
                type: "GET",
                //data: { 'vals': val },
                dataType: "json",
                success: function (result) {
                    alert(result);
                },
                //error: function (request, status, error) {
                //    alert("Error: Could not delete");
                //}
            });
        }
    </script>
</asp:Content>
