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
using System.Web.Util;

public partial class Place1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string s = FileUpload1.FileName;
      
        Response.Write("File Name=" + s);
        FileUpload1.SaveAs("D:\\SSI_SURESH\\program\\DOT NET\\ASP.net\\adrotator1\\img1\\" + s);
        Image img = new Image();
        img.ImageUrl = "~\\img1\\"+FileUpload1.FileName;
        img.BorderWidth = 3;
        img.BorderColor = System.Drawing.Color.Blue;

        Label l= new Label();
        l.ForeColor = System.Drawing.Color.Red;
        l.Text = "<br> "+ FileUpload1.FileName;
        PlaceHolder1.Controls.Add(img);
        PlaceHolder1.Controls.Add(l);
    }
}
