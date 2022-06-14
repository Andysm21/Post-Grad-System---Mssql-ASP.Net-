<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAllInfo(EXAM).aspx.cs" Inherits="MileStone3.ListAllInfo_EXAM_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View All Informations Regarding Defense I Attended<br />
            <br />
            <br />
            <br />
            <asp:Label ID="INFO" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
        <asp:BoundField DataField="SupervisorName" HeaderText="Supervisor Name" />
        <asp:BoundField DataField="title" HeaderText="Title" />
   
    </Columns>
</asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View " OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Back " OnClick="Button2_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
