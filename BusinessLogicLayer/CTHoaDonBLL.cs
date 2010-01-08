using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


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
              
    }
}
