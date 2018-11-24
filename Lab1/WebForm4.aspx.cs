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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvDOCK_Load(object sender, EventArgs e)
        {
            DBProc.FillDock();
            GvDOCK.DataSource = DBProc.documents;
            GvDOCK.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string queryAdd = "INSERT INTO DOCK (NAM_DOCK, NOM) VALUES ('" + textvvod.Text + "', ID_DOCK)";
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryAdd, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvDOCK_Load(sender, e);
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvDOCK.SelectedRow;
            int ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            string queryDel = "Delete  from DOCK where ID_DOCK = " + ID_KOMPSOVM;
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryDel, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvDOCK_Load(sender, e);
        }

        protected void update_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvDOCK.SelectedRow;
            string id = row.Cells[1].Text;
            string query = "update DOCK set NAM_DOCK = '" + textvvod.Text + "' where ID_DOCK = " + id;
            DBProc.sql.Open();
            SqlCommand cmd = new SqlCommand(query, DBProc.sql);
            cmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvDOCK_Load(sender, e);
        }
    }
}