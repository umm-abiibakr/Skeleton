<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 23px; position: absolute; right: 558px" Text="Customer ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 111px; top: 24px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 18px; top: 57px; position: absolute; height: 20px" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 111px; top: 59px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
