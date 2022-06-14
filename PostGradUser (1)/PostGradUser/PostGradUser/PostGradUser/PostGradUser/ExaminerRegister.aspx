<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examinerregister.aspx.cs" Inherits="MileStone3.Examinerregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="ExaminerRegistration" runat="server">
        <div>
            <asp:Label ID="Title" runat="server" Text="Examiner Registration"></asp:Label>
            <br />
            <br />
            <asp:Label ID="ExFname1" runat="server" Text="First Name   "></asp:Label>
            <asp:TextBox ID="ExFname" runat="server" Height="16px" Width="104px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ExLname1" runat="server" Text="Last Name   "></asp:Label>
            <asp:TextBox ID="ExLname" runat="server"></asp:TextBox>
            <br />
            <br />
               <asp:Label ID="ExEmail1" runat="server" Text="Email  "></asp:Label>
            <asp:TextBox ID="ExEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ExPass1" runat="server" Text="Password  "></asp:Label>
            <asp:TextBox ID="ExPass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ExFieldofWork1" runat="server" Text="Field of Work  "></asp:Label>
            <asp:TextBox ID="ExFieldofWork" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ExIsNational1" runat="server" Text="Is National?  "></asp:Label>
            <asp:DropDownList ID="ExIsNational" runat="server">
                <asp:ListItem>No</asp:ListItem>
                <asp:ListItem>Yes</asp:ListItem>
            </asp:DropDownList>
            
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
