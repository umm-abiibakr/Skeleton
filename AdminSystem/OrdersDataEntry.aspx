<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders Data Entry</title>
    <link href="~/ordersBg.jpg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body{
            background-image: url('ordersBg.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
        .auto-style1 {
            text-align: left;
            height: 734px;
        }
    </style>
</head>
<body style="z-index: 1; left: -15px; top: -6px; position: absolute; height: 734px; width: 1451px; text-align: center; background-color: #E7EFE7">
    <form id="form1" runat="server">
        <div class="auto-style1"; style="background-color:#CCCCE6; margin-bottom: 0px; z-index: 1; left: 172px; top: 39px; position: absolute; width: 1420px; margin-top: 0px;">
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 426px; top: 38px; position: absolute; width: 178px"></asp:Label>

            <asp:TextBox ID="txtOrderId" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 632px; top: 25px; position: absolute" BorderColor="#E7EFE7" BorderStyle="Inset"></asp:TextBox>
            
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 947px; top: 23px; position: absolute; height: 43px" BackColor="#E7EFE7" />
            <br />
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 426px; top: 91px; position: absolute; width: 178px"></asp:Label>

            <asp:TextBox ID="txtCustomerId" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 632px; top: 79px; position: absolute" BorderColor="#E7EFE7" BorderStyle="Inset"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 426px; top: 142px; position: absolute; width: 178px"></asp:Label>
            <br />
            <asp:TextBox ID="txtOrderDate" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 632px; top: 135px; position: absolute" BorderColor="#E7EFE7" BorderStyle="Inset"></asp:TextBox>
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="Status" Font-Bold="False" Font-Size="X-Large" height="34px" style="z-index: 1; left: 426px; top: 197px; position: absolute; width: 178px"></asp:Label>
            <asp:TextBox ID="txtStatus" runat="server" height="43px" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 632px; top: 190px; position: absolute" BorderColor="#E7EFE7" BorderStyle="Inset"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 426px; top: 255px; position: absolute; width: 178px"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 632px; top: 248px; position: absolute; height: 43px" BorderColor="#E7EFE7" BorderStyle="Inset"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkComplete" runat="server" Text="Complete" width="178px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 636px; top: 392px; position: absolute; height: 43px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="43px" OnClick="btnOK_Click" Text="OK" width="142px" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 273px; top: 574px; position: absolute; right: 1005px;" BackColor="#E7EFE7" />

            <asp:Button ID="btnReturnToMM" runat="server" Font-Bold="False" Font-Size="X-Large" OnClick="btnReturnToMM_Click" style="z-index: 1; left: 772px; top: 569px; position: absolute; height: 43px" Text="Return to Main Menu" BackColor="#E7EFE7" />
            <asp:Label ID="lblError" runat="server" Font-Bold="False" Font-Size="X-Large" style="z-index: 1; left: 495px; top: 492px; position: absolute; bottom: 206px; width: 377px; text-align: center; height: 36px;" ForeColor="#FF3300"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" Font-Size="X-Large" height="43px" OnClick="btnCancel_Click" style="z-index: 1; top: 573px; position: absolute; left: 507px; right: 771px;" Text="Cancel" width="142px" BackColor="#E7EFE7" />
        </div>
    </form>
</body>
</html>
