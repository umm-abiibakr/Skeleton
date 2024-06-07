<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderItems.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblOrderItems_id" runat="server" Text="Order Items ID:"></asp:Label>
        <asp:TextBox ID="txtOrderItems_id" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity:"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDispatchDate" runat="server" Text="Dispatch Date:"></asp:Label>
        <asp:TextBox ID="txtDispatchDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderReceived" runat="server" Text="Order Received:"></asp:Label>
        <asp:CheckBox ID="chkOrderReceived" runat="server" />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnFind" runat="server" Text="find" />
    </div>
</form>
</body>
</html>
