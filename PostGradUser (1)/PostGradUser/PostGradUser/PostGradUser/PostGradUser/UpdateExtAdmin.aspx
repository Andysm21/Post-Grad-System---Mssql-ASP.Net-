<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateExtAdmin.aspx.cs" Inherits="PostGradUser.UpdateExtAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Extend Thesis<br />
            <br />
            Enter thesis serial number:&nbsp;&nbsp;
            <asp:TextBox ID="serialN" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
            <br />
        </div>
    </form>
</body>
</html>
