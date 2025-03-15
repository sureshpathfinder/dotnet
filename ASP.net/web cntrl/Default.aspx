<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        Welcome to ASP.Net Control<br />
        <br />
        <asp:Label ID="Label1" runat="server" Height="30px" Text="User ID" Width="120px" BackColor="#00C0C0" BorderColor="Red" BorderStyle="Dotted" BorderWidth="3px" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="False"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        Pass Word &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="TextBox2"
            runat="server" TextMode="Password"></asp:TextBox><br />
        <br />
        Comments &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="64px" TextMode="MultiLine" Width="148px"></asp:TextBox><br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log In" 
            Height="26px" />
        <asp:Label ID="Label2" runat="server" Height="78px" Text="Label" Visible="False"
            Width="202px"></asp:Label>
        <asp:Button ID="Button2" runat="server" CommandName="sample"  OnCommand="sam"
        
            Text="Button"  />
        <asp:Button ID="Button3" runat="server" Text="Button"  CommandName="sample" 
            OnCommand="sam"/>
        <asp:Button ID="Button4" runat="server" Text="Button" CommandName="sample" 
            OnCommand="sam" /></div>
    </form>
</body>
</html>
