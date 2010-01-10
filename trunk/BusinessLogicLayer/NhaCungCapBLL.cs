using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class NhaCungCapBLL
    {
        public int suaTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
        {
            DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
            int kq=access.SuaTTNhaCungCap(nhacungcap);
            return kq;
        }

        // Lấy danh sách các tên  nhà cung cấp từ  bảng nhà cung cấp

        public static List<BusinessEntities.NhaCungCapBE> getListTenNhaCungCap()
        {
            List<BusinessEntities.NhaCungCapBE> listTenNhaCungCap = new List<BusinessEntities.NhaCungCapBE>();
            DataAccessLayer.NhaCungCapDAL accessTenNhaCungCap = new DataAccessLayer.NhaCungCapDAL();

            listTenNhaCungCap = accessTenNhaCungCap.getTenNhaCungCap();

            if (listTenNhaCungCap == null)
                return null;

            return listTenNhaCungCap;
        }
    }
}
