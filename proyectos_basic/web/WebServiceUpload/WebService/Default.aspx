<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .botonUpload {
            color:white;
            background-color:gray;
            font-family:Arial;
            font-weight:bold;
            width:100px;
            padding: 5px 5px 5px 5px;
            font-size:14px;
            background:url('icons8-attach-10.png') no-repeat;
            background-position-x:0%;
            background-position-y:0%;
            background-position-x:20%;
            background-position-y:20%;
            text-align:center;
        }

    </style>
    
    <script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>
    <!--<script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.0.js"></script>-->
    <!--https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.fileupload?view=netframework-4.7.2-->
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js"></script>
    <script runat="server">

        Sub UploadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Dim savePath As String '= "/File/" ' "..\WebService\File"

            'If FileUpload1.HasFile Then
                Dim fileName As String = FileUpload1.FileName
                'savePath += fileName
                'FileUpload1.SaveAs(savePath)
                FileUpload1.SaveAs(Server.MapPath("~/File/"+fileName))
		label1.Text = "Your file was saved as " & fileName
            'Else
            '    label1.Text = "You did not specify a file to upload."
            'End If


        End Sub
</script>
    
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
            <asp:FileUpload CssClass="botonUpload" ID="FileUpload1" runat="server" />
            <asp:label ID="label1" runat="server"></asp:label>
            <asp:Button id="UploadButton" 
                  Text="Upload file"
                    OnClick="UploadButton_Click"
                    runat="server">
            </asp:Button>

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
                error: function (request, status, error) {
                    alert("Error: Could not delete");
                }
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
