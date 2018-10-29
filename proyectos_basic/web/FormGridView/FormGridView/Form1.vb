﻿Imports System.Data.SqlClient

Public Class Form1
    Private dt As New DataTable
    Private dr As DataRow
    Private campoSeleccionado As Integer = 0
    Private Sub eliminarProcedure(row As DataRow)
        Dim cadenaConexion As String = "Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True"
        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim comando As SqlCommand = New SqlCommand
            comando.CommandText = "pa_eliminar_usuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            comando.Parameters.AddWithValue("@id", row("id"))
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try
    End Sub
    Private Sub insertarProcedure(row As DataRow)
        Dim cadenaConexion As String = "Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True"
        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim comando As SqlCommand = New SqlCommand '(consulta, conexion)
            comando.CommandText = "proc_insertar_usuario2"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            comando.Parameters.AddWithValue("@id", row("id"))
            comando.Parameters.AddWithValue("@nombre", row("nombre"))
            comando.Parameters.AddWithValue("@pass", row("pass"))
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try
    End Sub
    Public Sub MostrarEstructuraProcedimiento()
        Dim cadenaConexion As String = "Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True" 'ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString
        Try
            Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
            conexion.Open()
            Dim myCommand As SqlCommand = New SqlCommand
            myCommand.CommandText = "pa_mostrarUsuarios"
            myCommand.CommandType = CommandType.StoredProcedure
            myCommand.Connection = conexion
            myCommand.Parameters.AddWithValue("@id", 0)
            Dim adap As New SqlDataAdapter(myCommand)
            adap.Fill(dt)
            Me.DataGridView1.DataSource = dt
            conexion.Close()
        Catch e As Exception
            MsgBox(e.ToString())
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialogo1 As New Dialogo1
        dialogo1.ShowDialog()
        If dialogo1.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Dim row As DataRow = dt.NewRow
            row("id") = 0
            row("nombre") = dialogo1.TextBox1.Text
            row("pass") = dialogo1.TextBox2.Text
            insertarProcedure(row)
            'dt.Rows.Add(row)
            Refresca()
        End If

    End Sub
    Private Sub Refresca()
        MostrarEstructuraProcedimiento()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEstructuraProcedimiento()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dr = Me.dt.Rows(e.RowIndex)
        campoSeleccionado = e.RowIndex
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Me.campoSeleccionado = 0 Then
            'MsgBox("Ya se selecciono campo")
            Dim dialogo1 As New Dialogo1
            dialogo1.setText1(dr("nombre"))
            dialogo1.setText2(dr("pass"))
            dialogo1.ShowDialog()

            If dialogo1.DialogResult = System.Windows.Forms.DialogResult.OK Then
                dr("nombre") = dialogo1.getText1
                dr("pass") = dialogo1.getText2
                Me.insertarProcedure(dr)
                Refresca()
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not Me.campoSeleccionado = 0 Then
            Dim dialogo1 As New Dialogo1
            Me.eliminarProcedure(dr)
            Me.Refresca()
        End If
    End Sub
End Class