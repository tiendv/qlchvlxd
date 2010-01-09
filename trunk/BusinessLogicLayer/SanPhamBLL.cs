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
    public class SanPhamBLL
    {

         public SanPhamBLL()
        { 
        
        }

        // lay danh sach san pham
         public  List<BusinessEntities.SanPhamBE> getDanhSachSanPham()
         {
             List<BusinessEntities.SanPhamBE> list = new List<BusinessEntities.SanPhamBE>();
             DataAccessLayer.SanPhamDAL access = new SanPhamDAL();
             //access.getSanPham();
             list = access.getSanPham();

             if (list == null)
                 return null;

             return list;
         }
        // lay danh sach san pham theo ten
         public  List<BusinessEntities.SanPhamBE> getListTenSanPham(String tenSanPham)
         {
             List<BusinessEntities.SanPhamBE> listTenSanPham = new List<BusinessEntities.SanPhamBE>();
             DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

             listTenSanPham = accessTenSanPham.viewAllSanPhamByKindOfTenSP(tenSanPham); 

             if (listTenSanPham == null)
                 return null;

             return listTenSanPham;
         }
        // Lay danh sach san pham theo mã sản phẩm 

         public List<BusinessEntities.SanPhamBE> getListMaSanPham(int msp)
         {
             List<BusinessEntities.SanPhamBE> listMaSanPham = new List<BusinessEntities.SanPhamBE>();
             DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

             listMaSanPham = accessTenSanPham.viewAllSanPhamByKindOfMaSP(msp);

             if (listMaSanPham == null)
                 return null;

             return listMaSanPham;
         }
 




    }
}
