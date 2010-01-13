using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DangNhapDAL
    {
        public DangNhapDAL()
        { 
        
        }
        public DataTable dangNhap(int maNhanVien, string matkhau)
        {
            DataTable dt = new DataTable();
            string query = "select manv, matkhau, maloainv from nhanvien " +
                            "where manv = "+ maNhanVien.ToString() +" and matkhau = '"+ matkhau +"'";
            System.Console.Out.WriteLine(query);
            dt = SQLHelp.executeQuery(query);
            return dt;
           
        }
    }
}
