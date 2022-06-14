<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAndThesisList.aspx.cs" Inherits="MileStone3.StudentAndThesisList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="SUPTHE" runat="server">
        <div>
            Student And Thesis List<br />
            <br />
            <asp:Label ID="Info" runat="server" Text=""></asp:Label>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="firstName" HeaderText="FirstName" />
        <asp:BoundField DataField="lastName" HeaderText="LastName" />
        <asp:BoundField DataField="years" HeaderText="Years" />

    </Columns>
</asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
            <br />
        </div>
    </form>
</body>
</html>
