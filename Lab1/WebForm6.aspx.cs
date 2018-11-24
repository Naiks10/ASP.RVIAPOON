using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1Standart;

namespace Lab1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvSOST_Load(object sender, EventArgs e)
        {
            DBProc.FillSost();
            GvSOST.DataSource = DBProc.sost;
            GvSOST.DataBind();
        }
    }
}