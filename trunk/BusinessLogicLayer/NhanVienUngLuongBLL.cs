using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class NhanVienUngLuongBLL
    {
        public NhanVienUngLuongBLL()
        { 
            
        }

        public List<NhanVienUngLuongBE> fetchAll(int thang)
        {
            List<NhanVienUngLuongBE> nhanvien = new List<NhanVienUngLuongBE>();
            
            string query = "select mabl, nv.manv, hoten, ngaysinh, gioitinh, songaydilam, maloainv, luongcoban, ungtruoc, luongconlai " +
                            "from nhanvien as nv, bangluong as bl " +
                            "where nv.manv = bl.manv and thang = " + thang.ToString();

            DataTable dt = SQLHelp.executeQuery(query);

            System.Console.Out.WriteLine(query);

            foreach (DataRow row in dt.Rows)
            {
                NhanVienUngLuongBE nvul = new NhanVienUngLuongBE();

                nvul.HoTen = row["HOTEN"].ToString();
                nvul.NgaySinh = row["NGAYSINH"].ToString();
                nvul.GioiTinh = row["GIOITINH"].ToString();
                nvul.LoaiNhanVien = (int)row["MALOAINV"];
                nvul.SoNgayDiLam = (int)row["SONGAYDILAM"];
                nvul.LuongCoBan = float.Parse(row["LUONGCOBAN"].ToString());
                nvul.TamUng = float.Parse(row["UNGTRUOC"].ToString());
                nvul.TongLuong = float.Parse(row["LUONGCONLAI"].ToString());
                nvul.MaNhanVien = (int) row["MANV"];
                nvul.MaBangLuong = (int)row["MABL"];

                nhanvien.Add(nvul);
            }

            return nhanvien;
        }

        public void updateTamUng(NhanVienUngLuongBE nvul)
        {
            
            string query = "update bangluong "+
                            "set ungtruoc = " + nvul.TamUng.ToString() +","+
                            "luongconlai = (" + nvul.LuongCoBan.ToString() + " - " + nvul.TamUng.ToString() + ") " +
                            "where manv = "+ nvul.MaNhanVien.ToString() +" and mabl = " + nvul.MaBangLuong.ToString();
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }
    }
}
