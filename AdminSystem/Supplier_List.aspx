<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier_List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:TextBox ID="txtEnteraSupplierName" runat="server" style="z-index: 1; left: 154px; top: 443px; position: absolute"></asp:TextBox>
            </p>
            <asp:Button ID="bntDelete" runat="server" style="z-index: 1; left: 105px; top: 401px; position: absolute; width: 54px" Text="Delete" OnClick="bntDelete_Click" />
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 402px; position: absolute; right: 605px;" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="bntEdit" runat="server" style="z-index: 1; left: 58px; top: 401px; position: absolute; right: 557px;" Text="Edit" />
            <asp:ListBox ID="lstSupplierList" runat="server" OnSelectedIndexChanged="lstSupplierList_SelectedIndexChanged" style="z-index: 1; left: 8px; top: 51px; position: absolute; height: 344px; width: 299px"></asp:ListBox>
            <asp:Button ID="bntApply" runat="server" style="z-index: 1; left: 10px; top: 483px; position: absolute; width: 44px; right: 641px;" Text="Apply " OnClick="bntApply_Click" />
            <asp:Button ID="bntClear" runat="server" style="z-index: 1; left: 74px; top: 482px; position: absolute" Text="Clear" OnClick="bntClear_Click" />
            <asp:Label ID="IblEnteraSupplierName" runat="server" style="z-index: 1; left: 8px; top: 444px; position: absolute" Text="Enter a SupplierName"></asp:Label>
        </div>
         <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 525px; position: absolute; width: 65px" Text="     [ IblError]"></asp:Label>
    </form>
</body>
</html>
