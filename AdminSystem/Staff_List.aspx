<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff_List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 510px; width: 698px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 109px; top: 565px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 60px; top: 565px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 688px; position: absolute"></asp:Label>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 16px; top: 651px; position: absolute;" Text="Apply" OnClick="btnApply_Click" />
        </p>
        <p>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 5px; top: 623px; position: absolute" Text="Enter a First name "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; top: 623px; left:130px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 81px; top: 651px; position: absolute" Text="Clear" />
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 565px; position: absolute" Text="Add" />
    </form>
</body>
</html>
