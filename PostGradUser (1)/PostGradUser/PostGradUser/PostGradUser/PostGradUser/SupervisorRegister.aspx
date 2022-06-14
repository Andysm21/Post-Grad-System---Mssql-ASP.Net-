<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supervisorregister.aspx.cs" Inherits="MileStone3.Supervisorregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="SupervisorRegister" runat="server">
        <div>
            <asp:Label ID="Title" runat="server" Text="Supervisor Registration"></asp:Label>
            <br />
            <br />
            <asp:Label ID="SupFname1" runat="server" Text="First Name   "></asp:Label>
            <asp:TextBox ID="SupFname" runat="server" Height="16px" Width="104px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SupLname1" runat="server" Text="Last Name   "></asp:Label>
            <asp:TextBox ID="SupLname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SupPass1" runat="server" Text="Password  "></asp:Label>
            <asp:TextBox ID="SupPass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SupFaculty1" runat="server" Text="Faculty  "></asp:Label>
            <asp:TextBox ID="SupFaculty" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SupEmail1" runat="server" Text="Email  "></asp:Label>
            <asp:TextBox ID="SupEmail" runat="server"></asp:TextBox>
            
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
