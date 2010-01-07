using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BusinessEntities;
using System.Data;
using System.Data.OleDb;

namespace BusinessLogicLayer
{
    class tbLOAISANPHAMServices
    {
        public static List<BusinessEntities.tbLOAISANPHAM> getDanhSachLoaiSanPham()
        {
            List<BusinessEntities.tbLOAISANPHAM> list = new List<BusinessEntities.tbLOAISANPHAM>();
            DataAccessLayer.tbLOAISANPHAMDAO access = new tbLOAISANPHAMDAO;

           list = access.getLoaiSanPham();
            if (list == null)
                return null;

            return list;
        }     
    }
}
