using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccessLayer
{
    public class GiaoHangDAL
    {
        public BusinessEntities.CTHoaDonBE getHoaDon(String maHoaDon)
        {
            BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM hoadon, cthoadon, khachhang WHERE hoadon.mahd = cthoadon.mahd AND hoadon.mahd = '" + maHoaDon + "'");

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (DataRow row in dataTable.Rows)
            {
                hoaDon = new BusinessEntities.CTHoaDonBE();

                hoaDon.tenKhachHang = row["tenkh"].ToString();
                hoaDon.maKhachHang = row["makh"].ToString();
                hoaDon.diaChi = row["diachi"].ToString();
                hoaDon.soDienThoai = row["sodienthoai"].ToString();
                hoaDon.loaiKhachHang = (int)row["loaikhachhang"];
                hoaDon.maCTHD = row["macthd"].ToString();
               
                hoaDon.tongTien = float.Parse(row["tongtien"].ToString());            
            }

            return hoaDon;
        }
    }
}
