using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient ;
using System.Windows.Forms;

/*
 * Lớp dùng dể kết nối cơ sở dữ liệu 
 * 
 * 
 * 
 * /
 */



// Lớp kết nối cơ sở dữ liệu
namespace DataAccessLayer
{
    public class BaseDao
    {
        public static SqlConnection sqlCon;
        static string strCon;
        static string _strError = "";

        public static void staticConnection()
        {
            string data = "QLCHVLXD";
            strCon = "server=(local);database=" + data;
            strCon += ";Integrated Security=SSPI;";
            sqlCon = new SqlConnection();
        }

        /*
         * 
         * */
        public static string strError
        {
            get { return _strError; }
        }

        /*
         * 
         * */
        public static void OpenConnection()
        {
            staticConnection();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.ConnectionString = strCon;
            try
            {
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                _strError = "Loi mo connection: " + ex.ToString();
            }
        }

        /*
         * 
         * */
        public static void CloseConnection()
        {
            sqlCon.Close();
            sqlCon.Dispose();
        }

        public static DataTable ExecuteDataTable(string sql, CommandType commandType, params object[] pars)
        {
            BaseDao.OpenConnection();

            SqlCommand com = new SqlCommand(sql, BaseDao.sqlCon);
            com.CommandType = commandType;

            for (int i = 0; i < pars.Length; i += 2)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                com.Parameters.Add(par);
            }

            SqlDataAdapter dad = new SqlDataAdapter(com);

            DataTable dataTable = new DataTable();
            dad.Fill(dataTable);

            BaseDao.CloseConnection();

            return dataTable;
        }

        public static void ExceuteNonQuery(string sql, CommandType commandType, params object[] pars)
        {
            BaseDao.OpenConnection();

            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = commandType;
            for (int i = 0; i < pars.Length; i += 2)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                com.Parameters.Add(par);
            }

            com.ExecuteNonQuery();

            BaseDao.CloseConnection();
        }

        
    }
    

}
