<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6"  Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" 
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
        
        OnRowEditing ="GridView1_Edit"
        OnRowUpdating="GridView1_Update"
        OnRowCancelingEdit ="GridView1_Cancel"
        
        OnRowDeleting ="GridView1_Delete" AutoGenerateColumns="False" DataKeyNames="eid" 
        >
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="eid" ReadOnly="True" SortExpression="eid" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                
                
            </Columns>
            
        </asp:GridView>
        &nbsp;
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></div>
    </form>
</body>
</html>

