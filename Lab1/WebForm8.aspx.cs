using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Lab1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public SqlConnection sql = new SqlConnection("Data Source = DESKTOP-12BNNTQ\\RVO; " +
        "Initial Catalog = RealTimeBase; " +
        "Persist Security Info = True; User ID = sa; Password=\"123\"");
        public SqlCommand command = new SqlCommand("SELECT [id_Human] ,[Fam] ,[Im] ,[Otch] ,[Age] ,[PassSer] ,[PassNow] FROM [dbo].[Human] ");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDependency.Start(sql.ConnectionString);
            using (SqlConnection connect = new SqlConnection(sql.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(command.CommandText, connect))
                {
                    SqlCacheDependency dependency = new SqlCacheDependency(cmd);
                    DateTime date = DateTime.Now.AddSeconds(10);
                    Response.Cache.SetExpires(date);
                    Response.Cache.SetCacheability(HttpCacheability.Public);
                    Response.Cache.SetValidUntilExpires(true);
                    Response.AddCacheDependency(dependency);
                    connect.Open();
                    sds.ConnectionString = connect.ConnectionString;
                    sds.DataSourceMode = SqlDataSourceMode.DataReader;
                    sds.SelectCommand = cmd.CommandText;
                    gv.DataSource = sds;
                    gv.DataBind();
                }
            }

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //UpdatePanel1.Update();
        }
    }
}