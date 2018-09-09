Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImportarExcel.Click

        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

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

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

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
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")


        ''Dim extensiones As String = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'Dim extensiones As String = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'Dim directorio As String = "C:\Users\alberto\Documents\proyectos_net\proyectos_basic\escritorio"
        'Dim myStream As Stream = Nothing
        'Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.InitialDirectory = directorio
        'openFileDialog1.Filter = extensiones
        'openFileDialog1.FilterIndex = 2
        'openFileDialog1.RestoreDirectory = True

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        myStream = openFileDialog1.OpenFile()
        '        If (myStream IsNot Nothing) Then
        '            ' Insert code to read the stream here.
        '            Me.lNombre.Text = openFileDialog1.FileName
        '            'Me.lNombre.Text = openFileDialog1.Title
        '            'Dim SR As StreamReader = New StreamReader(openFileDialog1.FileName)
        '            'MessageBox.Show(SR.ReadToEnd())
        '            'SR.Close()
        '            'ImportExcellToDataGridView(openFileDialog1.FileName, Me.dtgwTable)

        '            'Me.ImportExcel(openFileDialog1.FileName, Me.dtgwTable)
        '            Me.ImportExcel3(openFileDialog1.FileName, Me.dtgwTable)
        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        '    Finally
        '        ' Check this again, since we need to make sure we didn't throw an exception on open.
        '        If (myStream IsNot Nothing) Then
        '            myStream.Close()
        '        End If
        '    End Try
        'End If
    End Sub


    Private Sub ImportExcel(ByRef path As String, ByVal Datagrid As DataGridView)

        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter


            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            Datagrid.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Public Function ImportExcellToDataGridView(ByRef path As String, ByVal Datagrid As DataGridView)
        Try
            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            Dim Cmd As New OleDbCommand("Select * From [Hoja1$]")
            Dim Ds As New DataSet
            Dim Da As New OleDbDataAdapter
            Dim Dt As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            Datagrid.Columns.Clear()
            Datagrid.DataSource = Dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function


    Private Sub ImportExcel2(ByRef path As String, ByVal Datagrid As DataGridView)
        Try
            Dim MyConnection As OleDb.OleDbConnection
            Dim Ds As System.Data.DataSet
            Dim MyAdapter As System.Data.OleDb.OleDbDataAdapter
            'Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            'MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Personal\09. Blog\RockType.xls';Extended Properties=Excel 8.0;")
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & path & ";Extended Properties=Excel 8.0;")
            MyAdapter = New System.Data.OleDb.OleDbDataAdapter("Select * from [Hoja1$]", MyConnection)
            Ds = New System.Data.DataSet
            MyAdapter.Fill(Ds)
            Me.dtgwTable.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ImportExcel3(ByRef path As String, ByVal tabla As DataGridView)
        Dim MyConnection As OleDb.OleDbConnection

        Try

            Dim Ds As System.Data.DataSet
            'Dim MyAdapter As System.Data.OleDb.OleDbDataAdapter
            'Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            'MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Personal\09. Blog\RockType.xls';Extended Properties=Excel 8.0;")
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & path & ";Extended Properties=Excel 8.0;")
            'MyAdapter = New System.Data.OleDb.OleDbDataAdapter("Select * from [Hoja1$]", MyConnection)
            Ds = New System.Data.DataSet
            'MyAdapter.Fill(Ds)
            'Me.dtgwTable.DataSource = Ds.Tables(0)
            Dim da As OleDbDataAdapter
            Dim dt As DataTable

            Dim xSheet As String = "Hoja1"
            MyConnection = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & path & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", MyConnection)

            MyConnection.Open()
            da.Fill(Ds, "MyData")
            dt = Ds.Tables("MyData")
            tabla.DataSource = Ds
            tabla.DataMember = "MyData"
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImportExcel33(sender As Object, e As EventArgs)

        Dim tabla As DataGridView
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

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

            xSheet = "Hoja1"
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub

    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

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

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        llenarExcel(dtgwTable)
    End Sub

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function

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
