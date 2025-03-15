<%@ Page Language="C#" AutoEventWireup="true" CodeFile="csharp.aspx.cs" Inherits="csharp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        &nbsp;<br />
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        &nbsp;
        <br />
        <br />
        <asp:Menu ID="Menu2" runat="server" BackColor="#C0FFC0" Orientation="Horizontal">
            <DynamicMenuStyle BackColor="#FFFFC0" />
            <DynamicSelectedStyle BackColor="#FFC0C0" />
            <Items>
                <asp:MenuItem Text="Products" Value="Products">
                    <asp:MenuItem Text="Car" Value="Car"></asp:MenuItem>
                    <asp:MenuItem Text="Bike" Value="Bike"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Help" Value="Help">
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Contact Us" Value="Contact Us">
                    <asp:MenuItem Text="Data" Value="Data">
                        <asp:MenuItem Text="Simple" Value="Simple"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <DynamicItemTemplate>
                <%# Eval("Text") %>
            </DynamicItemTemplate>
        </asp:Menu>
        <br />
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <br />
        <br />
        <br />
        &nbsp;
    </form>
</body>
</html>
