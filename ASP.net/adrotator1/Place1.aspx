<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Place1.aspx.cs" Inherits="Place1" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; z-index: 103;">
        &nbsp;</div>
        &nbsp;&nbsp;<br />
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 104; left: 262px;
            position: absolute; top: 34px; height: 30px; width: 236px;" />
        <br />
        <br />
        &nbsp;
        <center><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" 
                Text="Upload file" AccessKey="2"  />
            <br />
            <br />
&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        &nbsp;&nbsp;<br />
        <br style="font-weight: 700" />
        <br />
        <br />
    </form>
</body>
</html>
