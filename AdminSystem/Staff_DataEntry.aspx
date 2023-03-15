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
        <asp:Label ID="StaffId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 615px;" Text="Staff Id"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 103px; top: 36px; position: absolute"></asp:TextBox>
        <asp:Label ID="DateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 62px; position: absolute; height: 22px" Text="Date Of Birth"></asp:Label>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 104px; top: 63px; position: absolute"></asp:TextBox>
        <asp:Label ID="StaffFirstName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 105px; top: 91px; position: absolute"></asp:TextBox>
        <asp:Label ID="StaffLastName" runat="server" style="z-index: 1; left: 12px; top: 119px; position: absolute; height: 28px" Text="Last Name"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="StaffDepartment" runat="server" style="z-index: 1; left: 12px; top: 148px; position: absolute" Text="Department"></asp:Label>
        <asp:TextBox ID="txtStaffDepartment" runat="server" style="z-index: 1; left: 104px; top: 148px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAdmin" runat="server" style="z-index: 1; left: 19px; top: 221px; position: absolute" Text="Admin" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 272px; position: absolute; margin-bottom: 0px" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 315px; position: absolute" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 66px; top: 315px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 102px; top: 117px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
