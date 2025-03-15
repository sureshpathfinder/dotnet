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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack)
        {
            Response.Write("second");
        }
        else
        {
            Response.Write("Welcome");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<br> " + DropDownList1.SelectedItem.ToString());
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("<br> " + DropDownList1.SelectedItem.ToString());
    }
}
