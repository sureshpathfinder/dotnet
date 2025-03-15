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

public partial class serv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string t = "<br> price <100>500 ";

        Response.Write ("Machine Name : " + Server.MachineName + "<br>");
        Response.Write("<br>Path : " + Server.MapPath("test.txt"));
        Response.Write("<br>Script Timeout " + Server.ScriptTimeout);
        Response.Write("<br>" + t);

        string s=Server.HtmlEncode(t);

        Response.Write("<br>" + s);
        
        //Server.Execute("sample.aspx");

        Response.Write("<br>After Execute");

        //Server.Transfer("sample.aspx");

        Response.Write("<br>After Transfer");
    }
}
