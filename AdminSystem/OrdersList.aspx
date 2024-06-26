﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders List</title>
        <link href="~/ordersBg.jpg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body{
            background-image: url('ordersBg.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
        </style>
</head>
<body style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 941px; width: 1798px; ">
    <form id="form1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <div style="height: 833px; margin-top: 0px">
        <p style="height: 0px">
            <strong>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 66px; top: 391px; position: absolute" Text="Add" Font-Size="X-Large" height="40px" width="129px" BackColor="#CCCCE6" BorderColor="#CCCCE6" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 391px; position: absolute; right: 1444px;" Text="Edit" Font-Size="X-Large" height="40px" width="129px" BackColor="#CCCCE6" BorderColor="#CCCCE6" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 637px; top: 217px; position: absolute; width: 196px; height: 80px;" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 406px; top: 391px; position: absolute; height: 40px;" Text="Delete" Font-Size="X-Large" ForeColor="#FF3300" BackColor="White" BorderColor="#CCCCE6" />
            </strong>
        </p>
            <br />
            <asp:ListBox ID="lstOrdersList" runat="server" Height="318px" Width="528px" Font-Size="X-Large" style="z-index: 1; left: 36px; top: 54px; position: absolute" BackColor="#EBE6EE"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" Font-Size="X-Large" style="z-index: 1; left: 8px; top: 608px; position: absolute" BackColor="#CCCCE6" BorderColor="#CCCCE6" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" width="225px" Font-Size="X-Large" style="z-index: 1; left: 256px; top: 608px; position: absolute" BackColor="#CCCCE6" BorderColor="#CCCCE6" />
            <asp:Button ID="btnReturnToMM" runat="server" Font-Size="X-Large" OnClick="btnReturnToMM_Click" style="z-index: 1; left: 553px; top: 608px; position: absolute" Text="Return to Main Menu" BackColor="#CCCCE6" BorderColor="#CCCCE6" />
            <asp:Label ID="lblEnterStatus" runat="server" Text="Enter an Order Status" Font-Size="X-Large" style="z-index: 1; left: 43px; top: 498px; position: absolute; width: 284px"></asp:Label>
            <asp:TextBox ID="txtOrderStatus" runat="server" Font-Size="X-Large" style="z-index: 1; left: 369px; top: 490px; position: absolute; height: 44px; width: 313px"></asp:TextBox>
        </div>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
