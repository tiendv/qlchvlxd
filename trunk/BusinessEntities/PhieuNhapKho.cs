using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    class PhieuNhapKho
    {
        public string mank;
        public string ngaynhap;
        public float tongtien;
        
        public string MANK
        {
            get { return this.mank; }
            set { this.mank = value; }
        }
        public string NGAYNHAP
        {
            get { return this.ngaynhap; }
            set { this.ngaynhap = value; }
        }
        public float TONGTIEN
        {
            get { return this.tongtien; }
            set { this.tongtien = value; }
        }
    }
}
