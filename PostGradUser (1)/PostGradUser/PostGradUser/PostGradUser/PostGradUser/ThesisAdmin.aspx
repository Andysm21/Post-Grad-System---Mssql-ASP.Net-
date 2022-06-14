<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThesisAdmin.aspx.cs" Inherits="PostGradUser.Thesis" %>

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
        <asp:BoundField DataField="serialNumber" HeaderText="serialNumber" />
        <asp:BoundField DataField="field" HeaderText="field" />
        <asp:BoundField DataField="type" HeaderText="type" />
        <asp:BoundField DataField="title" HeaderText="title" /> 
        <asp:BoundField DataField="startDate" HeaderText="startDate" />  
        <asp:BoundField DataField="defenseDate" HeaderText="defenseDate" />  
        <asp:BoundField DataField="years" HeaderText="years" /> 
        <asp:BoundField DataField="grade" HeaderText="grade" />  
        <asp:BoundField DataField="payment_id" HeaderText="payment_id" />  
        <asp:BoundField DataField="noOfExtensions" HeaderText="noOfExtensions" />  
            </Columns>
</asp:GridView>
        <br />
        Number of ongoing thesis: </form>
</body>
</html>
