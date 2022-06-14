<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudentPub(SUP).aspx.cs" Inherits="MileStone3.ViewStudentPub_SUP_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View A Student&#39;s Publications<br />
            <br />
            <br />
            Student ID:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
        <asp:Label ID="StudentPub" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="title" HeaderText="Title" />
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField DataField="dateOfPublication" HeaderText="Date" />
        <asp:BoundField DataField="place" HeaderText="Place" />        
        <asp:BoundField DataField="accepted" HeaderText="Status" />                    
        <asp:BoundField DataField="host" HeaderText="Host" />                    

   
    </Columns>
</asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        <br />
    </form>
</body>
</html>
