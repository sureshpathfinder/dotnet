﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Session1.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login2" runat="server" onauthenticate="Login2_Authenticate">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
