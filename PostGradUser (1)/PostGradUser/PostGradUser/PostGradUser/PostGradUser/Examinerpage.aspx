<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examinerpage.aspx.cs" Inherits="MileStone3.Examinerpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Examiner Page<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Edit My Personal Info" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="List All Info about Defense I attend" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add Comments for a Defense" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Add Grade for a Defense" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Search for Thesis" OnClick="Button5_Click" />
        </div>
    </form>
</body>
</html>
