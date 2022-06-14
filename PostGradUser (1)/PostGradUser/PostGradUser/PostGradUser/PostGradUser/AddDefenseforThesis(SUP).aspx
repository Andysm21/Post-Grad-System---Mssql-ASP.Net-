<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDefenseforThesis(SUP).aspx.cs" Inherits="MileStone3.AddDefenseforThesis_SUP_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Defense For A Thesis
            <br />
            <br />
            <br />
            <br />
            Thesis Serial Number :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Defense Date :&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Defense Location :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
