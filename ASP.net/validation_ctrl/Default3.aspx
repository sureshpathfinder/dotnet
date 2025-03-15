<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        Enter a Number
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckEven"
            ControlToValidate="TextBox1" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate">Not an Even Number</asp:CustomValidator><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
        
        <script type ="text/javascript" >
           function CheckEven(sender,e)
           {
              if (e.Value%2==0) 
             { 
                    e.IsValid=true;
                  // document.write("Page is Valid");
              }
              else
             { 
                   e.IsValid=false;   
                   document.write("Page is not Valid");
              }
             
           }  
        </script>
    </form>
</body>
</html>
