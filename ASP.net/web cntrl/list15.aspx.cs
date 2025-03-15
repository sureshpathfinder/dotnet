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
using System.Collections;

public partial class list15 : System.Web.UI.Page
{
    ArrayList a;
    protected void Page_Load(object sender, EventArgs e)
    {
        a = new ArrayList();
        a.Add("Item1");
        a.Add("Item2");
        a.Add("Item3");
        a.Add("Item4");
        a.Add("Item5");



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList1.DataSource = a;
        DropDownList1.DataBind();


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<b>" + DropDownList1.SelectedItem.ToString() + "</b>");
    }
}
