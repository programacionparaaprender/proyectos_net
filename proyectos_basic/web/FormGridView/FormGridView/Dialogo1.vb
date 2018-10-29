Imports System.Windows.Forms

Public Class Dialogo1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Public Sub setText1(texto As String)
        Me.TextBox1.Text = texto
    End Sub
    Public Sub setText2(texto As String)
        Me.TextBox2.Text = texto
    End Sub
    Public Function getText1()
        getText1 = Me.TextBox1.Text
    End Function
    Public Function getText2()
        getText2 = Me.TextBox2.Text
    End Function
End Class
