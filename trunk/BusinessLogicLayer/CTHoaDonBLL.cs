using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 07/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace BusinessLogicLayer
{
    public class CTHoaDonBLL
    {
        public static List<BusinessEntities.CTHoaDonBE> getDanhSachCTHD()
        {
            List<BusinessEntities.CTHoaDonBE> list = new List<BusinessEntities.CTHoaDonBE>();
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            list = access.getCTHoaDon();
              
            if (list == null)
                return null;

            return list;
        }

        public static List<BusinessEntities.CTHoaDonBE> getDanhSachCTHD(String maHoaDon)
        {
            List<BusinessEntities.CTHoaDonBE> list = new List<BusinessEntities.CTHoaDonBE>();
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            list = access.getCTHoaDon(maHoaDon);

            if (list == null)
                return null;

            return list;
        }

        public static void themChiTietHoaDon(BusinessEntities.CTHoaDonBE myCTHoaDon)
        {
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            access.themCTHoaDon(myCTHoaDon);
        }

        public static void xoaChiTietHoaDon(String maCTHD)
        {
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            access.xoaCTHoaDon(maCTHD);
        }

        public static void xoaListHoaDon()
        {
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            access.xoaListCTHoaDon();
        }

        public static void themHoaDon(BusinessEntities.CTHoaDonBE hoaDon)
        {
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            access.themHoaDon(hoaDon);
        }

        public static void suaHoaDon(BusinessEntities.CTHoaDonBE hoaDon, String maHoaDon)
        {
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            access.suaHoaDon(hoaDon, maHoaDon);
        }

        public static List<BusinessEntities.CTHoaDonBE> getListHoaDon()
        {
            List<BusinessEntities.CTHoaDonBE> list = new List<BusinessEntities.CTHoaDonBE>();
            DataAccessLayer.CTHoaDonDAL access = new DataAccessLayer.CTHoaDonDAL();

            list = access.getListHoaDon();

            if (list == null)
                return null;

            return list;
        }
              
    }
}
