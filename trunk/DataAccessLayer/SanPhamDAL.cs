using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
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
    public class SanPhamDAL 
    {
        public List<BusinessEntities.SanPhamBE> getSanPham()
        {
           

            DataTable dt = SQLHelp.executeQuery("select * from  [QLCHVLXD].[dbo].[sanpham]");
            List<BusinessEntities.SanPhamBE> danhsachSANPHAM = new List<BusinessEntities.SanPhamBE>();

           
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.SanPhamBE sanpham = new BusinessEntities.SanPhamBE();

                   // MessageBox.Show("no chua chay vao day");
                    sanpham.masp = (int)row["msp"];
                    sanpham.tensp = row["tensp"].ToString();
                    sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                    sanpham.giaban = float.Parse(row["giaban"].ToString());
                    sanpham.soluong = (int)row["soluong"];
                    sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                    sanpham.mancc = row["mancc"].ToString();
                    sanpham.thongtin = row["thongtin"].ToString();
                    sanpham.donvitinh = (int)row["donvitinh"];
                    sanpham.maloaisp = (int)row["maloaisp"];

                    danhsachSANPHAM.Add(sanpham);
               
            }
          
            return danhsachSANPHAM;
        }

        // Lấy danh sách tên  sản phẩm
        public List<string> getAllTenSanPham()
        {
            List<string> tensanpham = new List<string>();
            string query = "SELECT DISTINCT TENSP FROM SANPHAM";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["TENSP"].ToString();
                tensanpham.Add(str);
            }

            return tensanpham;
        }

        // Lấy danh sách mã sản phẩm
        public List<string> getAllMaSanPham()
        {
            List<string> masanpham = new List<string>();
            string query = "SELECT DISTINCT MSP FROM SANPHAM";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["MSP"].ToString();
                masanpham.Add(str);
            }

            return masanpham;
        }
        // Lấy danh sách sản phẩm có tên sản phẩm...... 

        public List<SanPhamBE> viewAllSanPhamByKindOfTenSP(string kindOfTenSP)
        {
            List<SanPhamBE> listSanPham = new List<SanPhamBE>();
            DataTable dt = new DataTable();
            string myQuery = "SELECT * FROM SANPHAM WHERE TENSP = N'" + kindOfTenSP + "'";

            dt = SQLHelp.executeQuery(myQuery);
            foreach (DataRow row in dt.Rows)
            {
                SanPhamBE sanpham = new SanPhamBE();
                sanpham.masp = (int)row["msp"];
                sanpham.tensp = row["tensp"].ToString();
                sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                sanpham.giaban = float.Parse(row["giaban"].ToString());
                sanpham.soluong = (int)row["soluong"];
                sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                sanpham.mancc = row["mancc"].ToString();
                sanpham.thongtin = row["thongtin"].ToString();
                sanpham.donvitinh = (int)row["donvitinh"];
                sanpham.maloaisp = (int)row["maloaisp"];

                listSanPham.Add(sanpham);
            }

            return listSanPham;
        }
        // Lấy danh sách sản phẩm có mã sản phẩm ....

        public List<SanPhamBE> viewAllSanPhamByKindOfMaSP(int kindOfMaSP)
        {
            try
            {
                List<SanPhamBE> listSanPham = new List<SanPhamBE>();
                DataTable dt = new DataTable();
                string myQuery = "SELECT * FROM SANPHAM WHERE MSP = N'" + kindOfMaSP + "'";

                dt = SQLHelp.executeQuery(myQuery);
                foreach (DataRow row in dt.Rows)
                {
                    SanPhamBE sanpham = new SanPhamBE();
                    sanpham.masp = (int)row["msp"];
                    sanpham.tensp = row["tensp"].ToString();
                    sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                    sanpham.giaban = float.Parse(row["giaban"].ToString());
                    sanpham.soluong = (int)row["soluong"];
                    sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                    sanpham.mancc = row["mancc"].ToString();
                    sanpham.thongtin = row["thongtin"].ToString();
                    sanpham.donvitinh = (int)row["donvitinh"];
                    sanpham.maloaisp = (int)row["maloaisp"];

                    listSanPham.Add(sanpham);
                }

                return listSanPham;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Lấy danh sách sản phẩm có mã nhà cung cấp ....

        public List<SanPhamBE> viewAllSanPhamByKindOfMaNCC(string kindOfMaNCC)
        {
            List<SanPhamBE> listSanPham = new List<SanPhamBE>();
            DataTable dt = new DataTable();
            string myQuery = "SELECT * FROM SANPHAM WHERE MANCC = N'" + kindOfMaNCC + "'";

            dt = SQLHelp.executeQuery(myQuery);
            foreach (DataRow row in dt.Rows)
            {
                SanPhamBE sanpham = new SanPhamBE();
                sanpham.masp = (int)row["msp"];
                sanpham.tensp = row["tensp"].ToString();
                sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                sanpham.giaban = float.Parse(row["giaban"].ToString());
                sanpham.soluong = (int)row["soluong"];
                sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                sanpham.mancc = row["mancc"].ToString();
                sanpham.thongtin = row["thongtin"].ToString();
                sanpham.donvitinh = (int)row["donvitinh"];
                sanpham.maloaisp = (int)row["maloaisp"];

                listSanPham.Add(sanpham);
            }

            return listSanPham;
        }
        //  Lấy giá sản phẩm From Cường
        public BusinessEntities.SanPhamBE getGiaSanPham(String tenSanPham)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT GIABAN, SANPHAM.MSP, SANPHAM.MALOAISP FROM SANPHAM WHERE TENSP = N'" + tenSanPham + "'");

            BusinessEntities.SanPhamBE sanPham = null;

            foreach (DataRow row in dt.Rows)
            {
                sanPham = new BusinessEntities.SanPhamBE();
                sanPham.masp = (int)row["MSP"];
                sanPham.giaban = float.Parse(row["GIABAN"].ToString());
                sanPham.maloaisp = (int)row["MALOAISP"];
            }

            return sanPham;
        }

        // Thêm một sản phẩm
        //'" + ldvt.MALOAIDONVITINH + "', N'" + ldvt.TENDONVITINH + "'

        public void insertASanPham(SanPhamBE sp)
        {
            string query = "INSERT INTO SANPHAM VALUES ('"  +sp.MASP+  "', N'" + sp.TENSP + "','" + sp.GIANHAP + "','" + sp.GIABAN + "', '" + sp.SOLUONG + "', '" + sp.SOLUONGTOITHIEU + "','" + sp.MANCC + "', N'" + sp.THONGTIN + "', '" + sp.DONVITINH + "', '" + sp.MALOAISP + "') ";
            SQLHelp.executeNonQuery(query);
        }
    // xóa sản phẩm theo thông tin 
        public void deleteASanPham(SanPhamBE sp)
        {
            try
            {
                string query = "DELETE FROM [QLCHVLXD].[dbo].[sanpham]WHERE THONGTIN= N'"+sp.THONGTIN+"'";
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



         //  Sửa thông tin sản phẩm.
        
        // Lay ten san pham theo Ma san Pham from Cường
        public BusinessEntities.SanPhamBE getTenSanPham(int maSanPham)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT TENSP FROM SANPHAM WHERE MSP = " + maSanPham);

            BusinessEntities.SanPhamBE sanPham = null;

            foreach (DataRow row in dt.Rows)
            {
                sanPham = new BusinessEntities.SanPhamBE();

                sanPham.tensp = row["TENSP"].ToString();
            }

            return sanPham;
        }


        // Lay danh sach ca san pham co ten san pham 
        public List<BusinessEntities.SanPhamBE> getListTenSanPham(String tenLoaiSanPham)
        {
            List<BusinessEntities.SanPhamBE> listsSanPham = new List<BusinessEntities.SanPhamBE>();

            DataTable dt = SQLHelp.executeQuery("SELECT TENSP, SANPHAM.MALOAISP FROM SANPHAM, LOAISANPHAM WHERE SANPHAM.MALOAISP = LOAISANPHAM.MALOAISP and LOAISANPHAM.TENLOAISP = N'" + tenLoaiSanPham + "'");

            BusinessEntities.SanPhamBE sanPham;

            foreach (DataRow row in dt.Rows)
            {
                sanPham = new BusinessEntities.SanPhamBE();

                sanPham.tensp = row["tensp"].ToString();
                sanPham.maloaisp = (int)row["maloaisp"];

                listsSanPham.Add(sanPham);
            }

            return listsSanPham;
        }
        public List<BusinessEntities.SanPhamBE> getAllListTenSanPham(String tenSanPham)
        {
            try
            {

                List<SanPhamBE> listSanPham = new List<SanPhamBE>();
                DataTable dt = new DataTable();
                string myQuery = "SELECT * FROM SANPHAM WHERE TENSP = N'" + tenSanPham + "'";

                dt = SQLHelp.executeQuery(myQuery);
                foreach (DataRow row in dt.Rows)
                {
                    SanPhamBE sanpham = new SanPhamBE();
                    sanpham.masp = (int)row["msp"];
                    sanpham.tensp = row["tensp"].ToString();
                    sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                    sanpham.giaban = float.Parse(row["giaban"].ToString());
                    sanpham.soluong = (int)row["soluong"];
                    sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                    sanpham.mancc = row["mancc"].ToString();
                    sanpham.thongtin = row["thongtin"].ToString();
                    sanpham.donvitinh = (int)row["donvitinh"];
                    sanpham.maloaisp = (int)row["maloaisp"];

                    listSanPham.Add(sanpham);
                }

                return listSanPham;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // lay danh sach san pham theo ma nha cung cap 
        public List<SanPhamBE> viewAllSanPhamByKindOfNCC(string kindOfMaSP)
        {
            try
            {
                List<SanPhamBE> listSanPham = new List<SanPhamBE>();
                DataTable dt = new DataTable();
                string myQuery = "SELECT * FROM SANPHAM WHERE MANCC = N'" + kindOfMaSP + "'";

                dt = SQLHelp.executeQuery(myQuery);
                foreach (DataRow row in dt.Rows)
                {
                    SanPhamBE sanpham = new SanPhamBE();
                    sanpham.masp = (int)row["msp"];
                    sanpham.tensp = row["tensp"].ToString();
                    sanpham.gianhap = float.Parse(row["gianhap"].ToString());
                    sanpham.giaban = float.Parse(row["giaban"].ToString());
                    sanpham.soluong = (int)row["soluong"];
                    sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                    sanpham.mancc = row["mancc"].ToString();
                    sanpham.thongtin = row["thongtin"].ToString();
                    sanpham.donvitinh = (int)row["donvitinh"];
                    sanpham.maloaisp = (int)row["maloaisp"];

                    listSanPham.Add(sanpham);
                }

                return listSanPham;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // update thong tin san pham theo ten san pham
        public void updatesanphamtheotensanpham(BusinessEntities.SanPhamBE sp)
        {
            try
            {

                string query = " UPDATE [QLCHVLXD].[dbo].[sanpham] SET [tensp] = N'" + sp.TENSP + "'," + "[gianhap] = " + sp.GIANHAP + "," + "[giaban] =" + sp.GIABAN + "," + "[soluongtoithieu]= " + sp.SOLUONGTOITHIEU + "," + "[thongtin] = N'" + sp.THONGTIN + "'WHERE [tensp]=N'" + sp.TENSP + "'";
                //string query = "UPDATE [QLCHVLXD].[dbo].[loaidonvitinh] SET [tendonvitinh] = N'" + ldvt.TENDONVITINH + "' WHERE MALOAIDONVITINH = '" + ldvt.MALOAIDONVITINH + "'";
                //string query = "UPDATE [QLCHVLXD].[dbo].[loaidonvitinh] " +
                //                    "SET TENDONVITINH = N'" + ldvt.TENDONVITINH + "'," +
                //                    "WHERE [MALOAIDONVITINH] = '" + ldvt.MALOAIDONVITINH + "'";
              //  System.Console.Out.WriteLine(query);
                SQLHelp.executeNonQuery(query);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        // cập nhật giá và số lượng sản phẩm từ nhập kho
        public void updateNhapkho(BusinessEntities.SanPhamBE sp)
        {
            try
            {

                string query = " UPDATE [QLCHVLXD].[dbo].[sanpham] SET [gianhap] = " + sp.GIANHAP + "," + "[giaban] =" + sp.GIABAN + "," + "[soluong]= soluong + " + sp.SOLUONG + " WHERE [tensp]=N'" + sp.TENSP + "'";
             
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // lấy san pham theo ten san pham
        public BusinessEntities.SanPhamBE getSanPhamTheoTen(String tenSanPham)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT * FROM SANPHAM WHERE TENSP = N'" + tenSanPham + "'");

            BusinessEntities.SanPhamBE sanPham = null;

            foreach (DataRow row in dt.Rows)
            {
                sanPham = new BusinessEntities.SanPhamBE();
                sanPham.MASP = (int)row["MSP"];
                sanPham.TENSP = row["TENSP"].ToString();
                sanPham.GIANHAP = float.Parse(row["GIANHAP"].ToString());
                sanPham.GIABAN = float.Parse(row["GIABAN"].ToString());
                sanPham.SOLUONG = (int)row["SOLUONG"];
                sanPham.SOLUONGTOITHIEU = (int)row["SOLUONGTOITHIEU"];
                sanPham.MANCC=row["MANCC"].ToString();
                sanPham.THONGTIN = row["THONGTIN"].ToString();
                sanPham.DONVITINH = (int)row["DONVITINH"];
                sanPham.maloaisp = (int)row["MALOAISP"];
            }

            return sanPham;
        }

    }
}

  