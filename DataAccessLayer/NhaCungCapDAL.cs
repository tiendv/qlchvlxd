﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DataAccessLayer
{
   public class NhaCungCapDAL
    {
        public int themNhaCungCap(BusinessEntities.NhaCungCapBE nhaCungCap)
        {
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[nhacungcap]([mancc],[tenncc],[diachi],[dienthoai])"
                                + "VALUES ('" + nhaCungCap.MANCC + "' , '" + nhaCungCap.TENNCC+"','"
                                 + nhaCungCap.DIACHI + "',' " + nhaCungCap.DIENTHOAI + "')";

            int kq=SQLHelp.executeNonQuery(myAddQuery);
            return kq;
        }
        public int SuaTTNhaCungCap(BusinessEntities.NhaCungCapBE nhaCungCap)
        {
            String myAddQuery = "UPDATE [QLCHVLXD].[dbo].[nhacungcap] SET tenncc= '" + nhaCungCap.TENNCC
                                 + "', diachi = '"+nhaCungCap.DIACHI + "', dienthoai= '" 
                                 + nhaCungCap.DIENTHOAI + "' where mancc= '"+nhaCungCap.MANCC+"'";

            int kq=SQLHelp.executeNonQuery(myAddQuery);
            return kq;
        }
        public int XoaTTNhaCungCap(BusinessEntities.NhaCungCapBE nhaCungCap)
        {
            String myAddQuery = "delete from [QLCHVLXD].[dbo].[nhacungcap] where mancc='"+nhaCungCap.MANCC+"'";

            int kq = SQLHelp.executeNonQuery(myAddQuery);
            return kq;
        }

        public List<BusinessEntities.NhaCungCapBE> getListNhaCungCap()
        {
            List<BusinessEntities.NhaCungCapBE> listNCC = new List<BusinessEntities.NhaCungCapBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM NHACUNGCAP");

            BusinessEntities.NhaCungCapBE nhaCungCap;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (DataRow row in dataTable.Rows)
            {
                nhaCungCap = new BusinessEntities.NhaCungCapBE();

                nhaCungCap.MANCC = row["MANCC"].ToString();
                nhaCungCap.TENNCC = row["TENNCC"].ToString();
                nhaCungCap.DIACHI = row["DIACHI"].ToString();
                nhaCungCap.DIENTHOAI = row["DIENTHOAI"].ToString();
                
                listNCC.Add(nhaCungCap);
            }

            return listNCC;
        }

        public BusinessEntities.NhaCungCapBE getNhaCungCap(String maNCC)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT * FROM NHACUNGCAP WHERE MANCC = '" + maNCC+"'");

            BusinessEntities.NhaCungCapBE nhaCungCap = null;

            foreach (DataRow row in dt.Rows)
            {
                nhaCungCap = new BusinessEntities.NhaCungCapBE();
                nhaCungCap.MANCC = row["MANCC"].ToString();
                nhaCungCap.TENNCC = row["TENNCC"].ToString();
                nhaCungCap.DIACHI = row["DIACHI"].ToString();
                nhaCungCap.DIENTHOAI = row["DIENTHOAI"].ToString();
                
            }

            return nhaCungCap;
        }
        /*
     * Lấy tên những tên Nhà Cung cấp 
         * 
         * tiendv
 
     */
        public List<BusinessEntities.NhaCungCapBE> getTenNhaCungCap()
        {
            List<BusinessEntities.NhaCungCapBE> listTenNhaCungCap = new List<BusinessEntities.NhaCungCapBE>();

            DataTable dt = SQLHelp.executeQuery("SELECT [tenncc]FROM [QLCHVLXD].[dbo].[nhacungcap]");

            BusinessEntities.NhaCungCapBE nhacungcap;

            foreach (DataRow row in dt.Rows)
            {
                nhacungcap = new BusinessEntities.NhaCungCapBE();
                //MessageBox.Show("okkkk");

                               
                nhacungcap.TENNCC = row["tenncc"].ToString();

                listTenNhaCungCap.Add(nhacungcap);
            }


            return listTenNhaCungCap;
        }

       // lấy mã nhà cung cấp từ tên nhà cung cấp 
        public BusinessEntities.NhaCungCapBE getMaNhaCungCapTuTen(string maNCC)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT MANCC FROM NHACUNGCAP WHERE TENNCC = N'" + maNCC+"'");

            BusinessEntities.NhaCungCapBE NhaCC = null;

            foreach (DataRow row in dt.Rows)
            {
                NhaCC = new BusinessEntities.NhaCungCapBE();

                NhaCC.MANCC = row["MANCC"].ToString();
            }

            return NhaCC;
        }

       
        /************************************
         * 
         * tìm kiếm nhà cung cấp theo tên
         * 13/01/2010
         * 
         * *********************************/
        public List<BusinessEntities.NhaCungCapBE> getListNhaCungCapTuTen(String tenNCC)
        {
            List<BusinessEntities.NhaCungCapBE> listNCC = new List<BusinessEntities.NhaCungCapBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE '%" + tenNCC + "%'");

            BusinessEntities.NhaCungCapBE nhaCungCap;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (DataRow row in dataTable.Rows)
            {
                nhaCungCap = new BusinessEntities.NhaCungCapBE();

                nhaCungCap.MANCC = row["MANCC"].ToString();
                nhaCungCap.TENNCC = row["TENNCC"].ToString();
                nhaCungCap.DIACHI = row["DIACHI"].ToString();
                nhaCungCap.DIENTHOAI = row["DIENTHOAI"].ToString();
                
                listNCC.Add(nhaCungCap);
            }

            return listNCC;
        }
    }
}
