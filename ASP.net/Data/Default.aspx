<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#FFC080"
            BorderColor="#C00000" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="3" CellSpacing="2"
            DataSourceID="SqlDataSource1" Height="150px" Width="211px" 
            DataKeyNames="eid">
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="eid" ReadOnly="True" 
                    SortExpression="eid" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="salary" HeaderText="salary" 
                    SortExpression="salary" />
            </Columns>
            <HeaderStyle BackColor="#00C000" />
        </asp:GridView>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:adoConnectionString2 %>" 
            SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>
       
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="170px"></asp:TextBox>&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        &nbsp;
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
