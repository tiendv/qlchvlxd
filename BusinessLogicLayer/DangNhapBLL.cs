using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class DangNhapBLL
    {
        DangNhapDAL dal = new DangNhapDAL();

        public DangNhapBLL()
        { 
        
        }
        public DangNhapBE dangNhap(DangNhapBE tk)
        {
            DangNhapBE taikhoan = new DangNhapBE();
            DataTable dt = dal.dangNhap(tk.MaNhanVien, tk.MatKhau);
            System.Console.Out.WriteLine("Tang DataBussiness");
            foreach (DataRow rows in dt.Rows)
            {
                taikhoan.MaNhanVien = (int)rows["manv"];
                taikhoan.MatKhau = rows["matkhau"].ToString();
                taikhoan.MaLoaiNV = (int)rows["maloainv"];
            }
            return taikhoan;
        }
    }
}
