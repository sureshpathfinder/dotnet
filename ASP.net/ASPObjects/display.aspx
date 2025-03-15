<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display.aspx.cs" Inherits="display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        OnRowCancelingEdit="GridView1_RowEditCancel"
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEdit" 
            OnRowUpdating="GridView1_RowUpdating"
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="559px">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                
                <asp:TemplateField HeaderText ="Product Id">
                    <ItemTemplate>
                            <asp:Label Text ='<%#Eval("ProductId") %>' runat="server" ID="LblPid" />
                    </ItemTemplate>
                   
                  <EditItemTemplate >
                            <asp:Label Text ='<%#Eval("ProductId") %>' runat="server" ID="LblPid" />
                    </EditItemTemplate>
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Product Name">
                    <ItemTemplate>
                            <asp:Label Text ='<%#Eval("ProductName") %>' runat="server" ID="LblPname" />
                    </ItemTemplate>
                   
                  <EditItemTemplate >
                            <asp:TextBox Text ='<%#Eval("ProductName") %>' runat="server" ID="txtPname" />
                    </EditItemTemplate>
                    
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText ="Unit Price">
                    <ItemTemplate>
                            <asp:Label Text ='<%#Eval("UnitPrice") %>' runat="server" ID="LblPrice" />
                    </ItemTemplate>
                   
                  <EditItemTemplate >
                            <asp:TextBox Text ='<%#Eval("UnitPrice") %>' runat="server" ID="txtPrice" />
                    </EditItemTemplate>
                    
                </asp:TemplateField>
                
                
            </Columns>
        </asp:GridView>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
    </form>
</body>
</html>
