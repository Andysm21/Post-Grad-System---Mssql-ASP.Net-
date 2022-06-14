<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditMyInfo(EXAM).aspx.cs" Inherits="MileStone3.EditMyInfo_EXAM_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Edit my personal information<br />
            <br />
            Please fill both tabs and if you dont want to change one of them, just enter the old info.<br />
            <br />
            Name :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Field Of Work :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
