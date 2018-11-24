using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Lab1Standart;

namespace Lab1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvLIZ_Load(object sender, EventArgs e)
        {
            DBProc.FillLiz();
            GvLIZ.DataSource = DBProc.license;
            GvLIZ.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string queryAdd = "INSERT INTO LIZ (LIZ) VALUES ('" + textvvod.Text + "')";
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryAdd, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvLIZ_Load(sender, e);
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvLIZ.SelectedRow;
            int ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            string queryDel = "Delete  from LIZ where ID_LIZ = " + ID_KOMPSOVM;
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryDel, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvLIZ_Load(sender, e);
        }
    }
}