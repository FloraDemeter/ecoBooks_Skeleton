<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 615px;" Text="Staff ID" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 104px; top: 36px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="margin-left: 235px" Text="Find" OnClick="btnFind_Click" />
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 62px; position: absolute; height: 22px" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 104px; top: 63px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="First Name" width="82px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 104px; top: 91px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 12px; top: 119px; position: absolute; height: 28px" Text="Last Name" width="82px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 104px; top: 117px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffDepartment" runat="server" style="z-index: 1; left: 12px; top: 148px; position: absolute" Text="Department" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffDepartment" runat="server" style="z-index: 1; left: 104px; top: 148px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblIsAdmin" runat="server" style="z-index: 1; left: 12px; top: 176px; position: absolute" Text="Is Admin" width="82px"></asp:Label>
        <asp:CheckBox ID="chkAdmin" runat="server" style="z-index: 1; left: 104px; top: 176px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 205px; position: absolute; margin-bottom: 0px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 233px; position: absolute;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 66px; top: 233px; position: absolute" Text="Cancel" />
        
        
    </form>
</body>
</html>
