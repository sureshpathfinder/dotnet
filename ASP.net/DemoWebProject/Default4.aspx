<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<asp:GridView ID="GridView1" runat="server" 
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
        
        OnRowEditing ="GridView1_Edit"
        OnRowUpdating="GridView1_Update"
        OnRowCancelingEdit ="GridView1_Cancel"
        
        OnRowDeleting ="GridView1_Delete" AllowPaging="True" PageSize="5"
        
        >
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    <div>
    
    </div>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    </form>
</body>
</html>
