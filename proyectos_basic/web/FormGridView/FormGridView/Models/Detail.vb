Imports System.ComponentModel.DataAnnotations
Imports System.Threading.Tasks
Namespace Models
    Public Class Detail

        Private _id As Integer
        Private _descripcion As String
        Private _precio As Decimal
        <Key>
        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property

        Public Property Precio As Decimal
            Get
                Return _precio
            End Get
            Set(value As Decimal)
                _precio = value
            End Set
        End Property
    End Class

End Namespace
