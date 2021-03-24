<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 16px; top: 16px; position: absolute; height: 330px; width: 393px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 23px; top: 349px; position: absolute; height: 34px; width: 56px; right: 517px" Text="Add" />
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 150px; top: 350px; position: absolute; height: 32px; width: 55px" Text="Edit" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 84px; top: 350px; position: absolute; height: 33px" Text="Delete" />
        </p>
    </form>
</body>
</html>
