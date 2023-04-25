<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier_List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 528px; position: absolute" Text="ADD" />
            <asp:Button ID="bntEdit" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 58px; top: 528px; position: absolute" Text="EDIT" />
            <asp:TextBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute; height: 451px; width: 497px">Unbound</asp:TextBox>
        </div>
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 13px; top: 568px; position: absolute; width: 65px" Text="     [ IblError]"></asp:Label>
    </form>
</body>
</html>
