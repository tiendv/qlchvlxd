using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class tbCTHD
    {
        public String maCTHD = "";
        public String maHD = "";
        public int maLoaiSP;
        public int maSP ;
        public int soLuong;
        public float donGia;

        //public tbCTHD(String maCTHD, String maLoaiSP, String maSP, int soLuong, float donGia)
        //{
        //    this.maCTHD = maCTHD;
        //    this.maLoaiSP = maLoaiSP;
        //    this.maSP = maSP;
        //    this.soLuong = soLuong;
        //    this.donGia = donGia;
        //}

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
    }
}
