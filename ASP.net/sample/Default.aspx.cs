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
        if (!IsPostBack)
        {
            Response.Write("First Time<br><hr>");
        }
        else
            Response.Write("<center><h1>ASP with C#</h1></center>");
             //Response.Write("<script> alert('closed') </script>");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script> alert('HEllo Welcome') </script>");
        Label1.Visible=true;
        if (TextBox1.Text == "")
        {
            //Page.IsValid = false;
            Response.Write("<script> alert('Invalid Input') </script>");
        }
        else
            //Page.IsValid = true;
            Label1.Text = "<b><u>" + TextBox1.Text + "</b></u>";
    }
   /* protected void Page_UnLoad(object sender, EventArgs e)
    {
        Response.Write("<script> alert('closed') </script>");
    }*/
}

