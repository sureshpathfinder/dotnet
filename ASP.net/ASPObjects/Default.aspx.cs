using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from products ", "server=Server;database=sample;user id=sa");
        DataSet ds = new DataSet();

        da.Fill(ds, "products");

        Repeater1.DataSource = ds.Tables["products"];
        Repeater1.DataBind();

    }
}
