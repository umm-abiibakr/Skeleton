<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDeleteRecord" runat="server" style="z-index: 1; left: 123px; top: 167px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" Height="31px" OnClick="btnYes_Click" style="z-index: 1; left: 171px; top: 219px; position: absolute" Text="Yes" Width="59px" />
        <p>
            <asp:Button ID="btnNo" runat="server" height="31px" OnClick="btnNo_Click" style="z-index: 1; left: 276px; top: 219px; position: absolute" Text="No" width="59px" />
        </p>
    </form>
</body>
</html>
