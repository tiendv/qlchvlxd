using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    class NhaCungCapBE
    {
        public string mancc;
        public string tenncc;
        public string diachi;
        public string dienthoai;
        public string MANCC
        {
            get { return this.mancc; }
            set
            {

                if (value == "")
                    throw new Exception("Mã nhà cung cấp rỗng !");
                this.mancc = value;
            }
        }
        public string TENNCC
        {
            get { return this.mancc; }
            set
            {

                if (value == "")
                    throw new Exception("Tên nhà cung cấp rỗng !");
                this.mancc = value;
            }
        }
        public string DIACHI
        {
            get { return this.mancc; }
            set
            {

                if (value == "")
                    throw new Exception("Địa chỉ nhà cung cấp rỗng !");
                this.mancc = value;
            }
        }
        public string DIENTHOAI
        {
            get { return this.mancc; }
            set
            {

                if (value == "")
                    throw new Exception("Số điện thoại nhà cung cấp rỗng !");
                this.mancc = value;
            }
        }
    }
}
