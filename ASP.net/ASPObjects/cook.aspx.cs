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

public partial class cook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie c = Request.Cookies["visit"];

        if (c == null)
        {
            Response.Cookies["visit"].Value = "ssi";
            Response.Cookies["visit"].Expires = DateTime.Now.AddDays(7);

            Response.Redirect("first.html");
        }
        else
            Response.Redirect("next.html");
    }
}
