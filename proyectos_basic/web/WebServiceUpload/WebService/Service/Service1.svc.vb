' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports System.ServiceModel.Activation
Imports System.Configuration
Imports System.Data.SqlClient
Imports WebService

<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class Service1
    Implements IService1



    Private Function IService1_DoWork() As String Implements IService1.DoWork
        Return "Hello REST WCF Service :)"
    End Function

    Private Function IService1_DoAddValues(AddValues As AddValues) As Integer Implements IService1.DoAddValues
        Return AddValues.value1 + AddValues.value2
    End Function

    Private Function IService1_DoSquare(value As Integer) As Integer Implements IService1.DoSquare
        Return value * value
    End Function
End Class

<DataContract>
Public Class AddValues
    <DataMember>
    Public Property value1 As Integer
    <DataMember>
    Public Property value2 As Integer

    Public Sub New()
        value1 = 0
        value2 = 0
    End Sub
End Class


