<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AircraftsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 50px; top: 709px; position: absolute; height: 73px; width: 151px" Text="Add" />
        <asp:ListBox ID="lstAircraftsList" runat="server" style="z-index: 1; left: 30px; top: 79px; position: absolute; height: 581px; width: 1590px"></asp:ListBox>
    </form>
</body>
</html>
