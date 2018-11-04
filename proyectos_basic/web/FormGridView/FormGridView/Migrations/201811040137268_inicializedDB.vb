Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class inicializedDB
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Details",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Descripcion = c.String(),
                        .Precio = c.Decimal(nullable := False, precision := 18, scale := 2)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Details")
        End Sub
    End Class
End Namespace
