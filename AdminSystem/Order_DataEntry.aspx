﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales Order Page</title>
    <link href="OrderStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
         <header> Book Order </header>
        <div>
            <div id="OrderDetails">
                <br />
                <asp:Label ID="lblOrderID" runat="server" Text="Order Number" width="160px"></asp:Label>
                <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkOrderConf" runat="server" Text="Order Confirmed" />
                <br />
                <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="160px"></asp:Label>
                <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number" width="160px"></asp:Label>
                <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
                <br />
                <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="160px"></asp:Label>
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblStockNo" runat="server" Text="Stock Number" width="160px"></asp:Label>
                <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblStockPrice" runat="server" Text="StockPrice" width="160px"></asp:Label>
                <asp:TextBox ID="txtStockPrice" runat="server"></asp:TextBox>
                <br />
                <br />
            </div>
            <asp:Label ID="lblError" class="error" runat="server"></asp:Label>
            <br />
            <div>
                <asp:Button ID="btnOK" class="buttons" runat="server" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="btnCancel" class="buttons" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
