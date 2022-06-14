<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MileStone3.Registration1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Registration"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Student" OnClick="StudentClick" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Supervisor" OnClick="SupervisorClick" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Examiner" OnClick="ExaminerClick" />
    </form>
</body>
</html>
