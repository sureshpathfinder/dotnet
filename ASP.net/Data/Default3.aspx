<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
      <HeaderTemplate ><center ><h1>Employees Information</h1></center></HeaderTemplate>
        <FooterTemplate ><center><h1>********************</h1></center></FooterTemplate>
        <ItemTemplate >
               <a href="#"></a><%#Eval("eid") %> </a>
              <p><%#Eval("ename") %> 
             <u>salary : for a employee in our company<%#Eval("salary") %>  </u></p>
        </ItemTemplate>
        <AlternatingItemTemplate >
          <table border="2" width ="50%" bgcolor="gray">
                <tr><th>Employee Id</th><td><%#Eval("eid") %> </td></tr>
                <tr><th>Name </th><td><%#Eval("ename") %> </td></tr>
                <tr><th>Salary</th><td><%#Eval("salary") %> </td></tr>
            </table>
        </AlternatingItemTemplate>
        <SeparatorTemplate ><hr /> </SeparatorTemplate>
    </asp:Repeater>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:adoConnectionString %>" 
        SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>
    </form>
</body>
</html>
