<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="publication.aspx.cs" Inherits="MS3.publication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                     <asp:Label ID="Label2" runat="server" Text="Publishing Date"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                     <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                     <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Host"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                     <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Place"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                     <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="Accepted"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>
                               Yes
                            </asp:ListItem>
                            <asp:ListItem>
                               No
                            </asp:ListItem>
                        </asp:RadioButtonList>
                        
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" onClick="ADDPUB" Text="Add Publication" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />

            <asp:Table ID="Table2" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                <asp:Label ID="Label6" runat="server" Text="Publication ID"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                     <asp:Label ID="Label7" runat="server" Text="Thesis Serial Number"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="Button2" runat="server" onClick="LINKPUB" Text="Link Publication" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" onClick="Back" Text="Back" />
        </div>
    </form>
</body>
</html>
