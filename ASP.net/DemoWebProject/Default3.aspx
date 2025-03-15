<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
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
        
        OnRowDeleting ="GridView1_Delete" AutoGenerateColumns="False"
        >
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                
                <asp:TemplateField  HeaderText ="EmployeeId" >
                    <ItemTemplate >
                         <asp:Label ID="Lblempno" runat="server" Text='<%# Eval("empno") %>'  ></asp:Label>  
                    </ItemTemplate>
                   <EditItemTemplate >
                         <asp:Label id="LblEmpno" Text ='<%#Eval("empno") %>' runat="server"></asp:Label>
                   </EditItemTemplate> 
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText ="Name" >
                    <ItemTemplate >
                        <asp:Label id="LblName" Text ='<%#Eval("ename") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   <EditItemTemplate >
                         <asp:TextBox  id="TxtName" Text ='<%#Eval("ename") %>' runat="server"></asp:TextBox>
                   </EditItemTemplate> 
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Salary">
                    <ItemTemplate >
                        <asp:Label id="LblSal" Text ='<%#Eval("sal") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   <EditItemTemplate >
                         <asp:TextBox  id="TxtSal" Text ='<%#Eval("sal") %>' runat="server"></asp:TextBox>
                   </EditItemTemplate> 
                </asp:TemplateField>
                
                
            </Columns>
            
        </asp:GridView>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></div>
    </form>
</body>
</html>
