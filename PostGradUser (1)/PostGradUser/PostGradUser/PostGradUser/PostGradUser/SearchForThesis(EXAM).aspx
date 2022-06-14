<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForThesis(EXAM).aspx.cs" Inherits="MileStone3.SearchForThesis_EXAM_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Search for all thesis using specific keywords<br />
            <br />
            <br />
            Key words :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="618px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="INFO" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="serialNumber" HeaderText="Serial Number" />
        <asp:BoundField DataField="field" HeaderText="Field" />
        <asp:BoundField DataField="type" HeaderText="Type" />
        <asp:BoundField DataField="title" HeaderText="Title" />  
        <asp:BoundField DataField="startDate" HeaderText="Start Date" />  
        <asp:BoundField DataField="endDate" HeaderText="End Date" />  
        <asp:BoundField DataField="defenseDate" HeaderText="Defense Date" />  
        <asp:BoundField DataField="years" HeaderText="Years" />  
        <asp:BoundField DataField="grade" HeaderText="Grade" />  
        <asp:BoundField DataField="payment_id" HeaderText="Payment ID" />  
        <asp:BoundField DataField="noOfExtensions" HeaderText="Number of Extensions" />  
   
    </Columns>
</asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
