using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Application["Name"] = TextBox1.Text;
            Application["Email"] = TextBox2.Text;
            //Session["Name"] = TextBox1.Text;
            //Session["Email"] = TextBox2.Text;
            Response.Redirect("~/Test.aspx");

        }
    }
}