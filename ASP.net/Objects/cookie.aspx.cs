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

public partial class cookie : System.Web.UI.Page
{
    HttpCookie c;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = Request.Cookies["visit"];       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         if (c == null)
        {
            Response.Cookies["visit"].Value = TextBox1.Text;
            Response.Cookies["visit"].Expires = DateTime.Now.AddDays(1);
            if (TextBox1.Text == "ssi") 
                Response.Redirect("first.htm");
        }
        else
            Response.Redirect("next.htm");
    }
}
 