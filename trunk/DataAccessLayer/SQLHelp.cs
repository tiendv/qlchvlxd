using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    /* Thuc hien thao tac Connect va truy van voi DB.
    * Author : Huynh Minh Duc
    * Create : Jan 6 2010  
    */
    public class SQLHelp
    {
        private static string connectionString = "Data Source=" + DataResources.NAME_SERVER + "; database=" + DataResources.NAME_DATEBASE + ";Integrated Security=True";
        
        public static void executeNonQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable executeQuery(string query)
        {            
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection connection = new SqlConnection(connectionString);

            //MessageBox.Show(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds);

            connection.Close();            

            return ds.Tables[0];
        }
    }
}
