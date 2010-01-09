using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BusinessEntities;
using System.Data;
using System.Data.OleDb;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : tiendv
* Email : tiendv.vn@gmail.com
•	Created date: 07/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/


namespace BusinessLogicLayer
{
    public class LoaiDonViTinhBLL
    {
        public static  List<BusinessEntities.LoaiDonViTinhBE> getDanhSachLoaiDonViTinh()
        {
            List<BusinessEntities.LoaiDonViTinhBE> list = new List<BusinessEntities.LoaiDonViTinhBE>();
            DataAccessLayer.LoaiDonViTinhDAL access = new DataAccessLayer.LoaiDonViTinhDAL();


            list = access.getLoaiDonViTinh();

            if (list == null)
                return null;

            return list;
        }

        // Lấy danh sách tên các loại đơn vị tính

        public static List<BusinessEntities.LoaiDonViTinhBE> getListTenLoaiDonViTinh()
        {
            List<BusinessEntities.LoaiDonViTinhBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
            DataAccessLayer.LoaiDonViTinhDAL accessTenLoaiDonViTinh = new DataAccessLayer.LoaiDonViTinhDAL();

            listTenLoaiDonViTinh = accessTenLoaiDonViTinh.getTenLoaiDonViTinh();

            if (listTenLoaiDonViTinh == null)
                return null;

            return listTenLoaiDonViTinh;
        }

        public  void themdonvitinh(BusinessEntities.LoaiDonViTinhBE mydvt)
        {
            DataAccessLayer.LoaiDonViTinhDAL access = new DataAccessLayer.LoaiDonViTinhDAL();

            access.insertLoaiDonViTinh(mydvt);
        }
        public void xoadonvitinhtheoten(BusinessEntities.LoaiDonViTinhBE mydvt)
        {
            DataAccessLayer.LoaiDonViTinhDAL access = new DataAccessLayer.LoaiDonViTinhDAL();

            access.deleteLoaiDonViTinh(mydvt);
 
        }
        public void suadonvitinh(BusinessEntities.LoaiDonViTinhBE mydvt)
        {
            DataAccessLayer.LoaiDonViTinhDAL access = new DataAccessLayer.LoaiDonViTinhDAL();

            access.updateLoaiDonViTinh(mydvt);

        }

    }
}
