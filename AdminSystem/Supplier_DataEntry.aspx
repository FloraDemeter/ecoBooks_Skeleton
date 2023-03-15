<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 18px">
    <form id="form1" runat="server">
        <div style="width: 121px">
            SupplierNo<asp:TextBox ID="txtSupplierNo" runat="server" style="z-index: 1; left: 143px; top: 13px; position: absolute; width: 155px"></asp:TextBox>
        </div>
        <p style="width: 121px">
            SupplierName</p>
        <p style="width: 121px">
            SupplyDate<asp:TextBox ID="SupplyDate" runat="server" style="z-index: 1; left: 146px; top: 89px; position: absolute; width: 155px"></asp:TextBox>
            <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 147px; position: absolute; width: 154px; top: 126px"></asp:TextBox>
        </p>
        <p style="width: 121px">
            SupplierAddress</p>
        <p style="width: 121px">
            SupplierContactNo<asp:TextBox ID="txtSupplierContactNo" runat="server" OnTextChanged="TextBox9_TextChanged" style="z-index: 1; left: 147px; top: 165px; position: absolute; width: 154px"></asp:TextBox>
            <asp:CheckBox runat="server" style="z-index: 1; left: 12px; top: 204px; position: absolute" ID="chkSupplier" Text="   UK " />
        </p>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 145px; top: 49px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; position: absolute; top: 275px" Text=" OK " />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 68px; top: 274px; position: absolute" Text="Cancel" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 15px; top: 239px; position: absolute" Text="IblError"></asp:Label>
    </form>
</body>
</html>
