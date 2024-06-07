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
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 50px; top: 649px; position: absolute; height: 91px; width: 147px; right: 1556px;" Text="Add" />
        <asp:ListBox ID="lstAircraftsList" runat="server" style="z-index: 1; left: 30px; top: 37px; position: absolute; height: 581px; width: 1590px"></asp:ListBox>
        <asp:Label ID="lblEnterID" runat="server" style="z-index: 1; left: 103px; top: 811px; position: absolute" Text="Enter An Aircraft ID"></asp:Label>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 281px; top: 653px; position: absolute; height: 88px; width: 157px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 167px; top: 928px; position: absolute; height: 53px; width: 167px"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 526px; top: 650px; position: absolute; height: 89px; width: 157px; right: 1070px" Text="Delete" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 417px; top: 903px; position: absolute" Text="Apply Filter" />
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 482px; top: 810px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 730px; top: 901px; position: absolute" Text="Clear Filter" />
        </p>
    </form>
</body>
</html>
