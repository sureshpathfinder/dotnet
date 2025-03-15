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
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection MyConnection = new SqlConnection("server=server;database=sample;user id=sa");
        SqlDataAdapter MyAdapter = new SqlDataAdapter("select * from emp", MyConnection);

        DataSet DS = new DataSet();
        MyAdapter.Fill(DS, "emp");

        Repeater1.DataSource = DS.Tables["emp"].DefaultView;
        Repeater1.DataBind();
    }
}
