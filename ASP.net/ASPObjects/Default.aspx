<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" method="post" runat="server">
        &nbsp;
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate ><center ><h1>Products Information</h1></center></HeaderTemplate>
        <FooterTemplate ><center >*****</center></FooterTemplate>
        <ItemTemplate >
            <div style ="background-color :Lime">
               <h2><%# DataBinder.Eval(Container.DataItem ,"ProductID") %></h2>
               <h3><%# DataBinder.Eval(Container.DataItem ,"ProductName") %></h3> 
               <h3><%# DataBinder.Eval(Container.DataItem ,"UnitPrice") %></h3> 
            </div>
        </ItemTemplate>
        
        <AlternatingItemTemplate>
            <div style ="background-color :Maroon">
               <h2><%# DataBinder.Eval(Container.DataItem ,"ProductID") %></h2>
               <h3><%# DataBinder.Eval(Container.DataItem ,"ProductName") %></h3> 
               <h3><%# DataBinder.Eval(Container.DataItem ,"UnitPrice") %></h3> 
            </div>
        </AlternatingItemTemplate>
        <SeparatorTemplate ><hr /></SeparatorTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
