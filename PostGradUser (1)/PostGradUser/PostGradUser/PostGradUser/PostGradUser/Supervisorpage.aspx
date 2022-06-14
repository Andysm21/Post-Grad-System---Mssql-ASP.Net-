<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supervisorpage.aspx.cs" Inherits="MileStone3.Supervisorpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Supervisor page"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Student and Thesis List" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Students Publication" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add defense for Thesis" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Add Examiner for Defense" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Evaluate Progress Report" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Cancel thesis" OnClick="Button6_Click" />
        </div>
    </form>
</body>
</html>
