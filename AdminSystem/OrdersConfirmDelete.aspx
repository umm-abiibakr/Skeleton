<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cornfirm Delete Page</title>
            <link href="~/deleteBg.jpg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body{
            background-image: url('deleteBg.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
        </style>
</head>
<body style="height: 412px; font-weight: 700; align-content:center">
    <form id="form1" runat="server">
        <div style="height: 200px; width: 800px; font-weight: 700; align-content:center; background-color: #EBE6EE; z-index: 1; left: 389px; top: 156px; position: absolute; text-align: justify;">
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 232px; top: 130px; position: absolute; width: 106px" Text="Yes" Font-Size="X-Large" ForeColor="#FF3300" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 421px; top: 130px; position: absolute" Text="No" width="106px" Font-Size="X-Large" />
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 101px; top: 43px; position: absolute" Text="Are you sure you want to delete this record?" Font-Size="X-Large"></asp:Label>

        </div>
    </form>
</body>
</html>
