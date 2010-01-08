using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Data.SqlTypes;

namespace BusinessLogicLayer
{
    /*
     * 
     * author : Huynh Minh Duc
     * date : jan 07 2010
     */
    public class BangLuongNhanVienBLL
    {
        public BangLuongNhanVienBLL()
        { 
        
        }
        public List<BangLuongNhanVienBE> viewAllTableSalary()
        {
            List<BangLuongNhanVienBE> listBangLuongNhanVien = new List<BangLuongNhanVienBE>();
            DataTable dt = new DataTable();

            string query = "SELECT MABL, HOTEN, SONGAYDILAM, TIENTHUONG, LUONGCB, TAMUNG, TONGLUONG " +
                            "FROM NHANVIEN AS NV, BANGLUONG AS BL " +
                            "WHERE NV.MANV = BL.MANV";

            dt = SQLHelp.executeQuery(query);
            System.Console.Out.WriteLine(query);
            foreach (DataRow row in dt.Rows)
            {
                BangLuongNhanVienBE blnv = new BangLuongNhanVienBE();
                blnv.MaBL = row["MABL"].ToString();
                blnv.HotenNV = row["HOTEN"].ToString();
                blnv.NgayDiLam = Int16.Parse(row["SONGAYDILAM"].ToString());
                blnv.TienThuong = SqlMoney.Parse(row["LUONGCB"].ToString()).ToDouble();
                blnv.LuongCB = SqlMoney.Parse(row["LUONGCB"].ToString()).ToDouble();
                blnv.TamUng = SqlMoney.Parse(row["TAMUNG"].ToString()).ToDouble();
                blnv.TongLuong = SqlMoney.Parse(row["TONGLUONG"].ToString()).ToDouble();

                System.Console.Out.WriteLine(blnv.HotenNV);
                listBangLuongNhanVien.Add(blnv);
            }

            return listBangLuongNhanVien;
        }
    }
}
