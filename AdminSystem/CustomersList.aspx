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
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 40px; top: 239px; position: absolute" Text="Add" height="26px" width="55px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 126px; top: 239px; position: absolute" Text="Edit" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 218px; top: 239px; position: absolute" Text="Delete" height="26px" width="55px"  />
        <br />
        <br />
        <br />
        <asp:Button ID="btnReturnToMainMenu" runat="server" height="26px" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 366px; top: 346px; position: absolute" Text="Return To Main Menu" />
        <asp:ListBox ID="lstCustomerList" runat="server" Height="132px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="position: relative; top: -9px; left: 5px" Width="302px"></asp:ListBox>
        <p>
            <asp:Label ID="lblEnterAName" runat="server" style="position: absolute; z-index: 1; left: 37px; top: 305px" Text="Enter a Name"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 33px; top: 346px; position: absolute" Text="Apply Filter"  width="100px"/>
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 172px; top: 346px; position: absolute" Text="Clear Filter" width="100px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="position: absolute; z-index: 1; left: 35px; top: 401px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 166px; top: 303px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
