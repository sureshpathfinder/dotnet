<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@import Namespace="System.Data" %> 
<%@ OutputCache Duration="1" VaryByParam="none" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <!--<meta http-equiv="refresh" content="1" />-->
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
   <%=DateTime.Now.ToShortDateString() %>
  <%-- %><%$ int a=2; %> --%>
    <%Response.Write("Script Let Tags <br><hr>       "); %>
   <% for (int i = 0; i < 10; i++)
      {
             %> 
             <table border="10px">
             <tr><td>data</td><td><% = i+"  "%></td></tr>
             </table>
             <%
       } %>
    </div>
    </form>
</body>
</html>
