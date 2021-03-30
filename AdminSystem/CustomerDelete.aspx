<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnNo" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 65px; top: 45px; position: absolute; width: 30px; margin-top: 0px" Text="No" />
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 12px; top: 44px; position: absolute" Text="Yes" />
        </div>
    </form>
</body>
</html>
