<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orderItemsLogIN.aspx.cs" Inherits="orderItemsLogIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h1>Login</h1>

    <form action="/login" method="post">

        <label for="username">Username:</label><br>

        <input type="text" id="username" name="username"><br>

        <label for="password">Password:</label><br>

        <input type="password" id="password" name="password"><br>

        <input type = "submit" value="Login">

    </form>

</body>
</html>
