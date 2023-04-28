<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <header> Customer Details </header>
        <div>
            <div id="OrderDetails">
                <br />
                <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="150px"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="lblCustomerFullName" runat="server" Text="Full Name" width="150px"></asp:Label>
                <asp:TextBox ID="txtCustomerFullName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblCustomerDateOfBirth" runat="server" Text="Date Of Birth" width="150px"></asp:Label>
                <asp:TextBox ID="txtCustomerDateOfBirth" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Height="29px" Width="38px" />
                <br />
                <br />
                <asp:Label ID="lblCustomerAddress" runat="server" Text="Full Address" width="150px"></asp:Label>
                <asp:TextBox ID="txtCustomerAddress" runat="server" OnTextChanged="txtCustomerAddress_TextChanged"></asp:TextBox>
                <br />
                <asp:Label ID="lblCustomerEmailAddress" runat="server" Text="Email Address" width="150px"></asp:Label>
                <asp:TextBox ID="txtCustomerEmailAddress" runat="server"></asp:TextBox>
                <br />
                <asp:CheckBox ID="chkCustomerLoyalty" runat="server" style="z-index: 1; left: 337px; top: 73px; position: absolute" Text="Loyalty" />
                <br />
            </div>
            <asp:Label ID="lblError" class="error" runat="server">Error</asp:Label>
            <br />
            <div>
                <asp:Button ID="btnOK" class="buttons" runat="server" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="btnCancel" class="buttons" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
