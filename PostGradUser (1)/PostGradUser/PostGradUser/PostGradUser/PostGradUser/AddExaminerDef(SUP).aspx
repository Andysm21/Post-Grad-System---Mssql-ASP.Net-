<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExaminerDef(SUP).aspx.cs" Inherits="MileStone3.AddExaminerDef_SUP_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Examiner For a Defense<br />
            <br />
            Thesis Serial No :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Defense Date :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Examiner Name :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            National? :
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="Yes"></asp:ListItem>
                <asp:ListItem Value="No"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Field Of Work :
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
