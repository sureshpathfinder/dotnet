<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <span style="font-size: 24pt"><span style="color: #ff00ff">My site </span>
            <br />
        </span>
        <br />
        <br />
        <br />
        Value a
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Value b<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="z-index: 100;
            left: 567px; position: absolute; top: 212px" Text="Subtract" />
    </div>
    </form>
</body>
</html>
