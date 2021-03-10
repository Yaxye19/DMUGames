<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGameNo" runat="server" Text="Game Number"></asp:Label>
            <asp:TextBox ID="txtGameNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblGameTitle" runat="server" Text="Game Title" width="184px"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblGameDescription" runat="server" Text="Game Description" width="184px"></asp:Label>
            <asp:TextBox ID="txtGameDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="184px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblGamePrice" runat="server" Text="Game Price" width="184px"></asp:Label>
            <asp:TextBox ID="txtGamePrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblGameAvailability" runat="server" Text="Game Availablilty" width="184px"></asp:Label>
        <asp:TextBox ID="txtGameAvailability" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            [lblError]</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
