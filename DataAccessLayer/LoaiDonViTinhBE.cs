using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;

/*
   * Quan ly tat ca nhung thao tac lien quan den loai don vi tinh  voi DB.
   * Author : tiendv
   * Create : Jan 8 2010 * 
   */

namespace DataAccessLayer
{
    public class LoaiDonViTinhBE
    {
        public List<BusinessEntities.LoaiDonViTinhBE> getLoaiDonViTinh()
        {
            DataTable dt = SQLHelp.executeQuery("select * from loaidonvitinh");
            List<BusinessEntities.LoaiDonViTinhBE> danhsachLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
            
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.LoaiDonViTinhBE ldvt = new BusinessEntities.LoaiDonViTinhBE();
                    ldvt.maloaidonvitinh = (int)row["maloaidonvitinh"];
                    ldvt.tendonvitinh = row["tendonvitinh"].ToString();

                    danhsachLoaiDonViTinh.Add(ldvt);
                    
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachLoaiDonViTinh;
        }
        // lấy danh sách đơn vị tính

        public List<string> getAllTenDonViTinh()
        {
            List<string> tendonvitinh = new List<string>();
            string query = "SELECT DISTINCT TENDONVITINH FROM LOAIDONVITINH";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["TENDONVITINH"].ToString();
                tendonvitinh.Add(str);
            }

            return tendonvitinh;
        }
        // lấy danh sách mã đơn vị tính

        public List<string> getAllMaDonViTinh()
        {
            List<string> madvt = new List<string>();
            string query = "SELECT DISTINCT MALOAIDONVITINH FROM LOAIDONVITINH";
            DataTable dt = new DataTable();

            dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string str = row["MALOAIDONVITINH"].ToString();
                madvt.Add(str);
            }

            return madvt;
        }

        // Thêm một loại đơn vị tính
        BusinessEntities.LoaiDonViTinhBE ldvt = new BusinessEntities.LoaiDonViTinhBE();

        public void insertLoaiDonViTinh( BusinessEntities.LoaiDonViTinhBE ldvt )
        {
            string query = "INSERT INTO LOAIDONVITINH VALUES ('" + ldvt.MALOAIDONVITINH + "', N'" + ldvt.TENDONVITINH + "') ";
            SQLHelp.executeNonQuery(query);

        }

        // Xóa một loại đơn vị tính 

        public void deleteLoaiDonViTinh(int maloaidonvitinh)
        {
            string query = "DELETE FROM LOAIDONVITINH WHERE MALOAIDONVITINH = '" + maloaidonvitinh + "'";
            SQLHelp.executeNonQuery(query);
        }
        /*
         * Sửa Thông tin loại đơn vị tính
         * 
         * 
         */
        public void updateLoaiDonViTinh(BusinessEntities.LoaiDonViTinhBE ldvt)
        {
            string query = "UPDATE LOAIDONVITINH " +
                                "SET MALOAIDONVITINH =" + ldvt.MALOAIDONVITINH + "'," +
                                        "TENDONVITINH = N'" + ldvt.TENDONVITINH + "'," +
                                "WHERE MALOAIDONVITINH = '" + ldvt.MALOAIDONVITINH + "'";
            System.Console.Out.WriteLine(query);
            SQLHelp.executeNonQuery(query);
        }


    }
}
