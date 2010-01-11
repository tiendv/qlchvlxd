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
            try
            {
                DataAccessLayer.LoaiSPDAL access = new DataAccessLayer.LoaiSPDAL();

                access.insertLoaiSP(lsp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        // Lấy danh sách các tên loại sản phẩm từ bảng loại sản phẩm

        public static List<BusinessEntities.LoaiSPBE> getListTenLoaiSanPham()
        {
            List<BusinessEntities.LoaiSPBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();
            DataAccessLayer.LoaiSPDAL accessTenLoaiSanPham = new DataAccessLayer.LoaiSPDAL();

            listTenLoaiSanPham = accessTenLoaiSanPham.getTenLoaiSanPham();

            if (listTenLoaiSanPham == null)
                return null;

            return listTenLoaiSanPham;
        }

        // Xóa một loại sản phẩm 
        public void xoaloaisptheomaloai(BusinessEntities.LoaiSPBE lsp)
        {
            try
            {

                DataAccessLayer.LoaiSPDAL access = new DataAccessLayer.LoaiSPDAL();

                access.deleteLoaiSanPham(lsp);
            }
            catch (Exception e)
            {
                throw e;
            }


        }


        /// 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Lấy Mã Loại Sản Phẩmnh từ tên Loại Sản Phẩm   "></param>
        /// <returns></returns>
        public BusinessEntities.LoaiSPBE getMaloaisanphamtuten(string tenlsp)
        {
            BusinessEntities.LoaiSPBE lsp = new BusinessEntities.LoaiSPBE();
            DataAccessLayer.LoaiSPDAL accessLSP = new DataAccessLayer.LoaiSPDAL();

            lsp = accessLSP.getMaLoaiSanPhamTuTen(tenlsp);

            if (lsp == null)
                return null;

            return lsp;
        }

              
    }
}
