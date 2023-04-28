<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 71px; width: 453px">
            <asp:ListBox ID="lstCustomerlist" runat="server" style="z-index: 1; left: 9px; top: 3px; position: absolute; height: 222px; width: 251px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 15px; top: 241px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 60px; top: 241px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 270px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 108px; top: 240px; position: absolute; margin-top: 0px" Text="Delete" />
    </form>
</body>
</html>
