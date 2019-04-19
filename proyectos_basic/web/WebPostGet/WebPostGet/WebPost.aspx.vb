Public Class WebPost
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack = True) Then
            Dim nombre As String
            nombre = Request.Form("nombre")
            Dim apellido As String
            apellido = Request.Form("apellido")
        End If
    End Sub

End Class