<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManufacturersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </form>
            This is the Manufacturers Data Entry Page</div>
        <form>
  <label for="Name">Name:</label>
  <input type="number" id="Name" name="Name" style="width: 168px"><br><br>
  
  <label for="IsActive">Is Active:</label>
  <input type="checkbox" id="IsActive" name="IsActive"><br><br>
  
  <label for="ManufacturerId">Manufacturer ID:</label>
  <input type="number" id="ManufacturerId" name="ManufacturerId" style="width: 168px"><br><br>
  
  <label for="Country">Country:</label>
  <input type="text" id="Country" name="Country" style="width: 168px; height: 25px"><br><br>
  
  <label for="CreatedAt">Created At:</label>
  <input type="datetime-local" id="CreatedAt" name="CreatedAt" style="height: 25px"><br><br>
  
  <button id="okButton">OK</button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
  <button id="cancelButton">Cancel</button>
</form>
</body>
</html>