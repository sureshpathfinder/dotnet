<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="compose.aspx.cs" Inherits="compose" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Composing the Mail<br />
    <br />
    To : &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <br />
    Message
    <asp:TextBox ID="TextBox2" runat="server" Height="72px" TextMode="MultiLine" Width="279px"></asp:TextBox>&nbsp;<br />
    <asp:Button ID="Button1" runat="server" Text="Send" /><br />
    &nbsp;&nbsp;<br /><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>

