<html>
<script runat="server" language="C#">
void btnclick(Object Sender,EventArgs E )
{
	lbl.Text="Welcome " + t1.Text	;
}
</script>

<form runat="server">
Enter Ur Name 

<asp:textbox id="t1" runat="server"/>
<asp:button id="b1" text="Click" runat="server" 
onclick="btnclick"/>
<asp:label id="lbl" text="" runat="server"/>
</form>
</html>