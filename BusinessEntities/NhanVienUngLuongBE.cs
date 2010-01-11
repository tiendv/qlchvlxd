using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class NhanVienUngLuongBE
    {
        public NhanVienUngLuongBE()
        { 
        
        }
        public string HoTen
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public string NgaySinh
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }
        public string GioiTinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
        public int LoaiNhanVien
        {
            set { this.loaiNhanVien = value; }
            get { return this.loaiNhanVien; }
        }
        public double LuongCoBan
        {
            set { this.luongCB = value; }
            get { return this.luongCB; }
        }
        public double TamUng
        {
            set { this.tamung = value; }
            get { return this.tamung; }
        }
        public double TongLuong
        {
            set { this.tongluong = value; }
            get { return this.tongluong; }
        }
        public int SoNgayDiLam
        {
            set { this.soNgayDiLam = value; }
            get { return this.soNgayDiLam; }
        }
        public int MaNhanVien
        {
            set { this.maNhanVien = value; }
            get { return this.maNhanVien; }
        }
        public int MaBangLuong
        {
            set { this.maBL = value; }
            get { return this.maBL; }
        }
        private int maBL;
        private int maNhanVien;
        private string hoten;
        private string ngaysinh;
        private string gioitinh;
        private int loaiNhanVien;
        private int soNgayDiLam;
        private double luongCB;
        private double tamung;
        private double tongluong;
    }
}
