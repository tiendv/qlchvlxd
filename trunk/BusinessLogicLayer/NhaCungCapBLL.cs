using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class NhaCungCapBLL
    {
         // Sửa thông tin nhà cung cấp
        public int suaTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
        {
            DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
            int kq=access.SuaTTNhaCungCap(nhacungcap);
            return kq;
        }
         // Tìm thông tin nhà cung cấp theo tên
        public List<BusinessEntities.NhaCungCapBE> getListNCCtheoTen(String tenNCC)
        {
            List<BusinessEntities.NhaCungCapBE> listNhaCungCap = new List<BusinessEntities.NhaCungCapBE>();
            DataAccessLayer.NhaCungCapDAL accessTenNhaCungCap = new DataAccessLayer.NhaCungCapDAL();

            listNhaCungCap = accessTenNhaCungCap.getListNhaCungCap();

            if (listNhaCungCap == null)
                return null;
            else
            {
                for(int i=0; i<listNhaCungCap.Count;i++)
                {
                    if (!listNhaCungCap[i].TENNCC.Equals(tenNCC))
                    {
                        listNhaCungCap.RemoveAt(i);
                    }
                }
            }
            return listNhaCungCap;
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
