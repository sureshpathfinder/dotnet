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

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("This is a theme image X="+e.X.ToString()+"Y="+e.Y.ToString());
       
    }

    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
        Response.Write(e.PostBackValue);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("Button Clicked");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = "<a href='Default.aspx'>Click</a>";
        Label1.Text = "<a href='Default.aspx'>Click</a>";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script> alert('Image Button is Clicked')</script>");
    }
}
