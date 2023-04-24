<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order_ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Confirmation</title>
    <link href="OrderStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="Confirm">
            <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnYes" class="buttons" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" class="buttons" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
