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
        /*
        public string serverName = "(local)\\SQLEXPRESS";
        public string databaseName="demo";
        public string userName = "TIENDV-PC";
       
        public string  passWord;
        public Boolean test = true;
         */


        protected SqlConnection  conn;//khai báo đối tượng kết nối, khai báo protected: chỉ cho những class thừa kế sử dụng
        public BaseDao()
        {
            try
            {
                string connectionString = @"server= TIENDV-PC\SQLEXPRESS;";
                connectionString += "database=demo;";
                connectionString += "Integrated Security=true;";
                connectionString += "uid=tiendv-PC\tiendv;password=;";
                conn = new SqlConnection(connectionString);
                conn.Open();// mở kết nối
            }

         catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message ,
                    "Lỗi Kết Nối",MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        
    }
    

}
