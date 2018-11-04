Imports System
Imports System.Collections
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Text
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Contexts
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class MyDBContext
    Inherits DbContext
    'enable-migrations
    'add-migration inicializedDB
    'add-migration inicializedDB -force
    'update-database
    Public Sub New()
        MyBase.New("CadenaConexion")
    End Sub
    Public Property Departments() As DbSet(Of Detail)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
