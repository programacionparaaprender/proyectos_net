Public Class Usuario
    Private usernameValue As String
    Private passValue As String

    Public Property Username As String
        Get
            Return usernameValue
        End Get
        Set(value As String)
            usernameValue = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return passValue
        End Get
        Set(value As String)
            passValue = value
        End Set
    End Property

    Public Sub New(username As String, pass As String)
        Me.usernameValue = username
        Me.passValue = pass
    End Sub

    Public Sub New()

    End Sub

End Class
