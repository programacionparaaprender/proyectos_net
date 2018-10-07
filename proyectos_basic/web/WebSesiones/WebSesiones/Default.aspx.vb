Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = Me.txtUsuario.Text
        Dim pass As String = Me.txtPass.Text
        Session("Usuario") = New Usuario(user, pass)
        Response.Redirect("WebForm1")
    End Sub
End Class