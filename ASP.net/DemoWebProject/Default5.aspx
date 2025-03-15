<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate ><center ><h1>Employees Information</h1></center></HeaderTemplate>
        <FooterTemplate ><center><h1>********************</h1></center></FooterTemplate>
        <ItemTemplate >
            <table border="2" width ="50%">
                <tr><th>Employee Id</th><td><%#Eval("empno") %> </td></tr>
                <tr><th>Name </th><td><%#Eval("ename") %> </td></tr>
                <tr><th>Salary</th><td><%#Eval("sal") %> </td></tr>
            </table>
        </ItemTemplate>
        <AlternatingItemTemplate >
          <table border="2" width ="50%" bgcolor="gray">
                <tr><th>Employee Id</th><td><%#Eval("empno") %> </td></tr>
                <tr><th>Name </th><td><%#Eval("ename") %> </td></tr>
                <tr><th>Salary</th><td><%#Eval("sal") %> </td></tr>
            </table>
        </AlternatingItemTemplate>
        <SeparatorTemplate ><hr /> </SeparatorTemplate>
        </asp:Repeater>
    <div>
    
    </div>
    </form>
</body>
</html>
