
'Install-Package Microsoft.Office.Interop.Outlook -Version 15.0.4797.1003
Imports Microsoft.Office.Interop.Outlook
'Imports System.Windows.Forms

Public Class CorreoOutlook
    Public Sub enviarCorreo()
        Dim m_OutLook As Microsoft.Office.Interop.Outlook.Application


        Try

            '* Creamos un Objeto tipo Mail

            Dim objMail As Microsoft.Office.Interop.Outlook.MailItem

            '* Inicializamos nuestra apliación OutLook

            m_OutLook = New Microsoft.Office.Interop.Outlook.Application


            '* Creamos una instancia de un objeto tipo MailItem

            objMail = m_OutLook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)


            '* Asignamos las propiedades a nuestra Instancial del objeto

            '* MailItem

            objMail.To = "yancel209@gmail.com"

            objMail.Subject = "Prueba de integración con Outlook"

            objMail.Body = "Esto es una prueba de integración de WorkFlow con Outlook"

            '* Enviamos nuestro Mail y listo!

            objMail.Send()


            '* Desplegamos un mensaje indicando que todo fue exitoso

            'MessageBox.Show("Mail Enviado", "Integración con OutLook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As System.Exception

            '* Si se produce algun Error Notificar al usuario
            Console.WriteLine(ex.Message)
            'MessageBox.Show("Error enviando mail")


        Finally

            m_OutLook = Nothing


        End Try
    End Sub
End Class
