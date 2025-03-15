<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Height="61px" Width="118px">
            <asp:ListItem>C++</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>MS office</asp:ListItem>
            <asp:ListItem>J2EE</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Height="98px" Text="Label" Width="293px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            Width="140px">
            <asp:ListItem>Chennai</asp:ListItem>
            <asp:ListItem>Kovai</asp:ListItem>
            <asp:ListItem>Salem</asp:ListItem>
            <asp:ListItem>Trichy</asp:ListItem>
            <asp:ListItem>Kanya Kumari</asp:ListItem>
            <asp:ListItem>Theeni</asp:ListItem>
        </asp:DropDownList></div>
    </form>
</body>
</html>
