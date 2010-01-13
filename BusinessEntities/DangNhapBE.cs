using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class DangNhapBE
    {
        public DangNhapBE()
        { 
            
        }
        public int MaNhanVien
        {
            set { this.maNV = value; }
            get { return this.maNV; }
        }
        public string MatKhau
        {
            set { this.matkhau = value; }
            get { return this.matkhau; }
        }
        public int MaLoaiNV
        {
            set { this.maloaiNV = value; }
            get { return this.maloaiNV; }
        }
        private int maNV;
        private string matkhau;
        private int maloaiNV;
    }
}
