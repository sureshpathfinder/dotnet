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

public partial class sess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["pagecount"] = int.Parse(Session["pagecount"].ToString ()) + 1;

        Response.Write("<h3>Session Id " + Session.SessionID);
        Response.Write("<h3>Session Timeout " + Session.Timeout );
        Response.Write("<h3>New Session  " + Session.IsNewSession);
        Response.Write("<h3>No of times you visited this page " + Session["pagecount"]);

      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["name1"] = TextBox1.Text;
        Response.Redirect("getsession.aspx");
    }
}
