using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class PhieuGiaoHangDAL
    {
        public BusinessEntities.CTHoaDonBE getHoaDon(String maHoaDon)
        {
            BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM hoadon, cthoadon, khachhang WHERE hoadon.mahd = cthoadon.mahd and khachhang.makh = hoadon.makh and hoadon.mahd = '" + maHoaDon + "'");

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

        public BusinessEntities.PhieuGiaoHangBE getPhieuGiaoHang()
        {
            BusinessEntities.PhieuGiaoHangBE phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM PHIEUGIAOHANG");

            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();

                phieuGiaoHang.maPhieuGiaoHang = row["magh"].ToString();
                phieuGiaoHang.maHoaDon = row["mahd"].ToString();
                phieuGiaoHang.ngayGiaoHang = row["ngaygiao"].ToString();
                phieuGiaoHang.chiPhi = float.Parse(row["chiphi"].ToString());                
            }

            return phieuGiaoHang;
        }

        public List<BusinessEntities.PhieuGiaoHangBE> getlistPhieuGiaoHang()
        {
            List<BusinessEntities.PhieuGiaoHangBE> listPhieuGiaoHang = new List<BusinessEntities.PhieuGiaoHangBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM PHIEUGIAOHANG");

            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            BusinessEntities.PhieuGiaoHangBE phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();

            foreach (DataRow row in dataTable.Rows)
            {
                phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();

                phieuGiaoHang.maPhieuGiaoHang = row["magh"].ToString();
                phieuGiaoHang.maHoaDon = row["mahd"].ToString();
                phieuGiaoHang.ngayGiaoHang = row["ngaygiao"].ToString();
                phieuGiaoHang.chiPhi = float.Parse(row["chiphi"].ToString());

                listPhieuGiaoHang.Add(phieuGiaoHang);
            }

            return listPhieuGiaoHang;
        }

        public void themPhieuGiaoHang(BusinessEntities.PhieuGiaoHangBE phieuGiaoHang)
        {
            

            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[phieugiaohang]([magh],[mahd],[ngaygiao] ,[chiphi])" 
                                + "VALUES('" + phieuGiaoHang.maPhieuGiaoHang + "','" + phieuGiaoHang.maHoaDon + "','" + phieuGiaoHang.ngayGiaoHang + "'," + phieuGiaoHang.chiPhi + ")";
            SQLHelp.executeNonQuery(myAddQuery);
         
        }
    }

}
