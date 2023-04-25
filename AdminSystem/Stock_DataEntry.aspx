<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockNo" runat="server" Text="Stock Number" width="96px"></asp:Label>
            <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblStockName" runat="server" Text="Stock Name" width="96px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDescription" runat="server" Text="Description" width="96px"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity" width="96px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProcessedDate" runat="server" Text="Processed Date"></asp:Label>
        <asp:TextBox ID="txtProcessedDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="height: 26px" />
    </form>
</body>
</html>
