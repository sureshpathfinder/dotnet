<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;User name&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 101px; position: absolute;
            top: 14px"></asp:TextBox>
        <br />
        <br />
        Pwd &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 101; left: 94px; position: absolute;
            top: 57px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 103;
            left: 55px; position: absolute; top: 140px; height: 26px;" 
            Text="Log in " />
    
    </div>
    </form>
</body>
</html>
