<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        User Name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        Password
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /><br />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="#FF3333"></asp:Label></div>
    </form>
</body>
</html>
