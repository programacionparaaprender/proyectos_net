<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebPost.aspx.vb" Inherits="WebPostGet.WebPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="WebPost.aspx" method="post">
        
        <input type="text" id="nombre" name="nombre" required="required" />
        <input type="text" id="apellido" name="apellido" required="required" />
        <button type="submit">Enviar</button>
    </form>
    
</body>
</html>
