﻿using System;
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
            List<BusinessEntities.SanPhamBE> listTenSanPham = new List<BusinessEntities.SanPhamBE>();
            DataAccessLayer.SanPhamDAL accessTenSanPham = new DataAccessLayer.SanPhamDAL();

            listTenSanPham = accessTenSanPham.getListTenSanPham(tenSanPham);

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


 




    }
}