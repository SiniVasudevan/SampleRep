using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                //if(Application["Name"]!=null)
                //{
                    Label1.Text = Application["Name"].ToString();
                //}
                //if (Session["Email"] != null)
                //{
                     Label2.Text = Application["Email"].ToString();
                //}
            
        }
    }
}