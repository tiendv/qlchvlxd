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
                nv.LoaiNV = row["MALOAINV"].ToString();

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
        public List<NhanVienBE> viewAllEmployeeByKindOfEmployee(string kindOfEmployee)
        {
            List<NhanVienBE> listNhanVien = new List<NhanVienBE>();
            DataTable dt = new DataTable();
            string myQuery = "SELECT * FROM NHANVIEN WHERE LOAINV = N'" + kindOfEmployee + "'";

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
                nv.SDT = row["SDT"].ToString();
                nv.NgayDiLam = row["NGAYBATDAU"].ToString();
                nv.QueQuan = row["QUEQUAN"].ToString();
                nv.LoaiNV = row["LOAINV"].ToString();

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
                nv.SDT = row["SDT"].ToString();
                nv.NgayDiLam = row["NGAYBATDAU"].ToString();
                nv.QueQuan = row["QUEQUAN"].ToString();
                nv.LoaiNV = row["LOAINV"].ToString();

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
        public void insertAEmployee(NhanVienBE nhanvien)
        { 
            string query = "INSERT INTO NHANVIEN VALUES ('"+ nhanvien.MaNV +"', N'"+ nhanvien.HoTenNV +"','"+ nhanvien.MatKhau +"',N'"+ nhanvien.GioiTinh+"', '"+ nhanvien.NgaySinh +"', '"+ nhanvien.SDT +"','"+ nhanvien.NgayDiLam +"', N'"+ nhanvien.QueQuan +"', N'"+ nhanvien.LoaiNV +"') ";
            SQLHelp.executeNonQuery(query);
        }
        /*
         * Xoa nhan vien
         * 
         * 
         * 
         */
        public void deleteAEmployee(string manv)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = '"+ manv +"'";
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
                                        "LOAINV = N'"+ nhanvien.LoaiNV +"'," +
                                        "MATKHAU = N'"+ nhanvien.MatKhau +"'," +
                                        "NGAYSINH = '"+ nhanvien.NgaySinh +"'," +
                                        "NGAYBATDAU = '"+ nhanvien.NgayDiLam +"'," +
                                        "QUEQUAN = N'"+ nhanvien.QueQuan +"'," +
                                        "SDT = '" + nhanvien.SDT + "'	" +
                                "WHERE MANV = '"+ nhanvien.MaNV +"'";
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }
    }
}
