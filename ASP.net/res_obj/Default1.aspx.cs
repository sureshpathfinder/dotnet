using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((TextBox1.Text == "ssi") && (TextBox2.Text=="pwd"))
        {
            Response.Write("<script>alert('Welcome ');</script>");
            Response.Redirect("Default2.aspx");
        }
        else
        {
            Response.Write("<script>alert('Invalid user ');</script>");
            Response.Redirect("Default1.aspx");
        }
    }
}
