using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BusinessEntities;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    /*
    * Quan ly tat ca nhung thao tac lien quan den Nhan vien voi DB.
    * Author : Huynh Minh Duc
    * Create : Jan 6 2010 * 
    */
    public class NhanVienBLL
    {
        public NhanVienBLL()
        { 
        
        }
        /*
         * Feach
         * Author : Huynh Minh Duc
         * Date : Jan 06 2010
         */
        public List<NhanVienBE> viewAllEmployee()
        {
            List<NhanVienBE> listNhanVien = new List<NhanVienBE>();

            DataTable dt = new DataTable();

            StringBuilder myQuery = new StringBuilder("SELECT * FROM NHANVIEN");

            dt = SQLHelp.executeQuery(myQuery.ToString());

            foreach (DataRow row in dt.Rows)
            {
                NhanVienBE nv = new NhanVienBE();
                nv.MaNV = row["MANV"].ToString();
                nv.HoTenNV = row["HOTEN"].ToString();
                nv.MatKhau = row["MATKHAU"].ToString();
                nv.GioiTinh = row["GIOITINH"].ToString();
                nv.NgaySinh = row["NGAYSINH"].ToString();
                nv.SDT = row["SODIENTHOAI"].ToString();
                nv.NgayDiLam = row["NGAYBATDAU"].ToString();
                nv.QueQuan = row["QUEQUAN"].ToString();
                nv.MaLoaiNV = (int)row["MALOAINV"];                

                listNhanVien.Add(nv);
            }

            return listNhanVien;
        }
        /*
         * Lay nhung que quan cua nhan vien ra
         * 
         * Author : Huynh Minh Duc
         * Date : Jan 06 2010
         */ 
        public List<string> getAllBornPlace()
        { 
            List<string> quequan = new List<string>();
            string query = "SELECT DISTINCT QUEQUAN FROM NHANVIEN";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["QUEQUAN"].ToString();
                quequan.Add(str);
            }

            return quequan;
        }
        /*
         * 
         * 
         * 
         * 
         */
        public List<NhanVienBE> viewAllEmployeeByKindOfEmployee(int maLoaiNV)
        {
            List<NhanVienBE> listNhanVien = new List<NhanVienBE>();
            DataTable dt = new DataTable();
            string myQuery = "SELECT * FROM NHANVIEN WHERE MALOAINV = " + maLoaiNV;

            dt = SQLHelp.executeQuery(myQuery);
            //System.Console.Out.WriteLine(myQuery);
            foreach (DataRow row in dt.Rows)
            {
                NhanVienBE nv = new NhanVienBE();
                nv.MaNV = row["MANV"].ToString();
                nv.HoTenNV = row["HOTEN"].ToString();
                nv.MatKhau = row["MATKHAU"].ToString();
                nv.GioiTinh = row["GIOITINH"].ToString();
                nv.NgaySinh = row["NGAYSINH"].ToString();
                nv.SDT = row["SODIENTHOAI"].ToString();
                nv.NgayDiLam = row["NGAYBATDAU"].ToString();
                nv.QueQuan = row["QUEQUAN"].ToString();
                nv.MaLoaiNV = (int)row["MALOAINV"];

                listNhanVien.Add(nv);
            }

            return listNhanVien;
        }
        /*
         * 
         * 
         * 
         * 
         */
        public List<NhanVienBE> viewAllEmployeeByNameEmployee(string nameOfEmployee)
        {
            List<NhanVienBE> listNhanVien = new List<NhanVienBE>();
            DataTable dt = new DataTable();
            string myQuery = "SELECT * FROM NHANVIEN WHERE HOTEN = N'" + nameOfEmployee + "'";

            dt = SQLHelp.executeQuery(myQuery);
            //System.Console.Out.WriteLine(myQuery);
            foreach (DataRow row in dt.Rows)
            {
                NhanVienBE nv = new NhanVienBE();
                nv.MaNV = row["MANV"].ToString();
                nv.HoTenNV = row["HOTEN"].ToString();
                nv.MatKhau = row["MATKHAU"].ToString();
                nv.GioiTinh = row["GIOITINH"].ToString();
                nv.NgaySinh = row["NGAYSINH"].ToString();
                nv.SDT = row["SODIENTHOAI"].ToString();
                nv.NgayDiLam = row["NGAYBATDAU"].ToString();
                nv.QueQuan = row["QUEQUAN"].ToString();
                nv.MaLoaiNV = (int)row["MALOAINV"];

                listNhanVien.Add(nv);
            }

            return listNhanVien;
        }
        /*
         * Them mot dong nhan vien
         * 
         * author : Huynh Minh Duc
         * Date : Jan 6 2010
         */
        public void insertAEmployee(NhanVienBE nhanvien, float luongCB)
        {
            string query = "INSERT INTO NHANVIEN VALUES ('" + nhanvien.MaNV + "', N'" + nhanvien.HoTenNV + "','" + nhanvien.MatKhau + "', '" + nhanvien.NgaySinh + "', '" + nhanvien.SDT + "','" + nhanvien.NgayDiLam + "', N'" + nhanvien.QueQuan + "', " + nhanvien.MaLoaiNV.ToString() + ", N'" + nhanvien.GioiTinh + "')";
            SQLHelp.executeNonQuery(query);
            string query2 = "insert into bangluong values (" + new DateTime().Month.ToString() + "2010, " + nhanvien.MaNV.ToString() + ", 26, " + new DateTime().Month.ToString() + ", "+ luongCB.ToString() +", 0, "+ luongCB.ToString() +")";
            System.Console.Out.WriteLine(query2);
            SQLHelp.executeNonQuery(query2);
        }
        /*
         * Xoa nhan vien
         * 
         * 
         * 
         */
        public void deleteAEmployee(NhanVienBE nv)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = '"+ nv.MaNV +"'";
            SQLHelp.executeNonQuery(query);
        }
        /*
         * Sửa thông tin nhân viên.
         * 
         * 
         */
        public void updateEmployee(NhanVienBE nhanvien)
        {
            string query = "UPDATE NHANVIEN " +
                                "SET HOTEN = N'"+ nhanvien.HoTenNV +"'," +
                                        "GIOITINH = N'" + nhanvien.GioiTinh + "'," +
                                        "MALOAINV = "+ nhanvien.MaLoaiNV.ToString() +"," +
                                        "MATKHAU = N'"+ nhanvien.MatKhau +"'," +
                                        "NGAYSINH = '"+ nhanvien.NgaySinh +"'," +
                                        "NGAYBATDAU = '"+ nhanvien.NgayDiLam +"'," +
                                        "QUEQUAN = N'"+ nhanvien.QueQuan +"'," +
                                        "SODIENTHOAI = '" + nhanvien.SDT + "'	" +
                                "WHERE MANV = "+ nhanvien.MaNV +"";
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }
    }
}
