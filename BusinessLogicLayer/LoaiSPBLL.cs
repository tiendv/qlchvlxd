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
    public class LoaiSPBLL
    {

        public static List<BusinessEntities.LoaiSPBE> getDanhSachLoaiSP()
        {
            List<BusinessEntities.LoaiSPBE> list = new List<BusinessEntities.LoaiSPBE>();
            DataAccessLayer.LoaiSPDAL access = new DataAccessLayer.LoaiSPDAL();


            list = access.getLoaiSanPham();

            if (list == null)
                return null;

            return list;
        }
       


              
    }
}
