Module Module1

    Sub Main()
        Dim correo As CorreoOutlook
        correo = New CorreoOutlook
        correo.enviarCorreo()
        Console.ReadKey()
    End Sub

End Module
