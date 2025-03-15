<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="rno"
            DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="rno" HeaderText="rno" ReadOnly="True" SortExpression="rno" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="marks" HeaderText="marks" SortExpression="marks" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/student.mdb"
            SelectCommand="SELECT * FROM [stud]"></asp:AccessDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataMember="DefaultView" DataSourceID="AccessDataSource1">
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
