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

        public static List<BusinessEntities.KhachHangBE> getListKhachHang()
        {
            List<BusinessEntities.KhachHangBE> list = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            list = access.getListKhachHang();

            if (list == null)
                return null;

            return list;
        }

        public static BusinessEntities.KhachHangBE getKhachHang(String khachHang)
        {
            BusinessEntities.KhachHangBE _khachHang = new BusinessEntities.KhachHangBE();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            _khachHang = access.getKhachHang(khachHang);

            if (_khachHang == null)
                return null;

            return _khachHang;
        }
    }
}
