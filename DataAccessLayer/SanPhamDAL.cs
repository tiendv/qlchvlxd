using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using BusinessEntities;

/*
   * Quan ly tat ca nhung thao tac lien quan den SanPham voi DB.
   * Author : tiendv
   * Create : Jan 8 2010 * 
   */

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
            List<SanPhamBE> listSanPham= new List<SanPhamBE>();
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

        // Thêm một sản phẩm

        public void insertASanPham(SanPhamBE sp)
        {
            string query = "INSERT INTO SANPHAM VALUES ('" + sp.MASP + "', N'" + sp.TENSP + "','" + sp.GIANHAP + "','" + sp.GIABAN + "', '" + sp.SOLUONG + "', '" + sp.SOLUONGTOITHIEU + "','" + sp.MANCC + "', N'" + sp.THONGTIN + "', '" + sp.DONVITINH + "', '" + sp.MALOAISP + "') ";
            SQLHelp.executeNonQuery(query);
        }
        // xóa sản phẩm có mã sản phẩm ......
        public void deleteASanPham(int msp)
        {
            string query = "DELETE FROM SANPHAM WHERE MSP = '" + msp + "'";
            SQLHelp.executeNonQuery(query);
        }

         //  Sửa thông tin sản phẩm.
        
        public void updateEmployee(SanPhamBE sp)
        {
            string query = "UPDATE SANPHAM " +
                                "SET MSP = "+ sp.MASP +"'," +
                                        "TENSP = N'" + sp.TENSP + "'," +
                                        "GIANHAP = '"+ sp.GIANHAP +"'," +
                                        "GIABAN = '"+ sp.GIABAN +"'," +
                                        "SOLUONG = '"+ sp.SOLUONG +"'," +
                                        "SOLUONGTOITHIEU = '"+ sp.SOLUONGTOITHIEU +"'," +
                                        "MANCC = "+ sp.MANCC +"'," +
                                        "THONGTIN = N'" + sp.THONGTIN + "'," +
                                        "DONVITINH = "+ sp.DONVITINH +"'," +
                                        "MALOAISP = "+ sp.MANCC +"'," +
                                "WHERE MSP = '"+ sp.MASP +"'";
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }

    }
}

  