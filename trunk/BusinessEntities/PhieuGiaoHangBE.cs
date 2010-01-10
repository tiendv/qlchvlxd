﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 10/01/2010 
* Modified by: 
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace BusinessEntities
{
    public class PhieuGiaoHangBE
    {
        public String maPhieuGiaoHang = "";
        public String maHoaDon = "";
        public String ngayGiaoHang = "";
        public float chiPhi;


        public String MaPhieuGiaoHang
        {
            get { return this.maPhieuGiaoHang; }
            set { this.maPhieuGiaoHang = value; }
        }
              
        public String MaHoaDon
        {
            get { return this.maHoaDon; }
            set { this.maHoaDon = value; }
        }

        public String NgayGiaoHang
        {
            get { return this.ngayGiaoHang; }
            set { this.ngayGiaoHang = value; }
        }

        public float ChiPhi
        {
            get { return this.chiPhi; }
            set { this.chiPhi = value; }
        }

    }
}
