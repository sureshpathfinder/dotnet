<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form_ctrl1.aspx.cs" Inherits="Form_ctrl1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick(form) 
{
    var user,pwd;
   user=form.Text1.value;
  pwd= form.Password1.value;
  if((user=="ssi")&&(pwd=="chh"))
  {
    alert("Welcome"+user);
    }
   else
  {
    alert("invalid user"+user);
   }
      

}



// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    <form action="Default.aspx" method="get">
        Enter ur name&nbsp;
        <input id="Text1" type="text" name="usr"/><br />
        <br />
        Enter password&nbsp;
        <input id="Password1" type="password"  name="pwd"/><br />
        <br />
        <br />
        <input id="Button1" type="button" value="button" onclick="return Button1_onclick(this.form)" />
        <select id="Select1" style="width: 182px; height: 70px" size="5" multiple=multiple>
            <option selected="selected"> Tamil</option>
            <option selected="selected"> English</option> 
           <option selected="selected"> Tamil</option>
            <option selected="selected"> English</option>  
            
        </select>
        </form>
    </div>
    </form>
<p>
    <input id="Submit1" type="submit" value="submit" /></p>
</body>
</html>
