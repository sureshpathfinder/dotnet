<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarFile.aspx.cs" Inherits="CalendarFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" 
            OnSelectionChanged="Calendar1_SelectionChanged" SelectedDate="2012-01-27">
        </asp:Calendar>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        &nbsp; &nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="89px" Width="488px" 
            Visible="False" BackColor="#3366FF" BorderColor="#FF66FF" 
            BorderStyle="Dotted">
            <asp:Label ID="Label1" runat="server" Height="54px" Text="Date" Width="180px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </asp:Panel>
        &nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show" /><br />
        <br />
        <asp:Panel ID="Panel2" runat="server" BorderColor="Red" BorderStyle="Double" BorderWidth="2px"
            Direction="LeftToRight" Height="114px" HorizontalAlign="Center" Visible="False"
            Width="405px" BackColor="#FFC0C0">
        <asp:Label ID="Label2" runat="server" Height="32px" Text="Reneval Date" Width="184px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" /><br />
            <br />
        </asp:Panel>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Show panel" /><br />
        &nbsp; &nbsp;
    </div>
    </form>
</body>
</html>
