﻿<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>

   This a html page
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="left: 279px;
            position: absolute; top: 162px" Text="Button" />
        <asp:Label ID="Label1" runat="server" Height="72px" Style="left: 52px; position: absolute;
            top: 154px" Text="Label" Visible="False" Width="185px"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="41px" Width="195px"></asp:TextBox><% Response.Write("Welcome to ASP.NET ");%></div>
    </form>
</body>
</html>
