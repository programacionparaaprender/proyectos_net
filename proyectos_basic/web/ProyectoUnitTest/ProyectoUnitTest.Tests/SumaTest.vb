Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SumaTest
    <TestMethod()> Public Sub suma_ValoresValidos()
        'Arrange o Planteamiento
        Const sumando1 As Integer = 3
        Const sumando2 As Integer = 5
        Const esperado As Integer = 8

        'Act o Prueba
        Dim actual As Integer = Matematicas.suma(sumando1, sumando2)

        'Assert o Afirmación
        Assert.AreEqual(esperado, actual)
    End Sub
End Class
