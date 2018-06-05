Imports System.Web.Mvc

Namespace Controllers
    Public Class MessageController
        Inherits Controller

        ' GET: Message
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace