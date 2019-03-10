<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.vb" Inherits="WebControlGenerico._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<ASP:Content ID = "Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--<script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>
    
    <!--<script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.0.js"></script>-->
    <!--https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.fileupload?view=netframework-4.7.2-->
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js"></script>
    <Script>

        function doaddvalues() {
            //alert("Hello");
            var value1 = $('#addValue1').val();
            var value2 = $('#addValue2').val();
            var addValues = {
                "value1": value1,
                "value2": value2
            };
            $.ajax({
                url: "Titulo.ashx",
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

            //$.post('Titulo.ashx', JSON.stringify(addValues))
            // .success(function (response) {
            //     alert(response);
            //     //$("#mypar").html(response.amount);
            // });
            //$.post("Titulo.ashx", function (data) {
            //    alert(data);
            //});
        }

        window.onload = function inicio() {
            ////Funciona

            //var addValues = {
            //    "value1": 1,
            //    "value2": 2
            //};
            //$.get('Titulo2.ashx', addValues)
            // .success(function (response) {
            //     alert(response);
            //     //$("#mypar").html(response.amount);
            // });

            var addValues = {
                "value1": 1,
                "value2": 2
            };
            $.get('Titulo3.ashx', addValues)
             .success(function (response) {
                 alert(response);
                 //$("#mypar").html(response.amount);
             });

        }

    </script>

    
    <div class="jumbotron">
        <button onclick="dowork()" class="btn btn-primary">DoWork</button>
        <button onclick="dosquare()" class="btn btn-primary">DoSquare</button>
        <input type="text" id="squareValue"/>

        <h1>AddValues</h1>
        <input type="text" id="addValue1"/>
        <input type="text" id="addValue2"/>
        <button onclick="doaddvalues()" class="btn btn-primary">DoAddValue</button>
        

    </div>

</asp:Content>
