using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 09/01/2010 
* Modified by: Nguyen Van B
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace DataAccessLayer
{
    public class KhachHangDAL
    {
        public void themKhachHang(BusinessEntities.KhachHangBE khachHang)
        {
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[khachhang]([makh],[tenkh],[cmnd],[diachi],[sodienthoai],[gioitinh],[loaikhachhang])"
                                + "VALUES ('"+ khachHang.maKhachHang + "' ,N'" + khachHang.tenKhachHang + "' ,'' ,N'" + khachHang.diaChi+ "',' " + khachHang.soDienThoai + "','','')";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public List<BusinessEntities.KhachHangBE> getListKhachHang()
        {
            List<BusinessEntities.KhachHangBE> listKhachHang = new List<BusinessEntities.KhachHangBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM KHACHHANG");

            BusinessEntities.KhachHangBE khachHang;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (DataRow row in dataTable.Rows)
            {
                khachHang = new BusinessEntities.KhachHangBE();

                khachHang.maKhachHang = row["MAKH"].ToString();
                khachHang.tenKhachHang = row["TENKH"].ToString();
                khachHang.diaChi = row["DIACHI"].ToString();
                khachHang.soDienThoai = row["SODIENTHOAI"].ToString();

                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public BusinessEntities.KhachHangBE getKhachHang(String maKhachHang)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT * FROM KHACHHANG WHERE MAKH = '" + maKhachHang + "' and LOAIKHACHHANG = 1");

            BusinessEntities.KhachHangBE khachHang = null;

            foreach (DataRow row in dt.Rows)
            {
                khachHang  = new BusinessEntities.KhachHangBE();
                khachHang.maKhachHang = row["MAKH"].ToString();
                khachHang.tenKhachHang = row["TENKH"].ToString(); 
                khachHang.diaChi = row["DIACHI"].ToString();
                khachHang.soDienThoai = row["SODIENTHOAI"].ToString();
            }

            return khachHang;
        }
        public void themKhachHangThanThiet(BusinessEntities.KhachHangBE khachHang)
        {
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[khachhang]([makh],[tenkh],[cmnd],[diachi],[sodienthoai],[gioitinh],[loaikhachhang])"
                                + "VALUES ('" + khachHang.maKhachHang + "' , '" + khachHang.tenKhachHang 
                                + "' , '" + khachHang.CMND+"' , '"+khachHang.diaChi + "',' " + khachHang.soDienThoai + "' , '"+khachHang.gioiTinh+"',1)";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public List<BusinessEntities.KhachHangBE> getListKhachHangThanThiet()
        {
            List<BusinessEntities.KhachHangBE> listKhachHang = new List<BusinessEntities.KhachHangBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM KHACHHANG");

            BusinessEntities.KhachHangBE khachHang;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (DataRow row in dataTable.Rows)
            {
                khachHang = new BusinessEntities.KhachHangBE();

                khachHang.maKhachHang = row["MAKH"].ToString();
                khachHang.tenKhachHang = row["TENKH"].ToString();
                khachHang.CMND = row["CMND"].ToString();
                khachHang.diaChi = row["DIACHI"].ToString();
                khachHang.soDienThoai = row["SODIENTHOAI"].ToString();
                khachHang.gioiTinh = row["GIOITINH"].ToString();
                khachHang.loaiKhachHang = (int) row["LOAIKHACHHANG"];
                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public BusinessEntities.KhachHangBE getKhachHangThanThiet(String maKhachHang)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT * FROM KHACHHANG WHERE MAKH = '" + maKhachHang + "'");

            BusinessEntities.KhachHangBE khachHang = null;

            foreach (DataRow row in dt.Rows)
            {
                khachHang = new BusinessEntities.KhachHangBE();
                khachHang.maKhachHang = row["MAKH"].ToString();
                khachHang.tenKhachHang = row["TENKH"].ToString();
                khachHang.CMND = row["CMND"].ToString();
                khachHang.diaChi = row["DIACHI"].ToString();
                khachHang.soDienThoai = row["SODIENTHOAI"].ToString();
                khachHang.gioiTinh = row["GIOITINH"].ToString();
                khachHang.loaiKhachHang = (int)row["LOAIKHACHHANG"];
            }

            return khachHang;
        }
    }
}
