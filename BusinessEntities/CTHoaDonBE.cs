using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 07/01/2010 
* Modified by: Nguyen Van B
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 


namespace BusinessEntities
{
    public class CTHoaDonBE
    {
        public String maCTHD = "";
        public String maHD = "";
        public int maLoaiSP;
        public int maSP ;
        public int soLuong;
        public float donGia;
        public int maNhanVien;
        public String maKhachHang = "";
        public float tongTien;
        public float chietKhau;
        public float tienTra;
        public float tienNo;
        public float thanhTien;
        public String ngayLapHoaDon = "";
        public int giaoHang;
        public String tenKhachHang = "";
        public String diaChi = "";
        public String soDienThoai = "";
        public int loaiKhachHang ;


        public String MaCTHD
        {
            get { return this.maCTHD; }
            set 
            {
                if (value == "")
                    throw new Exception("Mã chi tiết hóa đơn rỗng!");
                this.maCTHD = value;                
            }
        }

        public String MaHD
        {
            get { return this.maHD; }
            set
            {
                if (value == "")
                    throw new Exception("Mã hóa đơn rỗng!");
                this.maHD = value;
            }
        }

        public int MaLoaiSP
        {
            get { return this.maLoaiSP; }
            set
            {
                if (value == 0)
                    throw new Exception("Mã loại sản phẩm rỗng!");
                this.maLoaiSP = value;
            }
        }

        public int MaSP
        {
            get { return this.maSP; }
            set
            {                
                if (value == 0)
                    throw new Exception("Mã sản phẩm rỗng!");
                this.maSP = value;
            }
        }

        public int SoLuong
        {
            get { return this.soLuong; }
            set 
            {
                if (value == 0)
                    throw new Exception("Số lượng = 0");
                this.soLuong = value;
            }
        }

        public float DonGia
        {
            get { return this.donGia; }
            set
            {
                if (value == 0)
                    throw new Exception("Số lượng rỗng");
                this.donGia = value;
            }
        }

        public int MaNhanVien
        {
            get { return this.maNhanVien; }
            set { this.maNhanVien = value;}
        }

        public String MaKhachHang
        {
            get { return this.maKhachHang; }
            set { this.maKhachHang = value; }
        }

        public float TongTien
        {
            get { return this.tongTien; }
            set {this.tongTien = value;}
        }

        public float ChietKhau
        {
            get { return this.chietKhau; }
            set { this.chietKhau = value; }
        }

        public float TienTra
        {
            get { return this.tienTra; }
            set { this.tienTra = value; }
        }

        public float TienNo
        {
            get { return this.tienNo; }
            set { this.tienNo = value; }
        }

        public String NgayLapHoaDon
        {
            get { return this.ngayLapHoaDon; }
            set { this.ngayLapHoaDon = value; }
        }

        public int GiaoHang
        {
            get { return this.giaoHang; }
            set { this.giaoHang = value; }
        }

        public String TenKhachHang
        {
            get { return this.tenKhachHang; }
            set { this.tenKhachHang = value; }
        }

        public String DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        public String SoDienThoai
        {
            get { return this.soDienThoai; }
            set { this.soDienThoai = value; }
        }

        public int LoaiKhachHang
        {
            get { return this.loaiKhachHang; }
            set { this.loaiKhachHang = value; }
        }

        public float ThanhTien
        {
            get { return this.thanhTien; }
            set { this.thanhTien = value; }
        }

    }
}
