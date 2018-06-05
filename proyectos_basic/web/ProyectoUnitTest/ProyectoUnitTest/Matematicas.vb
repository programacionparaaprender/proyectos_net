Imports Microsoft.Bot.Connector

Public Class Matematicas
    Public Shared Function suma(sumando1 As Integer, sumando2 As Integer) As Integer
        Return sumando1 + sumando2
    End Function

    Public Shared Function division(dividendo As Integer, divisor As Integer) As Integer
        If divisor = 0 Then
            Throw New DivideByZeroException("No se puede dividir entre cero")
        End If
        Return dividendo / divisor
    End Function
End Class
