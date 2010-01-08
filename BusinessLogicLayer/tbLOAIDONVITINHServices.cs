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
    public class tbLOAIDONVITINHServices
    {
        public static List<BusinessEntities.tbLOAIDONVITINH> getDanhSachLoaiDonViTinh()
        {
            List<BusinessEntities.tbLOAIDONVITINH> list = new List<BusinessEntities.tbLOAIDONVITINH>();
            DataAccessLayer.tbLOAIDONVITINHDAO access = new tbLOAIDONVITINHDAO();

            list = access.getLoaiDonViTinh();
            if (list == null)
                return null;

            return list;
        }     
    }
}
