<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server" Height="63px" Orientation="Horizontal" Style="z-index: 100;
            left: 166px; position: absolute; top: 129px" Width="401px">
            <StaticMenuStyle BackColor="#C00000" />
            <StaticMenuItemStyle BackColor="Lime" ForeColor="Blue" />
            <DynamicHoverStyle BackColor="Blue" BorderColor="GhostWhite" ForeColor="White" />
            <DynamicMenuStyle BackColor="Lime" />
            <StaticSelectedStyle ForeColor="White" />
            <DynamicSelectedStyle BackColor="#FFC0C0" />
            <DynamicMenuItemStyle BackColor="#E0E0E0" ForeColor="Blue" />
            <Items>
                <asp:MenuItem NavigateUrl="~/Book1.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem Text="Link" Value="Link">
                    <asp:MenuItem NavigateUrl="~/Default4.aspx" Text="Link 1" Value="Link 1"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Service" Value="Service">
                    <asp:MenuItem NavigateUrl="~/page2.aspx" Text="S1" Value="S1"></asp:MenuItem>
                    <asp:MenuItem Text="s2" Value="s2"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Contact" Value="Contact"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="Blue" ForeColor="White" />
        </asp:Menu>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em"
            Height="41px" OnDataBinding="Page_Load" PathSeparator=" : " Style="z-index: 101;
            left: 101px; position: absolute; top: 284px">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
        <asp:Menu ID="Menu2" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal"
            Style="z-index: 102; left: 20px; position: absolute; top: 191px">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" Style="z-index: 104; left: 248px; position: absolute;
            top: 466px">
            <Nodes>
                <asp:TreeNode Text="New 1" Value="New 1"></asp:TreeNode>
                <asp:TreeNode Text="New 2" Value="New 2">
                    <asp:TreeNode Text="New 2 Node 1" Value="New 2 Node 1">
                        <asp:TreeNode Text="New 2 Node 1" Value="New 2 Node 1"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    </form>
</body>
</html>
