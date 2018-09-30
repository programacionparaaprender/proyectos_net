Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim myFileDialog As New OpenFileDialog()
        'Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                'da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                Dim part1 As String = "SELECT hoja1.A,hoja1.B,hoja2.E FROM [Hoja1$] As hoja1"
                Dim part2 As String = "inner join [Hoja2$] As hoja2 on hoja1.D=hoja2.D"
                Dim part3 As String = ""
                Dim part As String = part1 + part2
                da = New OleDbDataAdapter(part, conn)
                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                Me.dtgwTable.DataSource = ds
                Me.dtgwTable.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarExcel.Click
        Dim objConn As OleDbConnection
        Dim oleDA As OleDbDataAdapter
        Dim ds As DataSet

        Dim myFileDialog As New OpenFileDialog()
        'Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim FileName As String = myFileDialog.FileName.ToString
            Try
                'Create a OLEDB connection for Excel file 
                Dim connectionString As String = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"""
                objConn = New OleDbConnection(connectionString)

                Dim part1 As String = "SELECT hoja1.A,hoja1.B,hoja2.E FROM [Hoja1$] As hoja1"
                Dim part2 As String = " inner join [Hoja2$] As hoja2 on hoja1.D=hoja2.D"
                Dim part3 As String = ""
                Dim part As String = part1 + part2

                oleDA = New OleDbDataAdapter(part, objConn)
                ds = New DataSet()
                'Fill the Data Set 
                oleDA.Fill(ds)
                'Set DataSource of DataGridView 
                Me.dtgwTable.DataSource = ds.Tables(0)
                ds.Dispose()
                oleDA.Dispose()
                objConn.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGuardarDB_Click(sender As Object, e As EventArgs) Handles btnGuardarDB.Click
        Dim datatable As DataTable = dtgwTable.DataSource

        Try

            'Para la cadena de conexion te guias de este enlace http://www.connectionstrings.com/sql-server-2008
            Using conexion As New SqlConnection("Data Source=INSTANCIA_DE_TU_BD;Initial Catalog=TEST;User ID=TU_USUARIO;Password=TU_PASSWORD")

                'Recorremos el Datagridview
                For Each fila As DataRowView In dtgwTable.Rows


                    'Por ejemplo si tu datagridview posee 3 columnas, tendría la siguiente estructura
                    Dim cmd As New SqlCommand("insert into TUTABLA values(@parametro1,@parametro2,@parametro3)", conexion)
                    'El comando recibe los parametros, Columna 1
                    cmd.Parameters.Add("@parametro1", SqlDbType.VarChar, 20).Value = fila.Item(0).ToString()
                    'El comando recibe los parametros, Columna 2
                    cmd.Parameters.Add("@parametro2", SqlDbType.Int).Value = Convert.ToInt32(fila.Item(1).ToString())
                    'El comando recibe los parametros, Columna 3
                    cmd.Parameters.Add("@parametro3", SqlDbType.DateTime).Value = Convert.ToDateTime(fila.Item(2).ToString())

                    'Abrimos conexion
                    conexion.Open()

                    'Ejecutamos el comando
                    cmd.ExecuteNonQuery()

                    'Cerramos conexion
                    conexion.Close()

                Next

            End Using

        Catch ex As Exception
            'Anunciamos el error
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
