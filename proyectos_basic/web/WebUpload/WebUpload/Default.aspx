<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebUpload._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js"></script>
    <script runat="server">

        Sub UploadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Dim savePath As String = "/File/" ' "..\WebService\File"

            'If FileUpload1.HasFile Then
            Dim fileName As String = FileUpload1.FileName
            'savePath += fileName
            'FileUpload1.SaveAs(savePath)
            FileUpload1.SaveAs(Server.MapPath("~/File/" + fileName))
            label1.Text = "Your file was saved as " & fileName
            'Else
            '    label1.Text = "You did not specify a file to upload."
            'End If


        End Sub
</script>

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">

    
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
            <asp:FileUpload CssClass="botonUpload" ID="FileUpload1" runat="server" />
            <asp:label ID="label1" runat="server"></asp:label>
            <asp:Button id="UploadButton" 
                  Text="Upload file"
                    OnClick="UploadButton_Click"
                    runat="server">
            </asp:Button>


            <h2>Getting Started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
