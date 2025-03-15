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
        DataView source = (DataView)Cache["mydata"];

        if (source == null)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from products", "data source=Server;user id=sa;database=sample");
            DataSet ds = new DataSet();
            
            da.Fill(ds, "products");

            source = ds.Tables["products"].DefaultView;

            Cache["mydata"] = source;

            Label1.Text = "Page Loaded from Database";
        }
        else
            Label1.Text = "From Cache";


            GridView1.DataSource = source;
            GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
