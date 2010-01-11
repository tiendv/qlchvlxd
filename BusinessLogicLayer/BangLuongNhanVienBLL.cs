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

            string query = "SELECT MABL, HOTEN, SONGAYDILAM, LUONGCOBAN, UNGTRUOC, LUONGCONLAI " +
                            "FROM NHANVIEN AS NV, BANGLUONG AS BL " +
                            "WHERE NV.MANV = BL.MANV";

            dt = SQLHelp.executeQuery(query);
            System.Console.Out.WriteLine(query);
            foreach (DataRow row in dt.Rows)
            {
                BangLuongNhanVienBE blnv = new BangLuongNhanVienBE();

                blnv.MaBL = row["MABL"].ToString();
                blnv.HotenNV = row["HOTEN"].ToString();
                blnv.NgayDiLam = (int) row["SONGAYDILAM"];
                blnv.LuongCB = float.Parse(row["LUONGCOBAN"].ToString());
                blnv.TamUng = float.Parse(row["UNGTRUOC"].ToString());
                blnv.TongLuong = float.Parse(row["LUONGCONLAI"].ToString());            
                
                System.Console.Out.WriteLine(blnv.HotenNV);
                listBangLuongNhanVien.Add(blnv);
            }

            return listBangLuongNhanVien;
        }
        public BangLuongNhanVienBE searchBangLuong(int maNV, int maBL)
        {
            BangLuongNhanVienBE blnv = new BangLuongNhanVienBE();
            string query = "select * from bangluong where mabl = "+ maBL.ToString() +" and manv = " + maNV.ToString() ;
            DataTable dt = SQLHelp.executeQuery(query);
            System.Console.Out.WriteLine(query);
            foreach (DataRow row in dt.Rows)
            { 
                blnv.MaNV = (int)row["MANV"];
                blnv.MaBL = row["MABL"].ToString();
                //blnv.HotenNV = row["HOTEN"].ToString();
                blnv.NgayDiLam = (int)row["SONGAYDILAM"];
                blnv.LuongCB = float.Parse(row["LUONGCOBAN"].ToString());
                blnv.TamUng = float.Parse(row["UNGTRUOC"].ToString());
                blnv.TongLuong = float.Parse(row["LUONGCONLAI"].ToString());
            }
            return blnv;
        }

        public void updateSoNgayDiLam(BangLuongNhanVienBE bl)
        {
            string query = "update bangluong "+
                            "set songaydilam = "+ bl.NgayDiLam.ToString() +" - 1, "+
	                        "luongconlai = ("+ bl.TongLuong.ToString() +" - 200000)"+
                            "where manv = "+ bl.MaNV.ToString() +" and mabl = " + bl.MaBL.ToString();
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }
        public void delectBangLuong(NhanVienBE nv)
        {
            string query = "delete from bangluong "+
                            "where manv = "+ nv.MaNV.ToString();
            SQLHelp.executeNonQuery(query);
        }
    }
}
