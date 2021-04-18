<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 80px; top: 15px; position: absolute" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
        </div>
        <asp:Label ID="CustomerName" runat="server" style="z-index: 1; left: 8px; top: 64px; position: absolute" Text="Name" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 81px; top: 62px; position: absolute" OnTextChanged="txtCustomerName_TextChanged"></asp:TextBox>
        <asp:Label ID="CustomerEmail" runat="server" style="z-index: 1; left: 5px; top: 106px; position: absolute" Text="Email" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 81px; top: 106px; position: absolute"></asp:TextBox>
        <asp:Label ID="CustomerAddress" runat="server" style="z-index: 1; left: 7px; top: 159px; position: absolute; right: 387px; bottom: 478px;" Text="Address" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; top: 158px; position: absolute; left: 81px"></asp:TextBox>
        <asp:Label ID="DateAdded" runat="server" style="z-index: 1; left: 9px; top: 210px; position: absolute" Text="Date Added" width="79px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 81px; top: 211px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkUserNameAvailability" runat="server" style="z-index: 1; left: 13px; top: 254px; position: absolute" Text="Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 293px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 7px; top: 333px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 46px; top: 334px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 12px; top: 18px; position: absolute" Text="ID"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 254px; top: 13px; position: absolute" Text="Find" />
    </form>
</body>
</html>
