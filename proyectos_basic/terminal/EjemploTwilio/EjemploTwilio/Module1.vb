Imports System
Imports System.Net
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account

Module Module1
    Enum SecurityProtocolType
        Ssl3 = 48
        Tls = 192
        Tls11 = 768
        Tls12 = 3072
    End Enum
    Sub Main()
        'Install-Package Twilio
        'https://www.twilio.com/docs/libraries/csharp-dotnet

        ServicePointManager.SecurityProtocol = 3072

        Const accountSid As String = "AC20fcd58fedfd36dd67721289d2d71342"
        Const authToken As String = "27314dbe63c4092d6a3376a59485029a"
        TwilioClient.Init(accountSid, authToken)
        Dim texto As String
        texto = "This is the ship that made the Kessel Run in fourteen parsecs?"
        Dim message
        Dim numero1 = New Twilio.Types.PhoneNumber("")
        Dim numero2 = New Twilio.Types.PhoneNumber("")
        message = MessageResource.Create(body:=texto, from:=numero1, [to]:=numero2)
        Console.WriteLine(message.Sid)
        Console.ReadKey()
    End Sub
End Module
