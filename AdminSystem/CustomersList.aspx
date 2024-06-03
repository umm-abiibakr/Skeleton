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
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="position: relative; top: -9px; left: 12px; height: 175px; width: 265px"></asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnEdit" runat="server" Height="27px" OnClick="btnEdit_Click" Text="Edit" Width="51px" style="position: relative; top: -2px; left: 117px" />
        <asp:Button ID="btnReturnToMainMenu" runat="server" height="26px" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 366px; top: 346px; position: absolute" Text="Return To Main Menu" />
        <p>
            <asp:Label ID="lblEnterAName" runat="server" style="position: absolute; z-index: 1; left: 37px; top: 305px" Text="Enter a Name"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 33px; top: 346px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnDelete" runat="server" height="27px" OnClick="btnDelete_Click" Text="Delete" width="51px" style="position: relative; top: -87px; left: 214px" />
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 172px; top: 346px; position: absolute" Text="Clear Filter" width="100px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="position: absolute; z-index: 1; left: 35px; top: 401px"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnAdd" runat="server" Height="27px" OnClick="Button1_Click" Text="Add" Width="51px" style="z-index: 1; left: 24px; top: -170px; position: relative" />
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 166px; top: 303px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
