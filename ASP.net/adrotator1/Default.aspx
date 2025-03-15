<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache Duration="1" VaryByParam="null" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Untitled Page</title>
 <!--  <meta http-equiv="refresh" content="5" /> -->
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/ads.xml" Height="177px"
            Width="539px" BorderStyle="Dotted" BorderWidth="3px" 
            BorderColor="#FF0066" />
        <br />
        <br />
        <br />
        &nbsp;</div>
    </form>
</body>
</html>
