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
using System.Data.SqlClient;

public partial class Default5 : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from emp", "Data Source=SUNETHRA\\ARASU;Initial Catalog=ado;Integrated Security=True");
        ds = new DataSet();
        da.Fill(ds, "emp");

        GridView1.DataSource = ds.Tables["emp"].DefaultView;
        GridView1.DataBind();
    }

    protected void Page_Change(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }

    
}
