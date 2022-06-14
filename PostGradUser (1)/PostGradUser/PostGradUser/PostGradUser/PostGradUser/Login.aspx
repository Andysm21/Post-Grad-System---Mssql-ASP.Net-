<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MileStone3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PLEASE LOGIN<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Email   "></asp:Label>
            <asp:TextBox ID="UserEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password   "></asp:Label>
            <asp:TextBox ID="Userpassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="No account yet?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
