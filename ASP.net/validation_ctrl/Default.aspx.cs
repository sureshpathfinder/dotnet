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
       Response.Write("<h3>Application Path Value : " + ConfigurationManager.AppSettings["pict_path"]);
       Response.Write("<h3>Connection String Value : " + ConfigurationManager.ConnectionStrings ["cn_str"]);
    }
}

