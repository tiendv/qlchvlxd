﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;
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
namespace DataAccessLayer
{
    public class LoaiSPDAL
    {
        public List<BusinessEntities.LoaiSPBE> getLoaiSanPham()
        {
            DataTable dt = SQLHelp.executeQuery("SELECT * FROM [QLCHVLXD].[dbo].[loaisanpham]");
            List<BusinessEntities.LoaiSPBE> danhsachLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.LoaiSPBE lsp = new BusinessEntities.LoaiSPBE();
                    lsp.maloaisp = (int)row["maloaisp"];
                    lsp.tenloaisp = row["tenloaisp"].ToString();

                    danhsachLoaiSanPham.Add(lsp);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachLoaiSanPham;
        }

        /*
      * Lấy tên những tên sản phẩm từ bảng loại sản phẩm
 
      */
        public List<BusinessEntities.LoaiSPBE> getTenLoaiSanPham()
        {
            List<BusinessEntities.LoaiSPBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiSPBE>();

            DataTable dt = SQLHelp.executeQuery("SELECT [tenloaisp] FROM [QLCHVLXD].[dbo].[loaisanpham]");

            BusinessEntities.LoaiSPBE loaisanpham;

            foreach (DataRow row in dt.Rows)
            {
                loaisanpham = new BusinessEntities.LoaiSPBE();
                //MessageBox.Show("okkkk");

                //loaiSanPham.maloaisp = (int)row["maloaisp"];                    
                loaisanpham.tenloaisp = row["tenloaisp"].ToString();

                listTenLoaiDonViTinh.Add(loaisanpham);
            }


            return listTenLoaiDonViTinh;
        }


        //Lấy mã những tên sản phẩm từ bảng loại sản phẩm
        public List<string> getAllMaLoaiSanPham()
        {
            List<string> maloaisp = new List<string>();
            string query = "SELECT  DISTINCT MALOAISP FROM LOAISANPHAM";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["MALOAISP"].ToString();
                maloaisp.Add(str);
            }

            return maloaisp;
        }
        // thêm một loại sản phẩm .


        public void insertLoaiSP(LoaiSPBE lsp)
        {
            try
            {
                string query = "INSERT INTO LOAISANPHAM VALUES ('" + lsp.MALOAISP + "', N'" + lsp.TENLOAISP + "') ";
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       
        // Xóa Loại Sản Phẩm



        // Xóa một loại sản phẩm tính theo mã lọai sản phẩm 

        public void deleteLoaiSanPham(BusinessEntities.LoaiSPBE lsp)
        {
            try
            {
                string query = "DELETE FROM LOAISANPHAM WHERE MALOAISP = '" + lsp.MALOAISP + "'";
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            
            }
        }
        /*
         * Sửa Thông tin Loại Sản Phẩm
         * 
         * 
         */
        public void updateLoaiSP(LoaiSPBE loaisp)
        {
            try
            {
                string query = "UPDATE LOAISANPHAM SET TENLOAISP = N'" + loaisp.TENLOAISP + "' WHERE MALOAISP = '" + loaisp.MALOAISP + "'";

                SQLHelp.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Lấy mã loại sản phẩm  theo tên loại sản phẩm


        public BusinessEntities.LoaiSPBE getMaLoaiSanPhamTuTen(string tenlsp)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT [maloaisp]FROM [QLCHVLXD].[dbo].[loaisanpham] WHERE [tenloaisp]  = N'" + tenlsp + "'");

            BusinessEntities.LoaiSPBE lsp = null;

            foreach (DataRow row in dt.Rows)
            {
                lsp = new BusinessEntities.LoaiSPBE();

                lsp.MALOAISP = int.Parse(row["MALOAISP"].ToString());
            }

            return lsp;
        }

    }
}
