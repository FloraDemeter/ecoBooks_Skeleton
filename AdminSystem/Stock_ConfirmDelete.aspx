﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock_ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDeletePrompt" runat="server" Text="Are you sure you want to delete this record? "></asp:Label>
            <br />
            <br />
&nbsp;<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;<asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
