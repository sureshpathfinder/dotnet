<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server" Height="28px" Orientation="Horizontal" Style="z-index: 100;
            left: 0px; position: absolute; top: 0px" Width="468px">
            <StaticMenuItemStyle HorizontalPadding="2px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="Blue" ForeColor="Yellow" Height="10px" Width="30px" />
            <DynamicMenuStyle BackColor="Cyan" />
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
            <DynamicSelectedStyle ForeColor="Red" />
            <DynamicMenuItemStyle BackColor="Green" ForeColor="White" />
            <Items>
                <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem Text="Language" Value="Language">
                    <asp:MenuItem Text="Dot Net" Value="Dot Net">
                        <asp:MenuItem Text="C#" Value="C#"></asp:MenuItem>
                        <asp:MenuItem Text="Vb.Net" Value="Vb.Net"></asp:MenuItem>
                        <asp:MenuItem Text="ASP.net" Value="ASP.net"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" Style="z-index: 104; left: 65px; position: absolute;
            top: 334px">
            <Nodes>
                <asp:TreeNode ImageToolTip="sample" Text="Root" Value="Root">
                    <asp:TreeNode Text="Parent" Value="Parent">
                        <asp:TreeNode Text="C1" Value="C1"></asp:TreeNode>
                        <asp:TreeNode Text="C2" Value="C2"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Root 2" Value="Root 2">
                    <asp:TreeNode Text="parent2" Value="parent2">
                        <asp:TreeNode Text="c1" Value="c1"></asp:TreeNode>
                        <asp:TreeNode Text="c2" Value="c2"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        <br />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em"
            Height="59px" PathSeparator=" : " Style="z-index: 102; left: 40px; position: absolute;
            top: 165px" Width="266px">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
        <asp:Menu ID="Menu2" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 103;
            left: 33px; position: absolute; top: 287px">
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
