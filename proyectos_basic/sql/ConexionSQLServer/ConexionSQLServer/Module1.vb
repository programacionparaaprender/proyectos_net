Imports System.Configuration
Imports System.Data.SqlClient

Module Module1
    Dim cadena As String = "Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True"
    Sub Main()
        MostrarEstructuraProcedimiento()
        'MostrarEstructuraFuncion()
        'insertarProcedure()
        Console.ReadKey()
    End Sub
    Public Sub MostrarEstructuraProcedimiento()
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString

        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myReader As SqlDataReader = Nothing
            'Dim strCadSQL As String = "pa_mostrarUsuarios"
            'Dim myCommand As SqlCommand '= New SqlCommand(strCadSQL, conexion)
            Dim myCommand As SqlCommand = New SqlCommand
            myCommand.CommandText = "pa_mostrarUsuarios"
            myCommand.CommandType = CommandType.StoredProcedure
            myCommand.Connection = conexion
            myCommand.Parameters.AddWithValue("@id", 0)
            'Dim myCommand As SqlCommand = New SqlCommand(strCadSQL, conexion)
            myReader = myCommand.ExecuteReader()
            Console.WriteLine("Datos de tabla")

            While myReader.Read()
                Console.WriteLine(myReader.GetString(1) & " " + myReader.GetString(2))
            End While

            Console.WriteLine("  ...OK. Operacion exitosa!")
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Sub
    Public Sub MostrarEstructuraFuncion()
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString

        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myReader As SqlDataReader = Nothing
            Dim strCadSQL As String = "select * from fn_mostrarUsuarios(0)"
            'Dim myCommand As SqlCommand '= New SqlCommand(strCadSQL, conexion)
            'myCommand.CommandText = "select * from fn_mostrarUsuarios"
            'myCommand.CommandType = CommandType.StoredProcedure
            'myCommand.Connection = conexion
            Dim myCommand As SqlCommand = New SqlCommand(strCadSQL, conexion)
            myReader = myCommand.ExecuteReader()
            Console.WriteLine("Datos de tabla")

            While myReader.Read()
                Console.WriteLine(myReader.GetString(1) & " " + myReader.GetString(2))
            End While

            Console.WriteLine("  ...OK. Operacion exitosa!")
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Sub

    Public Sub MostrarEstructura()
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
                Console.WriteLine(myReader.GetString(1) & " " + myReader.GetString(2))
            End While

            Console.WriteLine("  ...OK. Operacion exitosa!")
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Sub
    Private Sub insertarProcedure()
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString
        Dim usuario As String = "ejemplo"
        Dim pass As String = "ejemplo123"

        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim consulta As String = "INSERT INTO Departamento (Nombre,Telefono) Values(@Nombre,@Telefono)"
            Dim comando As SqlCommand = New SqlCommand '(consulta, conexion)
            'Dim myCommand As SqlCommand '= New SqlCommand(strCadSQL, conexion)
            comando.CommandText = "proc_insertar_usuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion

            comando.Parameters.AddWithValue("@nombre", usuario)
            comando.Parameters.AddWithValue("@pass", pass)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch __unusedException1__ As Exception
            Console.WriteLine("Error")
        End Try
    End Sub
    Private Sub insertar()
        Dim nombre As String = "Electronica"
        Dim telefono As String = "02812344561"

        Try
            Dim conexion As SqlConnection = New SqlConnection(cadena)
            conexion.Open()
            Dim consulta As String = "INSERT INTO Departamento (Nombre,Telefono) Values(@Nombre,@Telefono)"
            Dim comando As SqlCommand = New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", nombre)
            comando.Parameters.AddWithValue("@Telefono", telefono)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch __unusedException1__ As Exception
            Console.WriteLine("Error")
        End Try
    End Sub
End Module
