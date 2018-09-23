Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Demo
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString

        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myReader As SqlDataReader = Nothing
            Dim strCadSQL As String = "SELECT * FROM dbo.usuarios"
            Dim myCommand As SqlCommand = New SqlCommand(strCadSQL, conexion)
            myReader = myCommand.ExecuteReader()
            Console.WriteLine("Datos de tabla")

            While myReader.Read()
                Return myReader.GetString(1) & " " + myReader.GetString(2)
            End While

            Console.WriteLine("  ...OK. Operacion exitosa!")
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Function

End Class