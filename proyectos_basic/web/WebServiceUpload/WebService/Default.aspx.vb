Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub FileUpload1_Disposed(sender As Object, e As EventArgs) Handles FileUpload1.Disposed
        Me.TextBox1.Text = FileUpload1.FileName
    End Sub
End Class