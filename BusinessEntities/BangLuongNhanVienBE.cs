using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BusinessEntities
{
    /*
     * 
     * author : Huynh Minh Duc
     * date : Jan 07 2010
     */
    public class BangLuongNhanVienBE
    {
        public BangLuongNhanVienBE()
        { 
            
        }
        public string MaBL
        {
            set { this.maBL = value; }
            get { return this.maBL; }
        }
        public string HotenNV
        {
            set { this.hotenNV = value; }
            get { return this.hotenNV; }
        }
        public int NgayDiLam
        {
            set { this.ngaydilam = value; }
            get { return this.ngaydilam; }
        }
        public double LuongCB
        {
            set { this.luongCB = value; }
            get { return this.luongCB; }
        }
        public double TienThuong
        {
            set { this.tienthuong = value; }
            get { return this.tienthuong; }
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

        private string maBL;
        private string hotenNV;
        private int ngaydilam;
        private double tienthuong;
        private double luongCB;
        private double tamung;
        private double tongluong;
    }
}
