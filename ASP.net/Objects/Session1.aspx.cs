using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login2_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string usr, pwd;
        usr = Login2.UserName;
        pwd = Login2.Password;
        if (usr == "sample")
        {
            Session["user"]= usr;
            Response.Redirect("session2.aspx");
        }
        else
            Response.Write("Invalid user");
    }
}
