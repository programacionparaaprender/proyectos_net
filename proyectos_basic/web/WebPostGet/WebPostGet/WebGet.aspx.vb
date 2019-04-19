Public Class WebGet
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack = False) Then
            Dim nombre As String
            nombre = Request.QueryString("fname")
            Dim apellido As String
            apellido = Request.QueryString("lname")
        End If
    End Sub

End Class