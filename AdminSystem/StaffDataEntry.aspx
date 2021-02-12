<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNo" runat="server" Text="Staff Number" width="88px"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name" width="88px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="88px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="88px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblRole" runat="server" Text="Role" width="88px"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblHourlyWage" runat="server" Text="Hourly Wage" width="88px"></asp:Label>
        <asp:TextBox ID="txtHourlyWage" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkHolidayStatus" runat="server" Text="Holiday Status" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
