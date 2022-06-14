<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvalProgRep(SUP).aspx.cs" Inherits="MileStone3.EvalProgRep_SUP_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Evaluate A Progress Report<br />
            <br />
            <br />
            Thesis Serial No :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <br />
            Progress Report No :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <br />
            Evaluation:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="0"></asp:ListItem>
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
