<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelThesis(SUP).aspx.cs" Inherits="MileStone3.CancelThesis_SUP_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cancel a specific Thesis<br />
            <br />
            <br />
            Thesis Serial No :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
