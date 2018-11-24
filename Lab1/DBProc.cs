using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Lab1;
using System.Windows.Forms;

namespace Lab1Standart
{
    public class DBProc
    {
        public static string exp = "ASC";
        //Организация подключения
        public static SqlConnection sql = new SqlConnection("Data Source = DESKTOP-12BNNTQ\\RVO; " +
        "Initial Catalog = ZAK_base; " +
        "Persist Security Info = True; User ID = sa; Password=\"123\"");
        //---------------------------------------------------------------------

        //Вирутальные таблицы
        public static DataTable documents = new DataTable();
        public static DataTable instruments = new DataTable();
        public static DataTable components = new DataTable();
        public static DataTable license = new DataTable();
        public static DataTable model = new DataTable();
        public static DataTable programSoft = new DataTable();
        public static DataTable sotrudniki = new DataTable();
        public static DataTable compatibility = new DataTable();
        public static DataTable compatibilityComponents = new DataTable();
        public static DataTable order = new DataTable();
        public static DataTable sost = new DataTable();
        //-----------------------------------------------------------------------

        //SQL - запроосы
        public static string queryDock = "SELECT ID_DOCK AS 'КОД', " +
            "NAM_DOCK AS 'Документ', " +
            "NOM AS 'Номер' FROM DOCK";
        public static string queryInstr = "SELECT  ID_INSTR AS 'КОД'," +
            "Type_Instr as 'Интсрумент', " +
            "sost_value as 'Состояние' from instr " +
            "join sost on id_sost = sost_id";
        public static string queryKomp = "SELECT ID_KOMP AS 'Код', " +
            "NAM_KOMP as ' Комлектующее', " +
            "SOV_KOMP as  'Совместимость' " +
            "FROM KOMP " +
            "JOIN SOVM_KOMP on ID_SOVM_KOMP = SOVM_KOMP_ID";
        public static string queryLiz = "SELECT ID_LIZ AS 'Код', LIZ AS 'Лицензия' FROM LIZ";
        public static string queryModel = "SELECT ID_MODEL AS 'Код', " +
            "Mark as 'Марка'," +
            " MOD as 'Модель', " +
            "Kod_Nam as 'Кодовое название', " +
            "Serial as 'Серия', " +
            "Num  as 'Номер', " +
            "Nam_komp as 'Комплектующие', " +
            "Po as 'ПО' FROM MODEL " +
            "Join Komp on id_komp = komp_id " +
            "Join PO on id_po = po_id";
        public static string queryProgramSoft = "SELECT ID_PO AS 'Код', " +
            "PO as 'ПО', " +
            "VER_PO as 'Версия ПО', " +
            "LIZ as 'Лицензия', " +
            "SOVM as 'Совместимость' FROM PO " +
            "JOIN LIZ on ID_LIZ = LIZ_ID " +
            "JOIN SOVM on ID_SOVM  = SOVM_ID";
        public static string querySotr = "SELECT  " +
            "FAM_SOTR as 'Фамилия', " +
            "IM_SOTR AS 'Имя', " +
            "OTCH_SOTR as 'Отчество', " +
            "TYPE_INSTR as 'Инструмент', " +
            "NAM_DOCK as 'Документ' FROM SOTR " +
            "JOIN DOCK ON ID_DOCK = DOCK_id " +
            "JOIN INSTR ON ID_INSTR = INSTR_id";
        public static string queryCompatibility = "SELECT ID_SOVM AS 'Код',  SOVM AS 'Совместимость' FROM SOVM";
        public static string queryCompatibilityComponents = "SELECT id_SOVM_KOMP AS 'Код', SOV_KOMP AS 'Совместимость комлектующих' FROM SOVM_KOMP";
        public static string queryOrder = "SELECT  " +
            "NOM_ZAK as 'Номер заказа', " +
            "Dat_NACH as 'Дата начала', " +
            "Dat_Konz as 'Дата окончания', " +
            "Fam_Sotr as 'Сотрудник', " +
            "Mod as 'Модель'  FROM ZAK " +
            "join sotr on id_sotr = sotr_id " +
            "join model on id_model = model_id";
        public static string querySost = " SELECT ID_SOST AS 'Код',  SOST_VALUE as 'Состояние'  FROM SOST";

        

