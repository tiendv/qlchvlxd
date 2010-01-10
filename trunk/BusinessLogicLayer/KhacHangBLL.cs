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

namespace BusinessLogicLayer
{
    public class KhacHangBLL
    {
        public static void themKhachHang(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            access.themKhachHang(khachHang);
        }
        public int themKhachHangThanThiet(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            int kq;
            return kq=access.themKhachHangThanThiet(khachHang);
        }
        public  String getMaKHMax()
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            
            List<BusinessEntities.KhachHangBE> listKH = access.getListKhachHangThanThiet();
            return listKH[listKH.Count - 1].MaKhachHang;
        }
        public static List<BusinessEntities.KhachHangBE> getListKhachHang()
        {
            List<BusinessEntities.KhachHangBE> list = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            list = access.getListKhachHang();

            if (list == null)
                return null;

            return list;
        }

        public static BusinessEntities.KhachHangBE getKhachHang(String maKhachHang)
        {
            BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            khachHang = access.getKhachHang(maKhachHang);

            if (khachHang == null)
                return null;

            return khachHang;
        }
    }
}
