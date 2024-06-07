<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="UsersDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 221px;
            top: 30px;
            position: absolute;
            height: 677px;
            width: 1044px;
        }
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 583px; width: 1798px; text-align: center; background-color: antiquewhite; font-weight: 700">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 181px; top: 182px; position: absolute" Text="Password" width="187px"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblDepartment" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 181px; top: 261px; position: absolute" Text="Department"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" Font-Size="XX-Large" OnClick="btnCancel_Click" style="z-index: 1; left: 581px; top: 407px; position: absolute" Text="Cancel" height="67px" width="184px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Font-Size="Larger" ForeColor="Red" style="z-index: 1; left: 483px; top: 529px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="txtUserID" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 500px; top: 32px; position: absolute"></asp:TextBox>
        <p class="auto-style1">
            <asp:TextBox ID="txtUserName" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 500px; top: 108px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblUserID" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 181px; top: 34px; position: absolute" Text="User ID" width="187px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 500px; top: 180px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDepartment" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 500px; top: 259px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnOK" runat="server" Font-Size="XX-Large" OnClick="btnOK_Click" style="z-index: 1; left: 315px; top: 407px; position: absolute; right: 370px; height: 67px;" Text="OK" width="184px" />
        </p>
        <p class="auto-style1">
            <asp:Label ID="lblUserName" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 181px; top: 110px; position: absolute" Text="UserName" width="187px"></asp:Label>
        </p>
    </form>
</body>
</html>
