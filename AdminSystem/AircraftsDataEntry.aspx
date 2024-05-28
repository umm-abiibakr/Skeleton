<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AircraftsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Checkbox1 {
            z-index: 1;
            left: 10px;
            top: 148px;
            position: absolute;
        }
        #Checkbox2 {
            z-index: 1;
            left: 232px;
            top: 931px;
            position: absolute;
            height: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblAircraftID" runat="server" style="z-index: 1; left: 9px; top: 33px; position: absolute" Text="Aircraft ID"></asp:Label>
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtAircraftID" runat="server" style="z-index: 1; left: 200px; top: 37px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 8px; top: 96px; position: absolute; right: 1387px" Text="Description"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 218px; top: 102px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 39px; top: 759px; position: absolute; right: 2950px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 143px; top: 760px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 9px; top: 171px; position: absolute" Text="Price"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 119px; top: 177px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblImageURL" runat="server" style="z-index: 1; left: 6px; top: 301px; position: absolute" Text="Image URL"></asp:Label>
        </p>
        <asp:TextBox ID="txtImageURL" runat="server" style="z-index: 1; left: 212px; top: 302px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 156px; top: 239px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 57px; top: 666px; position: absolute; height: 39px; width: 125px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 3px; top: 235px; position: absolute" Text="Quantity"></asp:Label>
            <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 77px; top: 540px; position: absolute; width: 268px" Text="Availability" />
        </p>
        <asp:Label ID="lblManufacturedDate" runat="server" style="z-index: 1; left: 3px; top: 373px; position: absolute" Text="Manufactured Date"></asp:Label>
        <asp:Label ID="lblAircraftName" runat="server" style="z-index: 1; left: 8px; top: 453px; position: absolute" Text="Aircraft Name"></asp:Label>
        <asp:TextBox ID="txtAircraftName" runat="server" style="z-index: 1; left: 258px; top: 456px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtManufacturedDate" runat="server" style="z-index: 1; left: 323px; top: 380px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
