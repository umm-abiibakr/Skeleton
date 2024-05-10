<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="120px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderId" runat="server" height="21px" width="178px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="120px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtCustomerId" runat="server" height="21px" width="178px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="120px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderDate" runat="server" height="21px" width="178px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="Status" width="120px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStatus" runat="server" height="21px" width="178px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount" width="120px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotalAmount" runat="server" height="21px" width="178px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkComplete" runat="server" Text="Complete" width="178px" height="21px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" height="26px" width="60px"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" Text="OK" width="60px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
