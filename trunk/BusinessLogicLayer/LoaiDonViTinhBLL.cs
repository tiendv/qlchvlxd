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
            DataAccessLayer.LoaiDonViTinhDAL access = new DataAccessLayer.LoaiDonViTinhDAL();


            list = access.getLoaiDonViTinh();

            if (list == null)
                return null;

            return list;
        }

        public static List<BusinessEntities.LoaiDonViTinhBE> getListTenLoaiDonViTinh()
        {
            List<BusinessEntities.LoaiDonViTinhBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
            DataAccessLayer.LoaiDonViTinhDAL accessTenLoaiDonViTinh = new DataAccessLayer.LoaiDonViTinhDAL();

            listTenLoaiDonViTinh = accessTenLoaiDonViTinh.getTenLoaiDonViTinh();

            if (listTenLoaiDonViTinh == null)
                return null;

            return listTenLoaiDonViTinh;
        }
    
    }
}
