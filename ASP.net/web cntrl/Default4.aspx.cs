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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string msg = "";
        foreach (ListItem li in ListBox1.Items)
        {
            if (li.Selected == true)
            {
                msg += "<BR>" + li.Text + " is selected.";
            }
        }
        Label1.Text = msg;

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("<script> alert('" + DropDownList1.SelectedItem + "')</script>");

    }
   
}
