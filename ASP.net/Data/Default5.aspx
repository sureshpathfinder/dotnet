<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" 
            PageSize="5" OnPageIndexChanging="Page_Change" AllowPaging="True" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="eid" SortExpression="eid" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="salary" HeaderText="salary" 
                    SortExpression="salary" />
            </Columns>
        </asp:GridView>
        &nbsp;
    
    </div>
    </form>
</body>
</html>


