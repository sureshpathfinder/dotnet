<%@ Page Language="C#" AutoEventWireup="true" CodeFile="csharp.aspx.cs" Inherits="csharp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu2" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem Text="Loans" Value="Loans">
                    <asp:MenuItem Text="Housing" Value="Housing"></asp:MenuItem>
                    <asp:MenuItem Text="Presonal" Value="Presonal"></asp:MenuItem>
                    <asp:MenuItem Text="Educational" Value="Educational"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Account" Value="Account">
                    <asp:MenuItem Text="Savings" Value="Savings"></asp:MenuItem>
                    <asp:MenuItem Text="Current" Value="Current"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Feedback" Value="Feedback"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" PathSeparator=" - ">
        </asp:SiteMapPath>
    <div>
    
    </div>
        <br />
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
    </form>
</body>
</html>
