<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressReport.aspx.cs" Inherits="MS3.ProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div style="height: 473px">
            <asp:Label ID="Label20" runat="server" Text="Progress Report"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server" GridLines="Both" Height="107px" HorizontalAlign="Left" Width="276px">
                <asp:TableRow  runat="server" >
                   
                    <asp:TableCell ColumnSpan="5">
                        
                        <asp:Label ID="Label2" runat="server" Text="Thesis ID"></asp:Label>
                       
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                     <asp:TableCell>
                         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                          </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell >
                        <asp:Label ID="Label3" runat="server" Text="Progress Report Date"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                         <asp:Calendar ID="Calendar2" runat="server" Height="180px" Width="200px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" SelectedDate="2021-12-29">
            </asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                         <asp:Label ID="Label4" runat="server" Text="Progress Report Number"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:Button ID="Button3" runat="server" OnClick="ADDPROG" Text="Add Progress Report"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
           

            <asp:Table ID="Table2" runat="server" GridLines="Both" Height="107px" HorizontalAlign="Left" Width="276px">
                <asp:TableRow  runat="server" >
                    <asp:TableCell ColumnSpan="5">
                        <asp:Label ID="Label1" runat="server" Text="Thesis ID"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                     <asp:TableCell>
                         <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                          </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell >
                        <asp:Label ID="Label5" runat="server" Text="State"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                         <asp:Label ID="Label6" runat="server" Text="Progress Report Number"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:Label ID="Label7" runat="server" Text="Description"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:TextBox ID="TextBox5" height="142" width ="200" runat= "server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                          <asp:Button ID="Button1" runat="server" OnClick="FILLPROG" Text="Fill Progress Report"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="Button4" runat="server" style="margin-left: 98px" OnClick="Back" Text="Back" />
            <br/>
            

        </div>
    </form>
</body>
</html>
