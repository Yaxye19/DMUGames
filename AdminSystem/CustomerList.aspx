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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 494px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 84px; top: 350px; position: absolute; height: 33px" Text="Delete" />
        </p>
        <asp:Label ID="LblEnterEmail" runat="server" style="z-index: 1; left: 22px; top: 403px; position: absolute; width: 147px" Text="Enter a customer email"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 168px; top: 403px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 20px; top: 435px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 436px; position: absolute; left: 80px; height: 25px" Text="Clear" />
    </form>
</body>
</html>
