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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Registratiion = "INSERT INTO Authoriz(User_Login, User_Pass, Access, Role_id) VALUES('" + Login.Text + "', '" + Pw.Text + "', 0, 4)";
            string CountLogin1 = "SELECT COUNT(User_Login) FROM Authoriz WHERE  User_Login  = '" + Login.Text + "'";
            DBProc.sql.Open();
            SqlCommand cmdLogin1 = new SqlCommand(CountLogin1, DBProc.sql);
            SqlCommand cmdRegistr1 = new SqlCommand(Registratiion, DBProc.sql);
            int count1 = Convert.ToInt32(cmdLogin1.ExecuteScalar());

            if (count1 > 0)
            {
                Response.Write("<script>window.alert('Такая учётная запись уже существует');</script>");
            }
            else
            {
                cmdRegistr1.ExecuteNonQuery();
                Response.Write("<script>window.alert('Мы всегда рады видеть новых сотрудников в нашем коллективе, ныне ваша учтная запись неактивирована, обратитесь к сис. администратору для активации вашей учётной записи');</script>");
            }

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7.aspx");
        }
    }
}