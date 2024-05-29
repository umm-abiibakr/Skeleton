<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="137px" Width="120px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnEdit" runat="server" Height="27px" OnClick="btnEdit_Click" Text="Edit" Width="51px" />
        <br />
        <p>
        <asp:Button ID="btnAdd" runat="server" Height="27px" OnClick="Button1_Click" Text="Add" Width="51px" />
        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" height="27px" OnClick="btnDelete_Click" Text="Delete" width="51px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label><asp:Label runat="server" Text="Label"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </form>
</body>
</html>
