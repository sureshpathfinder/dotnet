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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
            String a = "";
            a += "Name =" + TextBox2.Text + "<br>";
            a += "Gender =" + RadioButtonList1.SelectedItem.ToString() + "<br>";
            a += "Course =" + DropDownList1.SelectedItem.ToString() + "<br>";
            a += "Qualification="+ListBox1.SelectedItem.ToString()+"<br>";
          
            //foreach (Object i in ListBox1.SelectedItem)
            //{
            //    a += " "+i.ToString();
            //}

            String C = "";
            if (CheckBox1.Checked)
                C +="  "+ CheckBox1.Text;
            if (CheckBox2.Checked)
                C += "  " + CheckBox2.Text;
            if (CheckBox3.Checked)
                C += "  " + CheckBox3.Text;

            a += "Language=" + C + "<br>";
          
        
        Label1.Text = a;

      


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("<script>alert('" + DropDownList1.SelectedItem.ToString() + "')</script>");
    }
}
    

