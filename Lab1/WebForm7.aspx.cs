//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Data.SqlClient;
//using Lab1Standart;

//namespace Lab1
//{
//    public partial class WebForm7 : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Enter_Click(object sender, EventArgs e)
//        {
//            DBProc.Authoriz(Login.Text, Pw.Text);
//            if (session.ID_User != 0)
//            {
//                SqlCommand command = new SqlCommand();
//                command.CommandText = "select COUNT(*) from Authoriz  where User_Login = 'User1' or User_Pass = 'AdminPass'";
//                DBProc.sql.Open();
//                Pass.Text = (command.ExecuteScalar()).ToString();
//                DBProc.sql.Close();
//            }
//            else
//                Pass.Text = session.ID_User.ToString();
//                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Неправильное имя или пароль');</script>");
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using Lab1Standart;

namespace Lab1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        public static int role;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            string CountLogin1 = "SELECT COUNT(User_Login) FROM Authoriz WHERE  User_Login  = '" + Login.Text + "'";
            string CountLogin2 = "SELECT COUNT(User_Pass) FROM Authoriz WHERE User_Pass  = '" + Pw.Text + "'";
            string Role = "SELECT ROle_id FROM Authoriz   WHERE  User_Login  = '" + Login.Text + "'";
            string AccessTest = "SELECT  Access  FROM Authoriz WHERE  User_Login  = '" + Login.Text + "'";
            DBProc.sql.Open();
            SqlCommand cmdLogin1 = new SqlCommand(CountLogin1, DBProc.sql);
            int count1 = Convert.ToInt32(cmdLogin1.ExecuteScalar());
            SqlCommand cmdLogin2 = new SqlCommand(CountLogin2, DBProc.sql);
            int count2 = Convert.ToInt32(cmdLogin2.ExecuteScalar());
            SqlCommand cmdAccess = new SqlCommand(AccessTest, DBProc.sql);
            int count3 = Convert.ToInt32(cmdAccess.ExecuteScalar());
            DBProc.sql.Close();
            if (count1 > 0 && count2 > 0)
            {
                if (count3 == 1)
                {
                    DBProc.sql.Open();
                    SqlCommand cmdRole = new SqlCommand(Role, DBProc.sql);
                    role = Convert.ToInt32(cmdRole.ExecuteScalar());
                    DBProc.sql.Close();
                    Response.Redirect("SelectTablePage.aspx");
                    

                }
                else
                {
                    Response.Write("<script>window.alert('У вас нет доступа или аккаунт не активирован');</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Неверный логин или пароль');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}