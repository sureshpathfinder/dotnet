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

public partial class server : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string t = "<br> price <100>500 ";

        Response.Write("Machine Name : " + Server.MachineName + "<br>");
        Response.Write("<br>Path : " + Server.MapPath("TexFile.txt"));
        Response.Write("<br>Script Timeout " + Server.ScriptTimeout);
        Response.Write("<br>" + t);

        string s = Server.HtmlEncode(t);

        Response.Write("<br> Html encode =" + s);
        Response.Write("<p>  res.aspx File content : </p>");
         Server.Execute("res.aspx");
         Response.Write("<br> <hr>my serverpage");
        Response.Write("<br>After Execute");


      
    }
}
