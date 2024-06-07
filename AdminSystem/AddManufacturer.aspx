<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddManufacturer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Add Manufacturer</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #2e004f;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background: rgba(255, 255, 255, 0.1);
            box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
            backdrop-filter: blur(10px);
            -webkit-backdrop-filter: blur(10px);
            border-radius: 10px;
            border: 1px solid rgba(255, 255, 255, 0.2);
            padding: 20px;
            width: 350px;
            text-align: center;
            box-sizing: border-box;
        }
        h2 {
            color: #ffffff;
            margin-bottom: 20px;
        }
        .input-label {
            color: #ffffff;
            display: block;
            margin: 10px 0 5px;
        }
        .input-field {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: none;
            border-radius: 5px;
            outline: none;
            background: rgba(255, 255, 255, 0.2);
            color: #ffffff;
            box-sizing: border-box;
        }
        .button {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: none;
            border-radius: 5px;
            background: rgba(255, 255, 255, 0.2);
            color: #ffffff;
            cursor: pointer;
            transition: background 0.3s;
            box-sizing: border-box;
        }
        .button:hover {
            background: rgba(255, 255, 255, 0.3);
        }
        .message {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Add Manufacturer</h2>
            <asp:Label ID="lblName" runat="server" CssClass="input-label" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblCountry" runat="server" CssClass="input-label" Text="Country:"></asp:Label>
            <asp:TextBox ID="txtCountry" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblIsActive" runat="server" CssClass="input-label" Text="Is Active:"></asp:Label>
            <asp:CheckBox ID="chkIsActive" runat="server" CssClass="input-field" />
            <asp:Label ID="lblCreatedAt" runat="server" CssClass="input-label" Text="Created At:"></asp:Label>
            <asp:TextBox ID="txtCreatedAt" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Button ID="btnAddManufacturer" runat="server" CssClass="button" Text="Add Manufacturer" OnClick="btnAddManufacturer_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
