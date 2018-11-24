using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Lab1Standart;

namespace Lab1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvSOVM_Load(object sender, EventArgs e)
        {
            DBProc.FillComp();
            GvSOVM.DataSource = DBProc.compatibility;
            GvSOVM.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            
                string queryAdd = "INSERT INTO SOVM (SOVM) VALUES ('" + textvvod.Text + "')";
                DBProc.sql.Open();
                SqlCommand sqlcmd = new SqlCommand(queryAdd, DBProc.sql);
                sqlcmd.ExecuteNonQuery();
                DBProc.sql.Close();
                GvSOVM_Load(sender, e);
            
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvSOVM.SelectedRow;
            int ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            string queryDel = "Delete  from SOVM where ID_SOVM = " + ID_KOMPSOVM;
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryDel, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvSOVM_Load(sender, e);
        }

        protected void update_Click(object sender, EventArgs e)
        {
            GridViewRow row = GvSOVM.SelectedRow;
            string id = row.Cells[1].Text;
            string query = "update SOVM_KOMP set SOV_KOMP = '" + textvvod.Text + "' where ID_SOVM_KOMP = " + id;
            DBProc.sql.Open();
            SqlCommand cmd = new SqlCommand(query, DBProc.sql);
            cmd.ExecuteNonQuery();
            DBProc.sql.Close();
            GvSOVM_Load(sender, e);
        }

        protected void GvSOVM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvSOVM.SelectedRow;
            int ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            string SOVMKOMP = row.Cells[2].Text;
            textvvod.Text = SOVMKOMP.ToString();
        }

        protected void texBox_TextChanged(object sender, EventArgs e)
        {
            DBProc.SearchValue(texBox.Text, GvSOVM);

        }
    }
}