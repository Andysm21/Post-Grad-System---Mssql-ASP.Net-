<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPhone.aspx.cs" Inherits="MileStone3.GUCIANPHONE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Add your mobile number<br />

        </div>
        <asp:Label ID="Label1" runat="server" Text="Phone    "></asp:Label>
        <asp:TextBox ID="GUCPHONE" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
    </form>
</body>
</html>
