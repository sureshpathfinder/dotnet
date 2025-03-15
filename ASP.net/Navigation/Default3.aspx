<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <DynamicHoverStyle BackColor="#8080FF" />
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
            <DynamicSelectedStyle BackColor="#FF8080" />
            <DynamicMenuItemStyle BackColor="#80FF80" />
            <Items>
                <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem Text="About" Value="About">
                    <asp:MenuItem Text="About1" Value="About1">
                        <asp:MenuItem Text="detail" Value="detail"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="About 2" Value="About 2"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Program" Value="Program">
                    <asp:MenuItem Text="DotNet" Value="DotNet"></asp:MenuItem>
                    <asp:MenuItem Text="Java" Value="Java"></asp:MenuItem>
                    <asp:MenuItem Text="J2EE" Value="J2EE"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Notes" Value="Notes"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
