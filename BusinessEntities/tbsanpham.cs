using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//table sản phẩm

namespace BusinessEntities
{
    public class tbsanpham
    {
        public string masp;
        public string tensp;
        public string gianhap;
        public string giaban;
        public string mucnhapvao;
        public string nhacungcap;
        public string ghichu;

        // constructor
        public tbsanpham(string masp, string tensp, string gianhap, string giaban, string mucnhapvao, string nhacungcap, string ghichu)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.mucnhapvao = mucnhapvao;
            this.nhacungcap = nhacungcap;
            this.ghichu = ghichu;
       
        }
        public string MASP
        {
            get { return this.masp; }
            set
            {
                // Sản phẩm có mã đánh tự động cái này từ từ làm kaka
                if (value == "")
                    throw new Exception("Sản phẩm có mã đánh tự động cái này từ từ làm kaka");
                this.masp = value;
            }
        }
        public string TENSP 
        {
            get { return this.tensp; }
            set
            {
                
                if (value == "")
                    throw new Exception("Tên sản phẩm không được bỏ trống");
                this.tensp = value;
            }
        }
        public string GIANHAP
        {
            get { return this.gianhap; }
            set
            {
                
                if (value == "")
                    throw new Exception("Giá Nhập vào không được bỏ trống");
                this.gianhap= value;
            }
        }
        public string GIABAN
        {
            get { return this.giaban; }
            set
            {
                
                if (value == "")
                    throw new Exception("Giá Bán vào không được bỏ trống");
                this.giaban = value;
            }
        }
        public string MUCNHAPVAO
        {
            get { return this.mucnhapvao; }
            set
            {
               
                if (value == "")
                    throw new Exception("Mức nhập vào không được bỏ trống");
                this.mucnhapvao = value;
            }
        }
        // Nhà cung cấp liên quan đến sản phẩm bằng mã nhà cung cấp
        public string NHACUNGCAP
        {
            get { return this.nhacungcap; }
            set
            {
                
                if (value == "")
                    throw new Exception("Nhà Cung cấp không được bỏ trống");
                this.nhacungcap = value;
            }
        }
        public string GHICHU
        {
            get { return this.ghichu; }
            set
            {
                          
                this.ghichu = value;
            }
        }

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



        



    }
}
