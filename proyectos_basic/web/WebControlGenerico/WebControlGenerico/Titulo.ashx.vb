

Imports System.Web
Imports System.Web.Services
Imports System.Web.Script.Serialization
Imports System.IO

Public Class Titulo
    Implements System.Web.IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"

        Try
            Dim strJson As String = New StreamReader(context.Request.InputStream).ReadToEnd()
            Dim objUsr As AddValues = Deserialize(Of AddValues)(strJson)

            If objUsr IsNot Nothing Then
                Dim fullName As String = (objUsr.value1 * objUsr.value2).ToString
                context.Response.Write("Se guardo exitosamente")
            Else
                context.Response.Write("No Data")
            End If

        Catch ex As Exception
            context.Response.Write("Error :" & ex.Message)
        End Try
    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Public Function Deserialize(Of T)(ByVal context As String) As T
        Dim jsonData As String = context
        Dim obj = CType(New JavaScriptSerializer().Deserialize(Of T)(jsonData), T)
        Return obj
    End Function


    Public Class AddValues

        Public _value1 As Integer

        Public _value2 As Integer

        Public Sub New()
            _value1 = 0
            _value2 = 0
        End Sub
        Public Property value1 As String
            Set(value As String)
                _value1 = value
            End Set
            Get
                Return _value1
            End Get
        End Property
        Public Property value2 As String
            Set(value As String)
                _value2 = value
            End Set
            Get
                Return _value2
            End Get
        End Property
    End Class


    Public Class userInfo
        Public _first_name As String
        Public _last_name As String
        Public _qualification As String
        Public _age As String

        Public Property first_name As String
            Set(value As String)
                _first_name = value
            End Set
            Get
                Return _first_name
            End Get
        End Property
        Public Property last_name As String
            Set(value As String)
                _last_name = value
            End Set
            Get
                Return _last_name
            End Get
        End Property
        Public Property qualification As String
            Set(value As String)
                _qualification = value
            End Set
            Get
                Return _qualification
            End Get
        End Property
        Public Property age As String
            Set(value As String)
                _age = value
            End Set
            Get
                Return _age
            End Get
        End Property
    End Class

End Class