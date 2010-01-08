﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;
/*
  * LoaiSPDAL
  * 
  * Author : tiendv
  * Date : Jan 08 2010
  */

namespace DataAccessLayer
{
    public class LoaiSPDAL
    {
        public List<BusinessEntities.LoaiSPBE> getLoaiSanPham()
        {
            DataTable dt = SQLHelp.executeQuery("select * from loaisanpham");
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
        public List<string> getAllTenLoaiSanPham()
        {
            List<string> tenloaisp = new List<string>();
            string query = "SELECT  DISTINCT TENLOAISP FROM LOAISANPHAM";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["TENLOAISP"].ToString();
                tenloaisp.Add(str);
            }

            return tenloaisp;
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
            string query = "INSERT INTO LOAISANPHAM VALUES ('" +lsp.maloaisp + "', N'" + lsp.tenloaisp+ "') ";
            SQLHelp.executeNonQuery(query);
        }
       
        // Xóa Loại Sản Phẩm
        
        
      
        public void deleteLoaiSP(int maloaisp)
        {
            string query = "DELETE FROM LOAISANPHAM WHERE MALOAISP = '" + maloaisp + "'";
            SQLHelp.executeNonQuery(query);
        }
        /*
         * Sửa Thông tin Loại Sản Phẩm
         * 
         * 
         */
        public void updateLoaiSP(LoaiSPBE loaisp)
        {
            string query = "UPDATE LOAISANPHAM " +
                                "SET MALOAISP =" + loaisp.maloaisp + "'," +
                                        "TENLOAIAP = N'" + loaisp.tenloaisp + "'," +
                                "WHERE MALOAISP = '" + loaisp.MALOAISP + "'";
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }

    }
}