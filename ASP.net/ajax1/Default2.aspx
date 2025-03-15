<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
      
    </asp:ToolkitScriptManager>
      <br />
    <asp:PasswordStrength ID="PasswordStrength1" runat="server" 
        TargetControlID="TextBox1">
    </asp:PasswordStrength>
    <asp:ColorPickerExtender ID="ColorPickerExtender1" runat="server">
    </asp:ColorPickerExtender>
    </form>
    </body>
</html>
