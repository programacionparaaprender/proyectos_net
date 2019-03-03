<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebWCF1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>
    <!-- https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.updatepanel?view=netframework-3.5 -->
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
       <div class="jumbotron">
        <button onclick="dowork()" class="btn btn-primary">DoWork</button>
        <button onclick="dosquare()" class="btn btn-primary">DoSquare</button>
        <input type="text" id="squareValue"/>

        <h1>AddValues</h1>
        <input type="text" id="addValue1"/>
        <input type="text" id="addValue2"/>
        <button onclick="doaddvalues()" class="btn btn-primary">DoAddValue</button>
        

    </div>             
       </ContentTemplate>
    </asp:UpdatePanel>


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
        function dosquare() {
            //alert("Hello");
            var value = $('#squareValue').val();
            $.ajax({
                url: "Service/Service1.svc/Dosquare",
                type: "POST",
                data: JSON.stringify(value),
                dataType: "json",
                contentType: "application/json",
                success: function (result) {
                    alert(result);
                },
                error: function (request, status, error) {
                    alert("Error: Could not delete" + error);
                }
            });
        }
        function doaddvalues() {
            //alert("Hello");
            var value1 = $('#addValue1').val();
            var value2 = $('#addValue2').val();
            var addValues = {
                "value1": value1,
                "value2": value2
            };
            $.ajax({
                url: "Service/Service1.svc/DoAddValues",
                type: "POST",
                data: JSON.stringify(addValues),
                dataType: "json",
                contentType: "application/json",
                success: function (result) {
                    alert(result);
                },
                error: function (request, status, error) {
                    alert("Error: Could not delete" + error);
                }
            });
        }
    </script>
</asp:Content>
