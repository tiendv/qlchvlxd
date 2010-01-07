using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLogicLayer
{
    public class tbCTHDServices
    {
        public static List<BusinessEntities.tbCTHD> getDanhSachCTHD()
        {
            List<BusinessEntities.tbCTHD> list = new List<BusinessEntities.tbCTHD>();
            DataAccessLayer.tbCTHDDao access = new tbCTHDDao();

            list = access.getCTHoaDon();

            if (list == null)
                return null;

            return list;
        }      
              
    }
}
