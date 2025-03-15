<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="151px" ImageUrl="~/images.jpg"
            Width="118px" OnClick="ImageButton1_Click" />
        <asp:Image ID="Image1" runat="server" Height="162px" ImageUrl="~/img12.jpg" 
            Width="245px" BorderColor="#9999FF" BorderStyle="Dotted" BorderWidth="5px" />&nbsp;<br />
        <br />
        &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="126px" ImageUrl="~/images.jpg"
            OnClick="ImageButton2_Click" Width="188px" />&nbsp;<br />
        <br />
        <br />
        <asp:ImageMap ID="ImageMap1" runat="server" Height="200px" HotSpotMode="Navigate"
            ImageUrl="~/img12.jpg" OnClick="ImageMap1_Click" Width="200px">
            <asp:CircleHotSpot NavigateUrl="~/Default.aspx" Radius="10" X="10" Y="10" 
                AlternateText="Sample" />
            <asp:CircleHotSpot NavigateUrl="~/Default2.aspx" Radius="10" X="63" Y="52" Target="_top" />
            <asp:CircleHotSpot NavigateUrl="~/Default.aspx" Radius="10" X="60" Y="20" />
            <asp:CircleHotSpot AlternateText="Click here" NavigateUrl="~/img14.JPG" 
                Radius="10" X="180" Y="180" />
        </asp:ImageMap>&nbsp; '<br />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" Font-Strikeout="False">Click here</asp:HyperLink><br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click</asp:LinkButton><br />
        <br />
        <br />
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Mode="PassThrough" Text="Hello"></asp:Literal>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="Label1" runat="server" Height="40px" Text="Label" Width="106px" 
            ForeColor="#99FFCC"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /></div>
    </form>
</body>
</html>
