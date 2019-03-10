Imports System.Web
Imports System.Web.Services
Imports System.Web.Script.Serialization
Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Json


Public Class Titulo3
    Implements System.Web.IHttpHandler


    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Dim dictionary As New Dictionary(Of String, AddValues)


        ' Add 4 entries.
        dictionary.Add("bird", New AddValues(1, 2))
        dictionary.Add("frog", New AddValues(1, 3))
        dictionary.Add("snake", New AddValues(1, 4))
        dictionary.Add("fish", New AddValues(1, 5))

        Dim ms As MemoryStream = New MemoryStream()
        Dim ser As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(Dictionary(Of String, AddValues)))
        ser.WriteObject(ms, dictionary)
        Dim json As Byte() = ms.ToArray()
        ms.Close()

        context.Response.Write(Encoding.UTF8.GetString(json, 0, json.Length))


        'Dim lista As AddValues = New AddValues(35, 42)
        'Dim ms As MemoryStream = New MemoryStream()
        'Dim ser As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(AddValues))
        'ser.WriteObject(ms, user)
        'Dim json As Byte() = ms.ToArray()
        'ms.Close()

        'context.Response.Write(Encoding.UTF8.GetString(json, 0, json.Length))



        'If objUsr IsNot Nothing Then
        '    Dim fullName As String = objUsr.first_name & " " + objUsr.last_name
        '    Dim age As String = objUsr.age
        '    Dim qua As String = objUsr.qualification
        '    context.Response.Write(String.Format("Name :{0} , Age={1}, Qualification={2}", fullName, age, qua))
        'Else
        '    context.Response.Write("No Data")
        'End If


    End Sub



    Public Function Deserialize(Of T)(ByVal context As String) As T
        Dim jsonData As String = context
        Dim obj = CType(New JavaScriptSerializer().Deserialize(Of T)(jsonData), T)
        Return obj
    End Function

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Public Class AddValues
        Public _value1 As Integer
        Public _value2 As Integer

        Public Sub New(_value1 As Integer, _value2 As Integer)
            Me._value1 = _value1
            Me._value2 = _value2
        End Sub

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

End Class