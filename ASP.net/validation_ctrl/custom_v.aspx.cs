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

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int n = int.Parse(args.Value);

        if (n % 10 == 0)
        {
            CustomValidator1.Text = "Not an Even Number";
            args.IsValid = true;
        }
        else
        {
            CustomValidator1.Text ="Not a Divisible of 10";
            args.IsValid = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
            Label1.Text = "Page Is Valid !!!";
        else
            Label1.Text = "Page Is not Valid";
    }
}
