Public Class Cola
    Inherits Objeto
    Dim siguiente As Cola
    Public Sub New(tamano As Integer, x As Integer, y As Integer)
        MyBase.New(tamano, x, y)
        Me.siguiente = Nothing
    End Sub
    Public Sub setxy(x As Integer, y As Integer)
        If (Me.siguiente IsNot Nothing) Then
            Me.siguiente.setxy(Me.x, Me.y)
        End If
        Me.x = x
        Me.y = y
    End Sub
    Public Function verX()
        Return Me.x
    End Function
    Public Function verY()
        Return Me.y
    End Function
    Public Sub meter()
        If (Me.siguiente Is Nothing) Then
            Me.siguiente = New Cola(Me.tamano, Me.x, Me.y)
        Else
            Me.siguiente.meter()
        End If
    End Sub
    Public Function colisiona(obj As Objeto)
        If (Me.interseccion(obj)) Then
            Return True
        ElseIf (Me.siguiente IsNot Nothing) Then
            Return Me.siguiente.colisiona(obj)
        Else
            Return False
        End If
    End Function
    Public Function revision()
        If (Me.siguiente IsNot Nothing) Then
            Return Me.siguiente.colisiona(Me)
        Else
            Return False
        End If
    End Function
    Public Sub dibujar(g As Graphics)
        If (Me.siguiente IsNot Nothing) Then
            Me.siguiente.dibujar(g)
        End If
        g.FillRectangle(New SolidBrush(Color.Blue), Me.x, Me.y, Me.tamano, Me.tamano)
    End Sub
End Class


