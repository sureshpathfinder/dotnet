<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Trace="true" %>
<%@ OutputCache Duration="1" VaryByParam="none" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 100;
            left: 73px; position: absolute; top: 94px" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="54px"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="z-index: 102;
            left: 140px; position: absolute; top: 28px" Width="152px">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
        </asp:DropDownList>
        0</div>
    </form>
</body>
</html>
