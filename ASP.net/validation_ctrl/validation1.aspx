<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validation1.aspx.cs" Inherits="validation1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        User name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="Enter user Name"></asp:RequiredFieldValidator><br />
        <br />
        Password&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;
        <br />
        <br />
        confirm Pwd
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2"
            ControlToValidate="TextBox3" ErrorMessage="Pwd r not Equal"></asp:CompareValidator><br />
        <br />
        Age &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="Enter Btw 18 to 75" MaximumValue="75" MinimumValue="18" Type="Integer"></asp:RangeValidator><br />
        <br />
        Alternative Email
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5"
            ErrorMessage="Enter Correct Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
        <br />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="123px" 
            Width="300px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /><br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
