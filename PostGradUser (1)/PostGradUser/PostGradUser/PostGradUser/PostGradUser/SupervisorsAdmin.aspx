<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorsAdmin.aspx.cs" Inherits="PostGradUser.Supervisors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField DataField="name" HeaderText="Name" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:BoundField DataField="faculty" HeaderText="Faculty" />                    
   
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
