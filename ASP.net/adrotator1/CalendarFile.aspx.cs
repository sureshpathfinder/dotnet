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

public partial class CalendarFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       Label3.Text = Calendar1.SelectedDate.ToLongDateString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text = Calendar1.SelectedDate.AddDays(20).ToShortDateString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
}
