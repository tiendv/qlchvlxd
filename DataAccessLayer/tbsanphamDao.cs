using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Data.OleDb;
using BusinessEntities;


namespace DataAccessLayer
{
    public class tbsanphamDao:BaseDao
    {
                public SqlDataAdapter daMT;
        //constructor///////////////////////////////////
        
        public tbsanphamDao(): base()
        {
        }

/// Lấy tất cả Sản phẩm trong bảng
/// </summary>
/// <returns>Danh sách Sản Phẩm </returns>
        public DataSet getAllSanPham()
        {
           
                DataSet ds = new DataSet();
                daMT = new SqlDataAdapter("select * from user", conn);
                daMT.Fill(ds, "demo");

                return ds;
          
        }        

    }
}
