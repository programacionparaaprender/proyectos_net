Public Class Comida
    Inherits Objeto
    Public Sub New(tamano As Integer)
        MyBase.New(tamano)
        Me.colocar()
    End Sub
    Public Sub colocar()
        Me.x = Me.generarx()
        Me.y = Me.generary()
    End Sub
    Public Function generarx()
        'entre 0 y 500
        'Size(567, 285)
        Dim tam As Integer = 467 / 10
        Dim random As Random = New Random()
        Dim num As Integer = random.Next(0, tam) * 10
        Return num
    End Function
    Public Function generary()
        'entre 0 y 500
        'Size(567, 285)
        Dim tam As Integer = 285 / 10
        Dim random As Random = New Random()
        Dim num As Integer = random.Next(0, tam) * 10
        Return num
    End Function
    Public Sub dibujar(g As Graphics)
        Dim bluePen As Pen = New Pen(Color.Blue, 3)
        g.DrawRectangle(bluePen, Me.x, Me.y, Me.tamano, Me.tamano)
    End Sub
End Class
