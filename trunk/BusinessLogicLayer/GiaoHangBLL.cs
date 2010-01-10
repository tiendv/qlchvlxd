using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class GiaoHangBLL
    {
        public static BusinessEntities.CTHoaDonBE getHoaDon(String maHoaDon)
        {
            BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();
            DataAccessLayer.GiaoHangDAL access = new DataAccessLayer.GiaoHangDAL();

            hoaDon = access.getHoaDon(maHoaDon);

            if (hoaDon == null)
                return null;

            return hoaDon;
        }
    }
}
