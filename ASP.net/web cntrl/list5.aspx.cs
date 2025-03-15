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

public partial class list5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack)
            Response.Write("<b>Second time</b>");
        else
            Response.Write("<h1 align='center'>Welcome User</h1>");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Remove(TextBox1.Text);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox1.Text = ListBox1.SelectedItem.ToString();
    }
}
