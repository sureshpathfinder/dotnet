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
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie c = Request.Cookies["visited"];

        if (c == null)
        {
            Response.Cookies["visited"].Value = "yes";
            Response.Cookies["visited"].Expires = DateTime.Now.AddDays(3);
            Response.Redirect("first.htm");
        }
        else
            Response.Redirect("next.htm");
    }
}
