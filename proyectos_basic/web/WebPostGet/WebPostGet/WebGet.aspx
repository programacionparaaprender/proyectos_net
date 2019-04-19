<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebGet.aspx.vb" Inherits="WebPostGet.WebGet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form method="get" action="WebGet.aspx">
        First Name: <input type="text" name="fname" /><br>
        Last Name: <input type="text" name="lname" /><br><br>
        <input type="submit" value="Submit" />
    </form>
    <a href="WebGet.aspx?fname=luis&lname=correa">Ejemplo de envìo de informaciòn</a>
</body>
</html>
