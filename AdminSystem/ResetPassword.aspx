<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="UsersDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
    <link href="~/ordersBg.jpg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body{
            background-image: url('ordersBg.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
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
        <div class="auto-style1"; style="background-color:#CCCCE6; margin-bottom: 0px; z-index: 1; left: 172px; top: 39px; position: absolute; height:582px; width: 1200px; margin-top: 0px;">
        <asp:Label ID="lblPassword" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 252px; top: 251px; position: absolute" Text="Password" width="187px"></asp:Label>

        <asp:Button ID="btnCancel" runat="server" Font-Size="XX-Large" OnClick="btnCancel_Click" style="z-index: 1; left: 581px; top: 407px; position: absolute" Text="Cancel" height="67px" width="184px" />

        <asp:Label ID="lblError" runat="server" Font-Size="Larger" ForeColor="Red" style="z-index: 1; left: 483px; top: 529px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtUserID" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 489px; top: 98px; position: absolute"></asp:TextBox>
        <p class="auto-style1">
            <asp:TextBox ID="txtUserName" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 489px; top: 175px; position: absolute"></asp:TextBox>
            <asp:Label ID="tblUserID" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 252px; top: 100px; position: absolute" Text="User ID" width="187px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 489px; top: 249px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnOK" runat="server" Font-Size="XX-Large" OnClick="btnOK_Click" style="z-index: 1; left: 315px; top: 407px; position: absolute; right: 370px; height: 67px;" Text="OK" width="184px" />
        </p>
        <p class="auto-style1">
            <asp:Label ID="lblUserName" runat="server" Font-Size="XX-Large" height="46px" style="z-index: 1; left: 252px; top: 177px; position: absolute" Text="UserName" width="187px"></asp:Label>
        </p>

        </div>
    </form>
</body>
</html>
