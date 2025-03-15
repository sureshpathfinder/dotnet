<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sample.aspx.cs" Inherits="sample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

// ]]>
</script>
</head>
<body>
    <form id="form1" method="get" action="showdata.aspx">
    <div>
        <br />
        <br />
        User Name
        <input id="Text1" name="usr" type="text" /></div>
        <br />
        Password &nbsp;
        <input id="Password1" name="pwd" type="password" onclick="return Password1_onclick()" /><br />
        <br />
        <br />
        <input id="Submit1" type="submit" value="submit" onclick="return Submit1_onclick()" />
    </form>
</body>
</html>
