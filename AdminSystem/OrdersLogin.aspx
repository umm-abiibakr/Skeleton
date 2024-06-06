<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Login</title>

</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 583px; width: 1798px; text-align: center; background-color: antiquewhite; font-weight: 700">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLogin" runat="server" Text="Orders Login Page" Font-Size="XX-Large"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUserName" runat="server" Text="UserName: " Font-Size="XX-Large"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Font-Size="XX-Large"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Font-Size="XX-Large"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password: " Font-Size="XX-Large"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Font-Size="XX-Large"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" width="216px" Font-Size="XX-Large" style="z-index: 1; left: 752px; top: 393px; position: absolute; height: 53px;" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Font-Size="XX-Large" height="53px" OnClick="btnCancel_Click" style="z-index: 1; left: 984px; top: 393px; position: absolute; width: 216px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnForgotPassword" runat="server" style="z-index: 1; left: 924px; top: 538px; position: absolute; margin-top: 9px; text-align: left;" Text="Forgot Password" OnClick="btnForgotPassword_Click1" />
    </form>
</body>
</html>
