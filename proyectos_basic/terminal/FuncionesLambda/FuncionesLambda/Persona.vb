Public Class Persona
    Private _dni As String
    Private _nombre As String
    Private _apellido As String

    Public Sub New(_dni As String, _nombre As String, _apellido As String)
        Me._dni = _dni
        Me._nombre = _nombre
        Me._apellido = _apellido
    End Sub

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
End Class
