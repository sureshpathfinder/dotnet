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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //SqlDataAdapter MyAdapter = new SqlDataAdapter("select * from emp", "Data Source=SERVER;Initial Catalog=college;User ID=sa");

        //DataSet DS = new DataSet();
        //MyAdapter.Fill(DS, "emp");

        //Repeater1.DataSource = DS.Tables["emp"].DefaultView;
        //Repeater1.DataBind();
        
    }
   
}
