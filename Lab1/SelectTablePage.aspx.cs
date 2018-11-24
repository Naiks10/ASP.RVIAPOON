using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class SelectTablePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (WebForm7.role)
            {
                case (1):
                    treak(true, true, true, true, true);
                    break;
                case (2):
                    treak(true, true, false, false, true);
                    break;
                case (4):
                    treak(false, false, false, false, false);
                    break;
            }
        }
        public void treak(bool Dock, bool SOV_KOMP, bool LIZ, bool Sost, bool SOVM)
        {
            btDock.Visible = Dock;
            btLIZ.Visible = LIZ;
            btSOST.Visible = Sost;
            btSOVM.Visible = SOVM;
            btSOVMK.Visible = SOV_KOMP;
        }

        protected void btSOVMK_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7.aspx");
        }
    }
}
