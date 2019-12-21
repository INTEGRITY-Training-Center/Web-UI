using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteUI
{
    public partial class day9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblwc.InnerText = wc();
            //lblname.InnerText = name(); equal under
            //lblname.InnerText = wc() +" "+ name();
        }
        public string wc()
        {
            return "Welcome to ";
        }
        public string name()
        {
            return "U Ba";
        }
        public void lst()
        {
            lblname.InnerText = txtid.Text.Trim() + "-" + wc() + name();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            lst();
        }
    }
}