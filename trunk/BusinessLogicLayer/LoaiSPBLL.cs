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
        // Thêm một loại sản phẩm vào hệ thống

        public void themdloaisanpham(BusinessEntities.LoaiSPBE lsp)
        {
            DataAccessLayer.LoaiSPDAL access = new DataAccessLayer.LoaiSPDAL();

            access.insertLoaiSP(lsp);
        }
        // Lấy danh sách các tên loại sản phẩm từ bảng sản phẩm

        public static List<BusinessEntities.LoaiSPBE> getListTenLoaiSanPham()
        {
            List<BusinessEntities.LoaiSPBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();
            DataAccessLayer.LoaiSPDAL accessTenLoaiSanPham = new DataAccessLayer.LoaiSPDAL();

            listTenLoaiSanPham = accessTenLoaiSanPham.getTenLoaiSanPham();

            if (listTenLoaiSanPham == null)
                return null;

            return listTenLoaiSanPham;
        }

       


              
    }
}
