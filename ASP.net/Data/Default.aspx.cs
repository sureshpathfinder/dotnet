using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection c;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new SqlConnection("Data Source=SUNETHRA\\ARASU;Initial Catalog=ado;Integrated Security=True;");
    

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("Select * from emp where eid=" + TextBox1.Text, c);
        ds = new DataSet();
        da.Fill(ds, "emp");
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();

          

    }
    
}