        //--------------------------------------------------------------------------

        static void Main(string[] args)
        {
            //Именование таблиц
            documents.TableName = "documenti";
            instruments.TableName = "instrumenti";
            components.TableName = "componenti";
            license.TableName = "lizenzia";
            model.TableName = "model";
            programSoft.TableName = "obespechenie";
            sotrudniki.TableName = "sotrudniki";
            compatibility.TableName = "sovmest";
            compatibilityComponents.TableName = "complectuyichie sovmest";
            order.TableName = "zakazi";
            sost.TableName = "sost";
            //------------------------------------------------------------------         
            Console.ReadKey();

        
              
        }

        public static void FillData(string query, DataTable table)
        {
            
            //Открываем соединения
            table.Clear();
            sql.Open();
            SqlCommand command = new SqlCommand(query, sql);
            SqlDataReader dataReader = command.ExecuteReader();

            table.Load(dataReader);
            dataReader.Close();
            Console.WriteLine(table.TableName.ToString() + " заполнена");
            sql.Close();
            //закрываем соединения
        }
        public static void FillDock()
        {
            FillData(queryDock, documents); //документы
        }

        public static void Filtr(string query)
        {
            FillData(query, compatibility); //документы
        }

        public static void FillInstr()
        {
            FillData(queryInstr, instruments); //инструменты
        }

        public static void AddRowSovm(System.String textInsert, System.String Table, System.String Column)
        {
            System.String queryAdd = "INSERT INTO "+Table+" ("+Column+") VALUES ('" + textInsert + "')";
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryAdd, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close();
        }

        public static void DelRowSovm(System.Int32 ID, System.String Table, System.String Column)
        {

            string queryDel = "DELETE FROM "+Table+" WHERE "+Column+" =" + ID;//"Delete  from "+ Table +" where "+ Column +" = " + 25;
            DBProc.sql.Open();
            SqlCommand sqlcmd = new SqlCommand(queryDel, DBProc.sql);
            sqlcmd.ExecuteNonQuery();
            DBProc.sql.Close(); 
        }

        public static void UpdRowSovm(System.Int32 ID, System.String Table, System.String PrimaryColumn, System.String Column, System.String textInsert)
        {

            string query = "update "+Table+" set "+ Column +" = '" + textInsert + "' where "+ PrimaryColumn +" = " + ID;
            string queryCount = "select COUNT(*) FROM " + Table + " WHERE" + Column + "='" + textInsert + "'";
            DBProc.sql.Open();
            SqlCommand cmd = new SqlCommand(query, DBProc.sql);
            SqlCommand cmdCount = new SqlCommand(queryCount, DBProc.sql);
            if (cmd.ExecuteNonQuery() == 0)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Test");
            }
                DBProc.sql.Close();
        }

        public static void SearchValue(System.String InsertText, GridView gridView)
        {
            foreach (GridViewRow row in gridView.Rows)
            {
                if (row.Cells[2].Text.Equals(InsertText))
                    
                {
                    row.BackColor = System.Drawing.Color.DarkGray;
                }
                else
                {
                    row.BackColor = System.Drawing.Color.White;
                }
            }
        }

        public static void FilterValue(SqlDataSource sqlDataSource, string Query, string Column, string TextInsert, GridView gridView )
        {
            sqlDataSource.ConnectionString = sql.ConnectionString;
            sqlDataSource.SelectCommand = Query +
                " where ("+ Column +" like '%" + TextInsert + "%')";
            sqlDataSource.DataSourceMode = SqlDataSourceMode.DataReader;
            gridView.DataSource = sqlDataSource;
            gridView.DataBind();
        }

