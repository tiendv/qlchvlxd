using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//table sản phẩm

namespace BusinessEntities
{
    public class SanPhamBE
    {
        public int masp;
        public string tensp;
        public float gianhap;
        public float giaban;
        public int soluong;
        public int soluongtoithieu;
        public string mancc="";
        public string thongtin;
        public int donvitinh;
        public int maloaisp ;

        /* / constructor
        public tbsanpham(int masp, string tensp, float gianhap, float giaban,int soluong,int soluongtoithieu, string mancc, string thongtin,string donvitinh, int maloaisp)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.soluong = soluong;
            this.soluongtoithieu = soluongtoithieu;
            this.mancc = mancc;
            this.thongtin = thongtin;
            this.donvitinh = donvitinh;
            this.maloaisp = maloaisp;
       
        }
       */
        public int MASP
        {
            get { return this.masp; }
            set
            {
                
                if (value == 0)
                    throw new Exception("Mã sản phẩm rỗng !");
                this.masp = value;
            }
        }
        public string TENSP 
        {
            get { return this.tensp; }
            set
            {
                
                if (value == "")
                    throw new Exception("Tên sản phẩm rỗng !");
                this.tensp = value;
            }
        }
        public float GIANHAP
        {
            get { return this.gianhap; }
            set
            {
                
                if (value ==0 )
                    throw new Exception("Giá nhập rỗng !");
                this.gianhap= value;
            }
        }
        public float GIABAN
        {
            get { return this.giaban; }
            set
            {
                
                if (value == 0)
                    throw new Exception("Giá Bán rỗng !");
                this.giaban = value;
            }
        }
        public int SOLUONG
        {
            get { return this.soluong; }
            set
            {

                if (value == 0)
                    throw new Exception("Số lượng rỗng !");
                this.soluong = value;
            }
        }

        public int SOLUONGTOITHIEU
        {
            get { return this.soluongtoithieu; }
            set
            {
               
                if (value == 0)
                    throw new Exception("Mức nhập vào không được bỏ trống");
                this.soluongtoithieu = value;
            }
        }
        // Nhà cung cấp liên quan đến sản phẩm bằng mã nhà cung cấp
        public string MANCC
        {
            get { return this.mancc; }
            set
            {
                
                if (value == "")
                    throw new Exception("Nhà Cung cấp rỗng");
                this.mancc = value;
            }
        }

        public string THONGTIN
        {
            get { return this.thongtin; }
            set
            {
                if (value == "")
                    throw new Exception("Thông tin rỗng");
                this.thongtin = value;
            }
        }
        public int DONVITINH
        {
            get { return this.donvitinh; }
            set
            {
                if (value ==0)
                    throw new Exception("Đơn vị tính rỗng");
                this.donvitinh = value;
            }
        }

        public int MALOAISP
        {
            get { return this.maloaisp; }
            set
            {
                if (value == 0)
                    throw new Exception("Mã loại sản phẩm rỗng");
                this.maloaisp = value;
            }
        }


        /*

        public override string ToString()
        {
            return this.masp+ "; " + this.tensp+ "; " + this.gianhap + "; " + this.giaban + "; " + this.mucnhapvao+ "; " + this.nhacungcap + "; " + this.ghichu + "; ";
        }
        public override bool Equals(Object obj)
        {
            tbsanpham me = (tbsanpham)obj;
            bool ret = this.MASP.Equals(me.MASP);
            return ret;
        }
        public override int GetHashCode()
        {
            return this.MASP.GetHashCode();
        }
         */



        



    }
}
