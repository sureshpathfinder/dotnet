using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    localhost.Service s;
    protected void Page_Load(object sender, EventArgs e)
    {
       s = new localhost.Service();
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b;        
        a = int.Parse(TextBox1.Text);
        b = int.Parse(TextBox2.Text);
        Response.Write("<script>alert('"+ s.add(a,b) +"')</script>");
        Response.Write("<br><hr>" + s.HelloWorld());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int a, b;
        a = int.Parse(TextBox1.Text);
        b = int.Parse(TextBox2.Text);
        Response.Write("<script>alert('"+s.sub(a,b)+"')</script>");
        
    }
}
