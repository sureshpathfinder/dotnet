<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Table rows:&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList><br />Table cells:&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        
    </p>
<table id="t1" border="1" runat="server" visible="false">
    <tbody>
    </tbody>
</table>
    </div>
    </form>
</body>
</html>
