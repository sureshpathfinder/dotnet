using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class web_conf3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        Response.Write("<h3>Connection String Value : " + ConfigurationManager.ConnectionStrings["xxx"]);
        Response.Write("<h3>Connection String Value : " + ConfigurationManager.ConnectionStrings["xxx"].ProviderName);

    }
}
