<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentregister.aspx.cs" Inherits="MileStone3.Studentregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 342px">
    <form id="StudentRegister" runat="server">
        <div>
            <asp:Label ID="Title" runat="server" Text="Student Registration"></asp:Label>
            <br />
            <br />
            <asp:Label ID="StudFname1" runat="server" Text="First Name   "></asp:Label>
            <asp:TextBox ID="StudFname" runat="server" Height="16px" Width="104px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="StudLname1" runat="server" Text="Last Name   "></asp:Label>
            <asp:TextBox ID="StudLname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="StudPass1" runat="server" Text="Password  "></asp:Label>
            <asp:TextBox ID="StudPass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="StudFaculty1" runat="server" Text="Faculty  "></asp:Label>
            <asp:TextBox ID="StudFaculty" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="StudGUCIAN1" runat="server" Text="Gucian  "></asp:Label>
            <asp:DropDownList ID="GUCAINBIT" runat="server">
                <asp:ListItem>No</asp:ListItem>
                <asp:ListItem>Yes</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="StudEmail1" runat="server" Text="Email  "></asp:Label>
            <asp:TextBox ID="StudEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="StudAddress1" runat="server" Text="Address  "></asp:Label>
            <asp:TextBox ID="StudAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
      </div>
    </form>
</body>
</html>
