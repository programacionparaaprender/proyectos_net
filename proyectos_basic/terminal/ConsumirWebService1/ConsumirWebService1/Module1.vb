Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Dim serv1 As New ServicioWeb.DemoSoapClient
        Console.WriteLine($"Ejemplo de Web Service {serv1.HelloWorld}")
        Console.ReadKey()
    End Sub

End Module
