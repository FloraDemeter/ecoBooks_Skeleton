<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order_List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order List</title>
    <link href="OrderStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header> Order List</header>
        <div id="list">
            <asp:ListBox ID="lstOrderList" runat="server" Height="193px" Width="223px"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="btnAdd" class="buttons" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" class="buttons" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" class="buttons" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
        </div>
        <div id="CustomerNoFilter">
            <asp:Label ID="lblFilterCustNo" runat="server" Text="Enter Customer No"></asp:Label>
            <asp:TextBox ID="txtFilterCustNo" runat="server"></asp:TextBox>
            <br />
            <div>
                <asp:Button ID="btnApply" class="buttons" runat="server" OnClick="btnApply_Click" Text="Apply" />
                <asp:Button ID="btnClear" class="buttons" runat="server" OnClick="btnClear_Click" Text="Clear" />
                <br />
                <br />
            </div>
        </div>
        <div id="OrderIDFilter">
            <asp:Label ID="lblFilterOrderID" runat="server" Text="Enter Order No"></asp:Label>
            <asp:TextBox ID="txtFilterOrderID" runat="server"></asp:TextBox>
            <br />
            <div>
                <asp:Button ID="btnApplyOrder" class="buttons" runat="server" OnClick="btnApplyOrder_Click" Text="Apply" />
                <asp:Button ID="btnClearOrder" class="buttons" runat="server" OnClick="btnClearOrder_Click" Text="Clear" />
                <br />
                <br />
            </div>
        </div>
        <asp:Label ID="lblError" class="error" runat="server"></asp:Label>
    </form>
</body>
</html>
