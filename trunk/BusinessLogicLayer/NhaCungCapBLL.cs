using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;


namespace BusinessLogicLayer
{
     public class NhaCungCapBLL
    {
         //lấy danh sách nhà cung cấp
         public String getMaNCCMax()
         {
             List<BusinessEntities.NhaCungCapBE> listNhaCungCap = new List<BusinessEntities.NhaCungCapBE>();
             DataAccessLayer.NhaCungCapDAL accessTenNhaCungCap = new DataAccessLayer.NhaCungCapDAL();

             listNhaCungCap = accessTenNhaCungCap.getListNhaCungCap();
             return listNhaCungCap[listNhaCungCap.Count - 1].MANCC;
         }
         //thêm nhà cung cấp
         public int themTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
         {
             DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
             
             int kq = access.themNhaCungCap(nhacungcap);
             return kq;
         }
         // Sửa thông tin nhà cung cấp
        public int suaTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
        {
            DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
            int kq=access.SuaTTNhaCungCap(nhacungcap);
            return kq;
        }
        // Xóa thông tin nhà cung cấp
        public int XoaTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
        {
            DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
            int kq = access.XoaTTNhaCungCap(nhacungcap);
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
            if (tenNCC == "")
            {
                return listNhaCungCap;
            }
            else
            {
                for (int i = 0; i < listNhaCungCap.Count; i++)
                {
                    if (!listNhaCungCap[i].TENNCC.Equals(tenNCC))
                    {
                        listNhaCungCap.RemoveAt(i);
                        i--;
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

         /// <summary>
         /// 
         /// </summary>
         /// <param name="Lấy Mã Nhà Cung Cấp theo tên nhà cung cấp  "></param>
         /// <returns></returns>
        public  BusinessEntities.NhaCungCapBE getMaNhaCungCap(string tennhacungcap)
        {
            BusinessEntities.NhaCungCapBE ncc = new BusinessEntities.NhaCungCapBE();
            DataAccessLayer.NhaCungCapDAL accessNCC = new DataAccessLayer.NhaCungCapDAL();

            ncc = accessNCC.getMaNhaCungCapTuTen(tennhacungcap);

            if (ncc == null)
                return null;

            return ncc;
        }
    }
}