        public static void sort(object sender, GridViewSortEventArgs e, SqlDataSource sqlDataSource, string query, GridView gridView)
        {
            string header = e.SortExpression;
                header = "SOV_KOMP";
            switch (exp)
            {
                case ("ASC"):
                    exp = "DESC";
                    break;
                case ("DESC"):
                    exp = "ASC";
                    break;
            }
            sqlDataSource.ConnectionString = sql.ConnectionString;
            sqlDataSource.SelectCommand = query + " order by " + header + " " + exp;
            sqlDataSource.DataSourceMode = SqlDataSourceMode.DataReader;
            gridView.DataSource = sqlDataSource;
            gridView.DataBind();
        }

        public static void Authoriz(string User, string Pass)
        {
            
            sql.Open();
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "select  id_Authoriz from Authoriz  where User_Login = '"+User+"' and User_Pass = '"+Pass+"'";

                session.ID_User =  Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = " select [dbo].[Role].[DOCK_Access] " +
                "from [dbo].[Authoriz] join [dbo].[Role] " +
                "on [dbo].[Authoriz].[Role_ID] = [dbo].[Role].[ID_Role] " +
                "where  [dbo].[Authoriz].[ID_Authoriz] = " + session.ID_User.ToString();
                session.Dock = Convert.ToInt32(command.ExecuteScalar().ToString());

                command.CommandText = " select [dbo].[Role].[SOV_KOMP_Access] " +
               "from [dbo].[Authoriz] join [dbo].[Role] " +
               "on [dbo].[Authoriz].[Role_ID] = [dbo].[Role].[ID_Role] " +
               "where  [dbo].[Authoriz].[ID_Authoriz] = " + session.ID_User.ToString();
                session.SovmKomp = Convert.ToInt32(command.ExecuteScalar().ToString());

                command.CommandText = " select [dbo].[Role].[SOVM_Access] " +
               "from [dbo].[Authoriz] join [dbo].[Role] " +
               "on [dbo].[Authoriz].[Role_ID] = [dbo].[Role].[ID_Role] " +
               "where  [dbo].[Authoriz].[ID_Authoriz] = " + session.ID_User.ToString();
                session.Sovm = Convert.ToInt32(command.ExecuteScalar().ToString());

                command.CommandText = " select [dbo].[Role].[LIZ_Access] " +
               "from [dbo].[Authoriz] join [dbo].[Role] " +
               "on [dbo].[Authoriz].[Role_ID] = [dbo].[Role].[ID_Role] " +
               "where  [dbo].[Authoriz].[ID_Authoriz] = " + session.ID_User.ToString();
                session.Liz = Convert.ToInt32(command.ExecuteScalar().ToString());

                command.CommandText = " select [dbo].[Role].[SOST_Access] " +
               "from [dbo].[Authoriz] join [dbo].[Role] " +
               "on [dbo].[Authoriz].[Role_ID] = [dbo].[Role].[ID_Role] " +
               "where  [dbo].[Authoriz].[ID_Authoriz] = " + session.ID_User.ToString();
                session.Sost = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch
            {

            }
            finally
            {
                sql.Close();
            }
        }

        public static void FillKomp()
        {
            FillData(queryKomp, components); //компоненты
        }

        public static void FillLiz()
        {
            FillData(queryLiz, license); //лицензия
        }

        public static void FillModel()
        {
            FillData(queryModel, model); //модель
        }

        public static void FillPS()
        {
            FillData(queryProgramSoft, programSoft); //ПО
        }

        public static void FillSotr()
        {
            FillData(querySotr, sotrudniki); //Сотрудники
        }

        public static void FillComp()
        {
            FillData(queryCompatibility, compatibility); //совместимость
        }

        public static void FillCompSovm()
        {
            FillData(queryCompatibilityComponents, compatibilityComponents); //совместимость комплектующих
        }

        public static void FillOrder()
        {
            FillData(queryOrder, order); // заказы
        }

        public static void FillSost()
        {
            FillData(querySost, sost); // заказы
        }
    }
}