Public Class Objeto
    Public x, y As Integer
    Public tamano As Integer
    Public Sub New(tamano As Integer, x As Integer, y As Integer)
        Me.x = x
        Me.y = y
        Me.tamano = tamano
    End Sub
    Public Sub New(tamano As Integer)
        Me.x = 0
        Me.y = 0
        Me.tamano = tamano
    End Sub
    Function interseccion(obj As Objeto)
        Dim difx As Integer
        difx = Math.Abs(x - obj.x)
        Dim dify As Integer
        dify = Math.Abs(y - obj.y)
        If (difx >= 0 And difx < tamano And dify >= 0 And dify < tamano) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
