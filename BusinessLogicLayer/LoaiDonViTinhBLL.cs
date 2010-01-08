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
    public class LoaiDonViTinhBLL
    {
        public  List<BusinessEntities.LoaiDonViTinhBE> getDanhSachLoaiDonViTinh()
        {
            List<BusinessEntities.LoaiDonViTinhBE> list = new List<BusinessEntities.LoaiDonViTinhBE>();
            DataAccessLayer.LoaiDonViTinhBE access = new DataAccessLayer.LoaiDonViTinhBE();


            list = access.getLoaiDonViTinh();

            if (list == null)
                return null;

            return list;
        }  
    }
}
