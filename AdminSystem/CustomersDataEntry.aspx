<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 24px; position: absolute; right: 1375px; width: 100px;" Text="Customer ID" height="19px"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 136px; top: 18px; position: absolute; height: 23px; width: 126px; bottom: 511px;" Width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 58px; position: absolute; height: 19px; bottom: 361px;" Text="Name" width="75px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 136px; top: 55px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" height="19px" style="z-index: 1; left: 10px; top: 94px; position: absolute" Text="Email" width="75px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 136px; top: 92px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" height="19px" style="z-index: 1; left: 10px; top: 131px; position: absolute" Text="Address" width="75px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 136px; top: 126px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCountry" runat="server" style="z-index: 1; left: 10px; top: 163px; position: absolute; height: 19px; width: 75px" Text="Country"></asp:Label>
        <asp:TextBox ID="txtCountry" runat="server" height="22px" style="z-index: 1; left: 136px; top: 158px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" height="19px" style="z-index: 1; left: 10px; top: 197px; position: absolute" Text="DateOfBirth" width="75px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" height="22px" style="z-index: 1; left: 136px; top: 193px; position: absolute; bottom: 337px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkSubscription" runat="server" style="z-index: 1; left: 116px; top: 244px; position: absolute" Text="Subscription" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 291px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 104px; top: 322px; position: absolute; width: 60px; height: 27px;" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
        </p>
    </form>
</body>
</html>
