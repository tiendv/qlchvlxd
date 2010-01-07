using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// table Loại Sản Phẩm
namespace BusinessEntities
{
    public class tbLOAISANPHAM
    {
        public int maloaisp;
        public string tenloaisanpham;
/*
        public tbLOAISANPHAM(int maloaisp, string tenloaisanpham)
        {
            this.maloaisp = maloaisp;
            this.tenloaisanpham = tenloaisanpham;
        }
 */

        public int MALOAISP
        {
            get { return this.maloaisp; }
            set
            {

                if (value == 0)
                    throw new Exception("Mã loại sản phẩm rỗng !");
                this.maloaisp = value;
            }
        }
        public string TENLOAISP
        {
            get { return this.tenloaisanpham; }
            set
            {

                if (value == "")
                    throw new Exception("Tên loại sản phẩm rỗng !");
                this.tenloaisanpham = value;
            }
        }
    }

}
