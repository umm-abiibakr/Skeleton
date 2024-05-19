<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            height: 520px;
        }
    </style>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 734px; width: 1798px; text-align: center">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 552px; top: 30px; position: absolute; width: 178px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderId" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 23px; position: absolute"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 1035px; top: 22px; position: absolute; height: 43px" />
            <br />
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 552px; top: 91px; position: absolute; width: 178px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtCustomerId" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 84px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 552px; top: 142px; position: absolute; width: 178px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="txtOrderDate" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 135px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="Status" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 552px; top: 197px; position: absolute; width: 178px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStatus" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 190px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 552px; top: 255px; position: absolute; width: 178px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotalAmount" runat="server" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 248px; position: absolute; height: 43px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkComplete" runat="server" Text="Complete" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 778px; top: 328px; position: absolute; height: 43px" />
            <br />
            <br />
            <br />
            <br />
            &nbsp;<asp:Button ID="btnOK" runat="server" height="43px" OnClick="btnOK_Click" Text="OK" width="142px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 570px; top: 463px; position: absolute" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Font-Bold="False" Font-Size="X-Large" OnClick="btnCancel_Click1" style="z-index: 1; left: 773px; top: 463px; position: absolute; width: 142px; right: 883px; height: 43px" />
            <asp:Button ID="btnReturnToMM" runat="server" Font-Bold="False" Font-Size="X-Large" OnClick="btnReturnToMM_Click" style="z-index: 1; left: 973px; top: 463px; position: absolute; height: 43px" Text="Return to Main Menu" />
            <asp:Label ID="lblError" runat="server" height="26px" width="60px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 611px; top: 391px; position: absolute; bottom: 317px"></asp:Label>
        </div>
    </form>
</body>
</html>
