using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class grid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from emp", "data source=Server;user id=sa;database=com");
        DataSet ds = new DataSet();

        da.Fill(ds, "emp");

        GridView1.DataSource = ds.Tables["emp"].DefaultView;
        GridView1.DataBind();

    }
}
