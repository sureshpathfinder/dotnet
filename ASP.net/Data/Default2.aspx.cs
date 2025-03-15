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
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{

    SqlConnection cn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn=new SqlConnection("Data Source=SUNETHRA\\ARASU;Initial Catalog=ado;Integrated Security=True");
        da=new SqlDataAdapter("select * from emp",cn);
        ds=new DataSet();


        da.Fill(ds,"emp");
        GridView1.DataSource=ds.Tables[0];
        GridView1.DataBind();

        
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}
