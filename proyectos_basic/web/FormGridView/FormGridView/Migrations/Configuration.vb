Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports System.Collections.Generic
Imports FormGridView.Models
'Imports System.Collections.Generic.IEnumerable
Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of MyDBContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As MyDBContext)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data.
            Dim defaultStandards As IList(Of Detail) = New List(Of Detail)()
            defaultStandards.Add(New Detail() With {
                .Descripcion = "Standard 1", .Precio = 200
            })
            defaultStandards.Add(New Detail() With {
                .Descripcion = "Standard 2", .Precio = 200
            })
            defaultStandards.Add(New Detail() With {
                .Descripcion = "Standard 3", .Precio = 200
            })
            For Each std In defaultStandards
                context.Departments.Add(std)
            Next
            MyBase.Seed(context)
        End Sub

    End Class

End Namespace
