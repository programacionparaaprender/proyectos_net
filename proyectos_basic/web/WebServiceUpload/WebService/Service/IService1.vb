Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Text
Imports System.ServiceModel.Web

<ServiceContract>
    Interface IService1
        <OperationContract>
        <WebInvoke(Method:="GET", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare, UriTemplate:="Dowork")>
        Function DoWork() As String
        <OperationContract>
        <WebInvoke(Method:="POST", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare, UriTemplate:="Dosquare")>
        Function DoSquare(ByVal value As Integer) As Integer
        <OperationContract>
        <WebInvoke(Method:="POST", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare, UriTemplate:="DoAddValues")>
        Function DoAddValues(ByVal AddValues As AddValues) As Integer
    End Interface


