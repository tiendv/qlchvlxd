using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    /*
    * Author : Huynh Minh Duc
    * Create : Jan 6 2010 * 
    */
    public class NhanVienBE
    {
        public NhanVienBE() 
        {
            
        }

        public string MaNV 
        {
            set { this.maNV = value; }
            get { return this.maNV; }
        }
        public string HoTenNV
        {
            set { this.hotenNV = value; }
            get { return this.hotenNV; }
        }
        public string MatKhau
        {
            set { this.matkhau = value; }
            get { return this.matkhau; }
        }
        public string GioiTinh
        {
            set { this.gioitinhNV = value; }
            get { return this.gioitinhNV; }
        }
        public string NgaySinh 
        {
            set { this.ngaysinhNV = value; }
            get { return this.ngaysinhNV; }
        }
        public string SDT
        {
            set { this.sdt = value; }
            get { return this.sdt; }
        }
        public string NgayDiLam
        {
            set { this.ngaydilamNV = value; }
            get { return this.ngaydilamNV; }
        }
        public string QueQuan
        {
            set { this.quequanNV = value; }
            get { return this.quequanNV; }
        }
        public int MaLoaiNV
        {
            set { this.maLoaiNV = value; }
            get { return this.maLoaiNV; }
        }
        private string maNV;
        private string hotenNV;
        private string matkhau;
        private string gioitinhNV;
        private string ngaysinhNV;
        private string sdt;
        private string ngaydilamNV;
        private string quequanNV;
        private int maLoaiNV;
    }
}
