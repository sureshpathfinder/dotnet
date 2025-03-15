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

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
        else
            Label1.Text = "Invalid UserName/Password";
    }
}
