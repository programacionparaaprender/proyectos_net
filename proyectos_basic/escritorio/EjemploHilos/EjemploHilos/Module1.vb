Imports System.Threading

Module Module1

    'Sub que ejecutarán los hilos
    Public Sub MiSub(ByVal Parametro As Object)
        Try
            Randomize()
            Do
                Dim iDormir As Integer = CInt(3000 * Rnd()) 'Valor random entre 0 y 3000
                Console.WriteLine("{0} sleep({1})", Parametro, iDormir)
                Thread.Sleep(iDormir) 'Me bloqueo entre 0 y 3 segundos
            Loop
        Catch ex As ThreadAbortException
            Console.WriteLine("{0} Abortado", Parametro)
        End Try
    End Sub

    'Sub principal
    Sub Main()
        Dim hilo1 As New Thread(AddressOf MiSub) 'Crear el hilo 1
        Dim hilo2 As New Thread(AddressOf MiSub) 'Crear el hilo 2

        Console.WriteLine("Ejecutando hilos a abortar en 6 segudos...")
        hilo1.Start("hilo 1 ")                   'Comenzar ejecución de hilo 1
        Thread.Sleep(500)                        'Me Bloqueo 500 ms
        hilo2.Start(" hilo 2")                   'Comenzar ejecución de hilo 2
        Thread.Sleep(6000)                       'Me bloqueo 6 segundos

        hilo1.Abort()                            'Abortar al hilo 1
        hilo2.Abort()                            'Abortar al hilo 2

        'Esperar a que realmente mueran los hilos
        While hilo1.IsAlive Or hilo2.IsAlive
        End While

        Console.WriteLine("Abortados")
        Console.ReadKey()
    End Sub
End Module