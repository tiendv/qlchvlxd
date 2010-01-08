using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class tbLOAIDONVITINH
    {
        public int maloaidonvitinh;
        public string tenloaidonvitinh;

       // constructor
        /*
        public tbLOAIDONVITINH(int maloaidonvitinh, string tenloaidonvitinh)
        {
            this.maloaidonvitinh = maloaidonvitinh;
            this.tenloaidonvitinh = tenloaidonvitinh;
        }
         */
        public int MALOAIDONVITINH
        {

            get { return this.maloaidonvitinh; }
            set
            {

                if (value == 0)
                    throw new Exception("Mã loại đơn vị tính rỗng !");
                this.maloaidonvitinh = value;
            }
        }
        public string TENLOAIDONVITINH
        {

            get { return this.tenloaidonvitinh; }
            set
            {

                if (value == "")
                    throw new Exception("Tên loại đơn vị tính  rỗng !");
                this.tenloaidonvitinh = value;
            }
        }
        
    }
}
