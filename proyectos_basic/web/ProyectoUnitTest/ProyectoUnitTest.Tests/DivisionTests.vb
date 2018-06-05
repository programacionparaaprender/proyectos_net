Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class DivisionTests

    <TestMethod()>
    <ExpectedException(TypeOf (DivideByZeroException))>
    Public Sub divisionDivideEntreCero()

        'Arrange o Planteamiento
        Const dividendo As Integer = 8
        Const divisor As Integer = 0
        Const esperado As Integer = 8
        'Act o Prueba
        Dim actual As Integer = Matematicas.division(dividendo, divisor)

        'Assert o Excepción
        Assert.AreEqual(esperado, actual)
    End Sub
End Class