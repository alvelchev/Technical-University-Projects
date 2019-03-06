using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MsgBox("Информацията е изпратена успешно към сървъра!",
                this.Page, this);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                DropDownList1.Text = "Избери";
                TextBox4.Text = "";
            }
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<script language='javascript'>alert('" +
            ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </script>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}