<%@ Page Language="C#" AutoEventWireup="true" CodeFile="oracle.aspx.cs" Inherits="oracle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem ImageUrl="~/web.gif" Text="Articles" Value="Articles">
                    <asp:MenuItem Text="ASP.Net" Value="ASP.Net"></asp:MenuItem>
                    <asp:MenuItem Text="Java" Value="Java"></asp:MenuItem>
                    <asp:MenuItem Text="C#" Value="C#"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Forum" Value="Forum">
                    <asp:MenuItem Text="Software" Value="Software"></asp:MenuItem>
                    <asp:MenuItem Text="Hardware" Value="Hardware"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="About Us" Value="About Us"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <asp:Menu ID="Menu2" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" BackColor="#FFFFC0" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <br />
        <br />
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
