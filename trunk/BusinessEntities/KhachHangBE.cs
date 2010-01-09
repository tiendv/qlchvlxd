using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 09/01/2010 
* Modified by: Nguyen Van B
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace BusinessEntities
{
    public class KhachHangBE
    {
        public String maKhachHang = "";
        public String tenKhachHang = ""; 
        public String diaChi = "";
        public String soDienThoai = "";
        public String CMND = "";
        public String gioiTinh = "";
        public int loaiKhachHang = 0;

        public String MaKhachHang
        {
            get { return this.maKhachHang; }
            set { this.maKhachHang = value; }
        }

        public String TenKhachHang
        {
            get { return this.tenKhachHang; }
            set { this.tenKhachHang = value; }
        }

        public String DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        public String SoDienThoai
        {
            get { return this.soDienThoai; }
            set { this.soDienThoai = value; }
        }
        public String SCMND
        {
            get { return this.CMND; }
            set { this.CMND = value; }
        }

        public String GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }

        public int LoaiKhachHang
        {
            get { return this.loaiKhachHang; }
            set { this.loaiKhachHang = value; }
        }

    }
}
