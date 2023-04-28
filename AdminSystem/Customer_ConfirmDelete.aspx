<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 9px; top: 57px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 60px; top: 57px; position: absolute; width: 41px" Text="No" />
    </form>
</body>
</html>
