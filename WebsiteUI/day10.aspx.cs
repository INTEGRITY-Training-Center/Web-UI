using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteUI
{
    public partial class day10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnadd_Click(object sender, EventArgs e)
        {
            AllNO mynum = new AllNO();
            mynum.firstnum = Convert.ToInt32(txtnum1.Text.Trim());
            mynum.secondnum = Convert.ToInt32(txtnum2.Text.Trim());
            Addfn(mynum);
        }

        AllNO mycls = new AllNO();
        void Addfn(AllNO an)
        {
            lblresult.Text = (an.firstnum + an.secondnum).ToString();
        }
       

        protected void btnsubtract_Click(object sender, EventArgs e)
        {
            AllNO mynum = new AllNO();
            mynum.firstnum = Convert.ToInt32(txtnum1.Text.Trim());
            mynum.secondnum = Convert.ToInt32(txtnum2.Text.Trim());
            Subfn(mynum);
        }

        AllNO mysub = new AllNO();
        void Subfn(AllNO an)
        {
            lblresult.Text = (an.firstnum - an.secondnum).ToString();
        }

        protected void btnmultiply_Click(object sender, EventArgs e)
        {
            AllNO mynum = new AllNO();
            mynum.firstnum = Convert.ToInt32(txtnum1.Text.Trim());
            mynum.secondnum = Convert.ToInt32(txtnum2.Text.Trim());
            Mulfn(mynum);
        }

        AllNO mymul = new AllNO();
        void Mulfn(AllNO an)
        {
            lblresult.Text = (an.firstnum * an.secondnum).ToString();
        }

        protected void btndivide_Click(object sender, EventArgs e)
        {
            AllNO mynum = new AllNO();
            mynum.firstnum = Convert.ToInt32(txtnum1.Text.Trim());
            mynum.secondnum = Convert.ToInt32(txtnum2.Text.Trim());
            Divfn(mynum);//lblresult.Text=Divfn(mynum);
        }

        AllNO mydiv = new AllNO();
        void Divfn(AllNO an) //public string Divfn(AllNO)
        {
            lblresult.Text = (an.firstnum / an.secondnum).ToString();//return (an.firstnum/an.secondnum).ToString();
        }
    }



    class AllNO
    {
        public int firstnum { get; set; }//property{value};
        public int secondnum { get; set; }

    }
}