Public Class Pantalla
    Dim x, y, height, width, tamano As Integer
    Public Sub New()
        'Size(567, 285)
        Me.x = 0
        Me.y = 0
        Me.height = 285
        Me.width = 567
        Me.tamano = 10
    End Sub
    Public Sub mantenerx(snake As Cola)
        If (snake.verX() < 0) Then
            snake.x = Me.width - tamano
        ElseIf (snake.verX() > Me.width - tamano) Then
            snake.x = 0
        End If
    End Sub

    Public Sub mantenery(snake As Cola)

        If (snake.verY() < 0) Then
            snake.y = Me.height - tamano
        ElseIf (snake.verY() > Me.height - tamano) Then
            snake.y = 0
        End If
    End Sub
End Class
