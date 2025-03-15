<%@ Page Language="C#" AutoEventWireup="true" CodeFile="container_ctrl.aspx.cs" Inherits="container_ctrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCFFFF" Height="190px" 
            Width="451px">
            <asp:Image ID="Image1" runat="server" Height="181px" ImageUrl="~/banner2.gif" 
                Width="151px" />
            <asp:Image ID="Image2" runat="server" Height="167px" ImageUrl="~/banner3.gif" 
                Width="176px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">skip</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
    
    </div>
    <p>
        This is my webpage Content</p>
    <p>
        My View File
    </p>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">View 
        1</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">View 
        2</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">View 
        3</asp:LinkButton>
    </p>
    <p>
        data<asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                View 1<br />
                <br />
                <asp:Image ID="Image3" runat="server" Height="107px" ImageUrl="~/banner1.gif" 
                    Width="601px" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                View 2<br />
                <asp:Image ID="Image4" runat="server" Height="117px" ImageUrl="~/banner2.gif" 
                    Width="601px" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                View 3<br />
                <asp:Image ID="Image5" runat="server" Height="106px" ImageUrl="~/banner3.gif" 
                    Width="594px" />
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
    </p>
    </form>
<p>
    &nbsp;</p>
</body>
</html>
