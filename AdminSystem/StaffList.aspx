﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:ListBox ID="lstStaffList" runat="server" Height="348px" Width="335px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a name"></asp:Label>
&nbsp;<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
