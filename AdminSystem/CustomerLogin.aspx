<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerLoginPage" runat="server" style="z-index: 1; left: 10px; top: 47px; position: absolute" Text="Customer Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 65px; top: 112px; position: absolute" Text="UserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 150px; top: 108px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 356px; top: 165px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 67px; top: 154px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 151px; top: 153px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 150px; top: 219px; position: absolute; height: 26px; width: 60px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 231px; top: 219px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
