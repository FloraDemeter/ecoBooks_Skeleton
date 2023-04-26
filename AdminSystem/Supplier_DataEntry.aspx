<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IblSupplierNo" runat="server" style="z-index: 1; left: 10px; top: 13px; position: absolute; right: 444px;" Text="SupplietNumber" width="118px"></asp:Label>
        </div>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 378px; top: 5px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <asp:Label ID="IblSupplierName" runat="server" style="z-index: 1; left: 10px; top: 49px; position: absolute" Text="SupplierName" width="118px"></asp:Label>
        <asp:Label ID="IblSupplyDate" runat="server" style="z-index: 1; left: 10px; top: 85px; position: absolute" Text="SupplyDate" width="118px"></asp:Label>
        <asp:Label ID="IblSupplierAddress" runat="server" style="z-index: 1; left: 10px; top: 121px; position: absolute" Text="SupplierAddress" width="118px"></asp:Label>
        <asp:Label ID="IblSupplierContactNo" runat="server" style="z-index: 1; left: 10px; top: 157px; position: absolute" Text="SupplierContactNo"></asp:Label>
        <asp:TextBox ID="txtSupplierNo" runat="server" style="z-index: 1; left: 182px; top: 12px; position: absolute; width: 156px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 182px; top: 48px; position: absolute; width: 158px"></asp:TextBox>
        <asp:TextBox ID="txtSupplyDate" runat="server" style="z-index: 1; left: 182px; top: 87px; position: absolute; width: 158px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 182px; top: 120px; position: absolute; width: 158px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierContactNo" runat="server" style="z-index: 1; left: 182px; top: 155px; position: absolute; width: 159px"></asp:TextBox>
        <asp:CheckBox ID="chkUK" runat="server" style="z-index: 1; left: 12px; top: 194px; position: absolute; width: 74px" Text="         UK" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 241px; position: absolute; height: 22px;" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 282px; position: absolute; height: 31px; width: 46px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 75px; top: 283px; position: absolute; width: 60px" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
