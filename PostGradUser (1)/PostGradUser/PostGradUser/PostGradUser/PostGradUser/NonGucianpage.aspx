<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NONGUCIAN.aspx.cs" Inherits="MS3.NONGUCIAN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="NON GUCIAN PAGE"></asp:Label>
           <br />

          
            <asp:Table ID="Table1" runat="server" HorizontalAlign ="center">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan ="4">
                        <asp:Button ID="Button1" runat="server" OnClick="ViewProfile" Text="View My Profile" />
                        <asp:Button ID="Button5" runat="server" OnClick="ViewCourses" Text="My Courses" />
                        <asp:Button ID="Button2" runat="server" OnClick="ListTheses" Text="My Theses"/>
                         <asp:Button ID="Button3" runat="server" OnClick="PROGPAGE" Text="Progress Reports"/>
                         <asp:Button ID="Button4" runat="server" OnClick="PUBGPAGE" Text="Publication"/>
                        <asp:Button ID="Button6" runat="server" Text="Add Phone Number" OnClick="AddPhone" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>                                
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />                   
        </div>
    </form>
</body>
</html>
