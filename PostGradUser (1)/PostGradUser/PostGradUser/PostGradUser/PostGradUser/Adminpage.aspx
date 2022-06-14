<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminpage.aspx.cs" Inherits="PostGradUser.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin Page<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Supervisor_Click" Text="Supervisors" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Thesis_Click" Text="Theses" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="IssuePay_Click" Text="Issue Thesis Payment" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="IssueInstal_Click" Text="Issue Installments" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="UpdateExt_Click" Text="Update thesis Extension" />
            <br />
        </div>
    </form>
</body>
</html>
