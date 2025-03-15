using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            for (int i = 1; i < 10; i++)
            {
                DropDownList1.Items.Add(i.ToString());
                DropDownList2.Items.Add(i.ToString());
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int row = 0;
        int r = int.Parse(DropDownList1.SelectedItem.ToString());
        int c = int.Parse(DropDownList1.SelectedItem.ToString());
        for (int i = 0; i <= r; i++)
        {
            HtmlTableRow tr1 = new HtmlTableRow();
            row++;
            for (int j = 0; j <= c; j++)
            {
                HtmlTableCell tc1 = new HtmlTableCell();
                tc1.Controls.Add(new LiteralControl("row " + i + ", cell " + j));
                tr1.Cells.Add(tc1);
            }
            t1.Rows.Add(tr1);
            t1.Visible = true;
        }

    }
}
