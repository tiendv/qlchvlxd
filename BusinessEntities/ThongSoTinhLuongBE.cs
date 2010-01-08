using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class ThongSoTinhLuongBE
    {
        public ThongSoTinhLuongBE()
        { 
        
        }
        public int MaLoaiNhanVien
        {
            set { this.maLoaiNhanVien = value; }
            get { return this.maLoaiNhanVien; }
        }
        public string TenLoaiNhanVien
        {
            set { this.tenLoaiNhanVien = value; }
            get { return this.tenLoaiNhanVien; }
        }
        public float LuongCoBan
        {
            set { this.luongCoBan = value; }
            get { return this.luongCoBan; }
        }
        private int maLoaiNhanVien;
        private string tenLoaiNhanVien;
        private float luongCoBan;

    }
}
