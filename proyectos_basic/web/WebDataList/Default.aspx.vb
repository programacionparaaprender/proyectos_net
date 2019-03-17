
Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Function Enlaces() As ICollection
        Dim dt As DataTable = New DataTable()
        Dim dr As DataRow
        dt.Columns.Add(New DataColumn("Texto", GetType(String)))
        dt.Columns.Add(New DataColumn("Enlace", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(String)))
        For i As Integer = 0 To 9 - 1
            dr = dt.NewRow()
            dr("Texto") = "Texto" & i.ToString
            dr("Enlace") = "www.youtube.com"
            dr("Imagen") = "img/img.jpg"
            dt.Rows.Add(dr)
        Next

        Dim dv As DataView = New DataView(dt)
        Return dv
    End Function


    Private Function CreateDataSource() As ICollection
        Dim dt As DataTable = New DataTable()
        Dim dr As DataRow
        dt.Columns.Add(New DataColumn("IntegerValue", GetType(Int32)))
        dt.Columns.Add(New DataColumn("StringValue", GetType(String)))
        dt.Columns.Add(New DataColumn("CurrencyValue", GetType(Double)))
        dt.Columns.Add(New DataColumn("ImageValue", GetType(String)))

        For i As Integer = 0 To 9 - 1
            dr = dt.NewRow()
            dr(0) = i
            dr(1) = "Description for item " & i.ToString()
            dr(2) = 1.23 * (i + 1)
            dr(3) = "Image" & i.ToString() & ".jpg"
            dt.Rows.Add(dr)
        Next

        Dim dv As DataView = New DataView(dt)
        Return dv
    End Function

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ItemsList.DataSource = CreateDataSource()
            ItemsList.DataBind()
            DataList1.DataSource = Me.Enlaces
            DataList1.DataBind()
        End If
    End Sub

End Class
