<%@ Page Language="C#" AutoEventWireup="true" CodeFile="grid.aspx.cs" Inherits="grid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
.Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:black;
}
</style>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:GridView ID="gvDetails" DataKeyNames="Userid,UserName" runat="server"
AutoGenerateColumns="false" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
onrowcancelingedit="gvDetails_RowCancelingEdit"
onrowdeleting="gvDetails_RowDeleting" onrowediting="gvDetails_RowEditing"
onrowupdating="gvDetails_RowUpdating"
onrowcommand="gvDetails_RowCommand" 
        onselectedindexchanged="gvDetails_SelectedIndexChanged">
<Columns>

<asp:TemplateField>
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/Images/update.jpg" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/Images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />
</EditItemTemplate>

<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/Images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/Images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>

<FooterTemplate>
<asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/Images/AddNewitem.jpg" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add new User" ValidationGroup="validaiton" />
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="UserName">
<EditItemTemplate>
<asp:Label ID="lbleditusr" runat="server" Text='<%#Eval("Username") %>'/>
</EditItemTemplate>

<ItemTemplate>
<asp:Label ID="lblitemUsr" runat="server" Text='<%#Eval("UserName") %>'/>
</ItemTemplate>

<FooterTemplate>
<asp:TextBox ID="txtftrusrname" runat="server"/>
<asp:RequiredFieldValidator ID="rfvusername" runat="server" ControlToValidate="txtftrusrname" Text="*" ValidationGroup="validaiton"/>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Designation">
<EditItemTemplate>
<asp:TextBox ID="txtDesg" runat="server" Text='<%#Eval("Designation") %>'/>
</EditItemTemplate>

<ItemTemplate>
<asp:Label ID="lblDesg" runat="server" Text='<%#Eval("Designation") %>'/>
</ItemTemplate>

<FooterTemplate>
<asp:TextBox ID="txtftrDesignation" runat="server"/>
<asp:RequiredFieldValidator ID="rfvdesignation" runat="server" ControlToValidate="txtftrDesignation" Text="*" ValidationGroup="validaiton"/>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Department">
<EditItemTemplate>
<%--<asp:TextBox ID="txtdepartment" runat="server" Text='<%#Eval("Department") %>'/>--%>
<asp:DropDownList ID="txtdepartment" runat="server" >
    <asp:ListItem>Select</asp:ListItem>
    <asp:ListItem>PHP</asp:ListItem>
    <asp:ListItem>Java</asp:ListItem>
    <asp:ListItem>Dot Net</asp:ListItem>
    </asp:DropDownList>
</EditItemTemplate>

<ItemTemplate>
<asp:Label ID="lbldepartment" runat="server" Text='<%#Eval("Department") %>'/>
</ItemTemplate>
    
<FooterTemplate>
<%--<asp:TextBox ID="txtftrdepartment" runat="server"/>--%>
<asp:DropDownList ID="txtftrdepartment" runat="server">
    <asp:ListItem>Select</asp:ListItem>
    <asp:ListItem>PHP</asp:ListItem>
    <asp:ListItem>Java</asp:ListItem>
    <asp:ListItem>Dot Net</asp:ListItem> 
    </asp:DropDownList>
<asp:RequiredFieldValidator ID="rfvdepartment" runat="server" ControlToValidate="txtftrdepartment" Text="*" ValidationGroup="validaiton"/>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="City">
<EditItemTemplate>
<%--<asp:TextBox ID="txtcity" runat="server" Text='<%#Eval("City") %>'/>--%>
<asp:DropDownList ID="txtcity" runat="server">
    <asp:ListItem>Select</asp:ListItem>
           <asp:ListItem>Chennai</asp:ListItem>
           <asp:ListItem>Delhi</asp:ListItem>
           <asp:ListItem>Hyderabad</asp:ListItem>
           <asp:ListItem>Bangalore</asp:ListItem>
           <asp:ListItem>Pune</asp:ListItem>
    </asp:DropDownList>
</EditItemTemplate>

<ItemTemplate>
<asp:Label ID="lblcity" runat="server" Text='<%#Eval("City") %>'/>
</ItemTemplate>

<FooterTemplate><%--
<asp:TextBox ID="txtftr" runat="server"/>--%>
<asp:DropDownList ID="txtftrcity" runat="server">
    <asp:ListItem>Select</asp:ListItem>
           <asp:ListItem>Chennai</asp:ListItem>
           <asp:ListItem>Delhi</asp:ListItem>
           <asp:ListItem>Hyderabad</asp:ListItem>
           <asp:ListItem>Bangalore</asp:ListItem>
           <asp:ListItem>Pune</asp:ListItem>
    </asp:DropDownList>
<asp:RequiredFieldValidator ID="rfvcity" runat="server" ControlToValidate="txtftrcity" Text="*" ValidationGroup="validaiton"/>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Gender">
<EditItemTemplate>
<%--<asp:TextBox ID="txtdepartment" runat="server" Text='<%#Eval("Department") %>'/>--%>
<asp:RadioButton ID="RadioButton1" runat="server" Text="male" 
         GroupName="1"   Checked="True" />
<asp:RadioButton ID="RadioButton2" runat="server" Text="female" GroupName="1"  />
</EditItemTemplate>
   
<ItemTemplate>
<asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender") %>'/>
</ItemTemplate>
    
<FooterTemplate>
<%--<asp:TextBox ID="txtftrdepartment" runat="server"/>--%>
<asp:RadioButton ID="RadioButton1" runat="server" Text="male" 
          Checked="True" />
<asp:RadioButton ID="RadioButton2" runat="server" Text="female" />
<%--<asp:RequiredFieldValidator ID="rfvdepartment" runat="server" ControlToValidate="txtftrRadioButton2" Text="*" ValidationGroup="validaiton"/>--%>
</FooterTemplate>
</asp:TemplateField>




</Columns>
</asp:GridView>
</div>

<div>
<asp:Label ID="lblresult" runat="server"></asp:Label>
</div>
</form>
</body>
</html>
