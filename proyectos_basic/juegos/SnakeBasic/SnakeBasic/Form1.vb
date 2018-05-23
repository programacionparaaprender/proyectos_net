Public Class Form1
    Dim cabeza As Cola
    Dim comida As Comida
    Dim pantalla As Pantalla
    Dim g As Graphics
    Dim tamano As Integer

    Dim ejex As Boolean
    Dim ejey As Boolean
    Dim xdir As Integer
    Dim ydir As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.ejex = True
        Me.ejey = True
        Me.xdir = 0
        Me.ydir = 0

        Me.tamano = 10
        cabeza = New Cola(10, 10, 10)
        comida = New Comida(Me.tamano)
        pantalla = New Pantalla()
        g = Me.canvas.CreateGraphics()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub movimiento()
        Dim nx As Integer
        nx = cabeza.verX() + xdir
        Dim ny As Integer
        ny = cabeza.verY() + ydir
        cabeza.setxy(nx, ny)

        If (cabeza.colisiona(comida)) Then
            comida.colocar()
            cabeza.meter()

        End If

        If (cabeza.revision()) Then
            '//console.log("toco")
        End If
        If (xdir <> 0) Then
            pantalla.mantenerx(cabeza)
        End If
        If (ydir <> 0) Then
            pantalla.mantenery(cabeza)

        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim cod As Keys
        cod = e.KeyCode
        If (ejex) Then
            If (cod = Keys.Left) Then
                xdir = -tamano
                ydir = 0
                ejex = False
                ejey = True
            ElseIf (cod = Keys.Right) Then
                xdir = tamano
                ydir = 0
                ejex = False
                ejey = True
            End If
        End If
            If (ejey) Then
            If (cod = Keys.Up) Then
                ydir = -tamano
                xdir = 0
                ejey = False
                ejex = True
            ElseIf (cod = Keys.Down) Then
                ydir = tamano
                xdir = 0
                ejey = False
                ejex = True
            End If

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles bucle.Tick
        g.Clear(Color.White)
        Me.movimiento()
        cabeza.dibujar(g)
        comida.dibujar(g)
    End Sub
End Class
