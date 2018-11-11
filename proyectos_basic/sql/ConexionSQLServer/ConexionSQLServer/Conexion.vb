Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Private cadena As String = "Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True"
    Public Function MostrarLista() As List(Of Usuario)
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString
        Dim lista As New List(Of Usuario)
        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myReader As SqlDataReader = Nothing
            Dim strCadSQL As String = "select * from fn_mostrarUsuarios(0)"
            Dim myCommand As SqlCommand = New SqlCommand(strCadSQL, conexion)
            myReader = myCommand.ExecuteReader()
            Console.WriteLine("Datos de tabla")

            While myReader.Read()
                Dim usuario As New Usuario()
                usuario.Id = myReader.GetInt32(0)
                usuario.Usuario = myReader.GetString(1)
                usuario.Pass = myReader.GetString(2)
                lista.Add(usuario)
            End While
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
        MostrarLista = lista
    End Function

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

    Public Function MostrarEstructuraAdapter() As DataTable
        Dim cadenaConexion As String = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString
        Dim dt As New DataTable
        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myReader As SqlDataReader = Nothing
            Dim strCadSQL As String = "SELECT * FROM dbo.usuarios"
            'Dim myCommand As New SqlCommand '= New SqlCommand(strCadSQL, conexion)
            'myCommand.CommandText = "SELECT * FROM dbo.usuarios"
            '.CommandType = CommandType.StoredProcedure
            '.Connection = conexion
            Dim dataadapter As New SqlDataAdapter(strCadSQL, conexion)
            dataadapter.Fill(dt)
            'myCommand.Parameters.AddWithValue("@id", 0)
            'Dim myCommand As SqlCommand = New SqlCommand(strCadSQL, conexion)
            ''myReader = myCommand.ExecuteReader()
            ''myReader = myCommand.ExecuteReader()
            ''Console.WriteLine("Datos de tabla")

            ''While myReader.Read()
            ''    Console.WriteLine(myReader.GetString(1) & " " + myReader.GetString(2))
            ''End While

            'Console.WriteLine("  ...OK. Operacion exitosa!")
            conexion.Close()
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
        MostrarEstructuraAdapter = dt
    End Function

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
End Class
