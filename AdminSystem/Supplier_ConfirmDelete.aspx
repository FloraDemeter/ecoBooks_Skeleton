<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier_ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 83px; width: 615px">
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 14px; top: 67px; position: absolute" Text="Yes" />
        </div>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 73px; top: 67px; position: absolute" Text="No" />
    </form>
</body>
</html>
