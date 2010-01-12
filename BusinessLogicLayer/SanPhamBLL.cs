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
    public class SanPhamBLL
    {
        public static List<BusinessEntities.SanPhamBE> getDanhSachSanPham()
        {
            List<BusinessEntities.SanPhamBE> list = new List<BusinessEntities.SanPhamBE>();
            DataAccessLayer.SanPhamDAL access = new DataAccessLayer.SanPhamDAL();

            list = access.getSanPham();

            if (list == null)
                return null;

            return list;
        }

        public static List<BusinessEntities.SanPhamBE> getListTenSanPham(String tenSanPham)
        {
            try
            {
                List<BusinessEntities.SanPhamBE> listTenSanPham = new List<BusinessEntities.SanPhamBE>();
                DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

                listTenSanPham = accessTenSanPham.getAllListTenSanPham(tenSanPham);

                if (listTenSanPham == null)
                    return null;

                return listTenSanPham;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Lay danh sach san pham theo mã sản phẩm 

         public List<BusinessEntities.SanPhamBE> getListMaSanPham(int msp)
         {
             try
             {
                 List<BusinessEntities.SanPhamBE> listMaSanPham = new List<BusinessEntities.SanPhamBE>();
                 DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

                 listMaSanPham = accessTenSanPham.viewAllSanPhamByKindOfMaSP(msp);

                 if (listMaSanPham == null)
                     return null;

                 return listMaSanPham;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
       // Lấy danh sách sản phẩm theo mã nhà cung cấp 
         public List<BusinessEntities.SanPhamBE> getListSanPhamTheoMaNhaCungCap(String mancc)
         {
             try
             {
                 List<BusinessEntities.SanPhamBE> listTenSanPham = new List<BusinessEntities.SanPhamBE>();
                 DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

                 listTenSanPham = accessTenSanPham.viewAllSanPhamByKindOfNCC(mancc);

                 if (listTenSanPham == null)
                     return null;

                 return listTenSanPham;
             }
             catch (Exception ex)
             {
                 throw ex; 
             }
         }

         // Lấy giá sản phẩm from Cường
         public static BusinessEntities.SanPhamBE getGiaSanPham(String tenSanPham)
         {
             BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();
             DataAccessLayer.SanPhamDAL accessSanPham = new DataAccessLayer.SanPhamDAL();

             sanPham = accessSanPham.getGiaSanPham(tenSanPham);

             if (sanPham == null)
                 return null;

             return sanPham;
         }
         // Lấy Tên sản phẩm From  Cường
         public static BusinessEntities.SanPhamBE getTenSanPham(int maSP)
         {
             BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();
             DataAccessLayer.SanPhamDAL accessSanPham = new DataAccessLayer.SanPhamDAL();

             sanPham = accessSanPham.getTenSanPham(maSP);

             if (sanPham == null)
                 return null;

             return sanPham;
         }


        // Thêm một  sản phẩm

         public void themsanpham(BusinessEntities.SanPhamBE sp)
         {
             DataAccessLayer.SanPhamDAL access = new DataAccessLayer.SanPhamDAL();

             access.insertASanPham(sp);
         }

        //// sửa thông tin một sản phẩm
         public void suadthongtinsanphamtheotensanpham(BusinessEntities.SanPhamBE sanpham)
         {
             try
             {
                 DataAccessLayer.SanPhamDAL access = new DataAccessLayer.SanPhamDAL();

                 access.updatesanphamtheotensanpham(sanpham);
             }
             catch (Exception e)
             {
                 throw e;
             }
         }
        // cập nhật giá bán  giá mua và số lượng sản phẩm sau khi nhập kho
        public void updateNhapkho(BusinessEntities.SanPhamBE sanpham)
         {
             try
             {
                 DataAccessLayer.SanPhamDAL access = new DataAccessLayer.SanPhamDAL();

                 access.updateNhapkho(sanpham);
             }
             catch (Exception e)
             {
                 throw e;
             }
         }

         public void xoasanpham(BusinessEntities.SanPhamBE sanpham)
         {
             try
             {
                 DataAccessLayer.SanPhamDAL access = new DataAccessLayer.SanPhamDAL();

                 access.deleteASanPham(sanpham);
             }
             catch (Exception e)
             {
                 throw e;
             }


         }
         // Lấy sản phẩm từ tên của sản phẩm
         public  BusinessEntities.SanPhamBE getSanPhamTuTenSP(String tenSanPham)
         {
             BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();
             DataAccessLayer.SanPhamDAL accessSanPham = new DataAccessLayer.SanPhamDAL();

             sanPham = accessSanPham.getSanPhamTheoTen(tenSanPham);

             if (sanPham == null)
                 return null;

             return sanPham;
         }


 




    }
}
