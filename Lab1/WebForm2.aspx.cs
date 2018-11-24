using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.Data;
using System.Data.SqlClient;
using Lab1Standart;
using System.Windows.Forms;

namespace Lab1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        bool  Sort = false;

        public int ID_KOMPSOVM = 0;
        public string SOVMKOMP = "";
        public string deleteQuery = "";


        //public SqlConnection sql = new SqlConnection("Data Source = ISPEN-IMSHCH-PC\\ISPEN_SERVER; Initial Catalog = RealTimeBase; Persist Security Info = true; User ID = sa; Password = \"best for humanity\"");
        public SqlCommand command = new SqlCommand("SELECT [id_SOVM_KOMP] ,[SOV_KOMP] FROM [dbo].[SOVM_KOMP] ");

        public void MyCSharpClickHandler(Object sender, EventArgs e)
        {
            var size = Request["myHiddenBtn"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Screen.PrimaryScreen.WorkingArea.Width > 600)
            //    GvSOVMKOMP.Width = 700;
            //else if (Screen.PrimaryScreen.WorkingArea.Width < 600 )
            //    GvSOVMKOMP.Width = 350;
            //SqlDependency.Start(DBProc.sql.ConnectionString);
            //using (SqlConnection connect = new SqlConnection(DBProc.sql.ConnectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand(command.CommandText, connect))
            //    {
            //        SqlCacheDependency dependency = new SqlCacheDependency(cmd);
            //        DateTime date = DateTime.Now.AddSeconds(10);
            //        Response.Cache.SetExpires(date);
            //        Response.Cache.SetCacheability(HttpCacheability.Public);
            //        Response.Cache.SetValidUntilExpires(true);
            //        Response.AddCacheDependency(dependency);
            //        connect.Open();
            //        sds.ConnectionString = connect.ConnectionString;
            //        sds.DataSourceMode = SqlDataSourceMode.DataReader;
            //        sds.SelectCommand = cmd.CommandText;
            //        GvSOVMKOMP.DataSource = sds;
            //        GvSOVMKOMP.DataBind();
            //    }
            //}
        }

            
        


            

       

        

        




        protected void GvSOVMKOMP_Load(object sender, EventArgs e)
        {
            DBProc.FillCompSovm();
            GvSOVMKOMP.DataSource = DBProc.compatibilityComponents;
            GvSOVMKOMP.DataBind();
            

        }


        protected void add_Click(object sender, EventArgs e)
        {
            string queryCount = "select COUNT(*) FROM SOVM_KOMP WHERE SOV_KOMP = '" + textvvod.Text + "'";
            DBProc.sql.Open();
            SqlCommand cmdCount = new SqlCommand(queryCount, DBProc.sql);
            int count = Convert.ToInt32(cmdCount.ExecuteScalar());
            DBProc.sql.Close();

            if (textvvod.Text == "" || textvvod.Text.Length >= 30 || count != 0)
            {
                textvvod.Text = count.ToString();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Удостоверьтесь, что поле не пустое или текст не превышает 30 символов, или же не было уже введено');</script>");
            }
            else
            {
                DBProc.AddRowSovm(textvvod.Text, "SOVM_KOMP", "SOV_KOMP");
                GvSOVMKOMP_Load(sender, e);
            }
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Удостоверьтесь, что поле не пустое или текст не превышает 30 символов, или же не было уже введено');</script>");
        }

        protected void delete_Click(object sender, EventArgs e)
        {
           
            GridViewRow row = GvSOVMKOMP.SelectedRow;
            ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            DBProc.DelRowSovm(ID_KOMPSOVM, "SOVM_KOMP", "ID_SOVM_KOMP");
            GvSOVMKOMP_Load(sender, e);
           
        }
        public void GvSOVMKOMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvSOVMKOMP.SelectedRow;
            ID_KOMPSOVM = Convert.ToInt32(row.Cells[1].Text.ToString());
            SOVMKOMP = row.Cells[2].Text;
            textvvod.Text = SOVMKOMP.ToString();
             
        }

        public void delet(Int32 ID)
        {
            
                string queryDel = "Delete  from SOVM_KOMP where ID_SOVM_KOMP = " + ID; 
                DBProc.sql.Open();
                SqlCommand sqlcmd = new SqlCommand(queryDel, DBProc.sql);
                //sample.Text = queryDel;
                sqlcmd.ExecuteNonQuery();
                DBProc.sql.Close();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (textvvod.Text == "" || textvvod.Text.Length >= 30)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Поле пустое или содержит болше 30 символов');</script>");
            }
            else
            {
                GridViewRow row = GvSOVMKOMP.SelectedRow;
                int id = Convert.ToInt32(row.Cells[1].Text);
                DBProc.UpdRowSovm(id, "SOVM_KOMP", "ID_SOVM_KOMP", "SOV_KOMP", textvvod.Text);
                GvSOVMKOMP_Load(sender, e);
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            DBProc.SearchValue(SOVM.Text, GvSOVMKOMP);
        }

        protected void filter_Click(object sender, EventArgs e)
        {
            DBProc.FilterValue(sds,DBProc.queryCompatibilityComponents,"SOV_KOMP",SOVM.Text,GvSOVMKOMP);
        }

        protected void GvSOVMKOMP_Sorting(object sender, GridViewSortEventArgs e)
        {
            Sort = true;
            DBProc.sort(sender, e, sds, DBProc.queryCompatibilityComponents, GvSOVMKOMP);
        }

        protected void GvSOVMKOMP_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectTablePage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page_Load(sender, e);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick2(object sender, EventArgs e)
        {

        }
    }
    }
