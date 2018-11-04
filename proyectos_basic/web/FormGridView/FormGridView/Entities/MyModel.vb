Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Namespace Entities

    Partial Public Class MyModel
        Inherits DbContext

        Public Sub New()
            MyBase.New("CadenaConexion")
        End Sub

        Public Overridable Property Details As DbSet(Of Details)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        End Sub
    End Class

End Namespace
