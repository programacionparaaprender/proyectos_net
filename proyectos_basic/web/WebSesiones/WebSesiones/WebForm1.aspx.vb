Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("Usuario") = New Usuario(user, pass)
        Dim usuario As Usuario = Session("Usuario")
        Me.Label1.Text = usuario.Username
    End Sub

End Class