<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Student information<br />
        <br />
        Rno &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        Name &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <br />
        Gender &nbsp; &nbsp;&nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Style="left: 103px; position: absolute;
            top: 144px" Height="62px" Width="138px" RepeatDirection="Horizontal" 
            TextAlign="Left">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
        <br />
        <br />
        <br />
        Course &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="145px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>MS Office</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>Dot Net</asp:ListItem>
            <asp:ListItem>Oracle</asp:ListItem>
            <asp:ListItem>WAMP</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
        </asp:DropDownList><br />
        <br />
        Qualification&nbsp;
        <asp:ListBox ID="ListBox1" runat="server" Height="85px" Width="122px" SelectionMode="Multiple" AutoPostBack="True">
            <asp:ListItem>B.E</asp:ListItem>
            <asp:ListItem>B.TECT</asp:ListItem>
            <asp:ListItem>B.C.A</asp:ListItem>
            <asp:ListItem>B.SC</asp:ListItem>
            <asp:ListItem>M.SC</asp:ListItem>
            <asp:ListItem>M.C.A</asp:ListItem>
        </asp:ListBox>&nbsp;<br />
        &nbsp;
        <br />
        Language&nbsp;
        Known&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Tamil" />&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="English" />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Telugu" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Height="169px" Text="Label" Width="282px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
