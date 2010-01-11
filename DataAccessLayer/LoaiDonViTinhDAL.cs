using System;
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
    public class LoaiDonViTinhDAL
    {
        public List<BusinessEntities.LoaiDonViTinhBE> getLoaiDonViTinh() 
        {
            DataTable dt = SQLHelp.executeQuery("select * from loaidonvitinh");
            List<BusinessEntities.LoaiDonViTinhBE> danhsachLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
            
            
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.LoaiDonViTinhBE ldvt = new BusinessEntities.LoaiDonViTinhBE();
                    ldvt.maloaidonvitinh = (int)row["maloaidonvitinh"];
                    ldvt.tendonvitinh = row["tendonvitinh"].ToString();

                    danhsachLoaiDonViTinh.Add(ldvt);
                    
                }
            
         
            return danhsachLoaiDonViTinh;
        }
        
        // lấy danh sách tên  đơn vị tính
        public List<BusinessEntities.LoaiDonViTinhBE> getTenLoaiDonViTinh()
        {
            List<BusinessEntities.LoaiDonViTinhBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();

            DataTable dt = SQLHelp.executeQuery("SELECT[tendonvitinh]FROM [QLCHVLXD].[dbo].[loaidonvitinh]");

            BusinessEntities.LoaiDonViTinhBE loaiDonViTinh;

            foreach (DataRow row in dt.Rows)
            {
                loaiDonViTinh = new BusinessEntities.LoaiDonViTinhBE();
                //MessageBox.Show("okkkk");

                //loaiSanPham.maloaisp = (int)row["maloaisp"];                    
                loaiDonViTinh.tendonvitinh = row["tendonvitinh"].ToString();

                listTenLoaiDonViTinh.Add(loaiDonViTinh);
            }


            return listTenLoaiDonViTinh;
        }

       
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
            try
            {
                string query = "INSERT INTO LOAIDONVITINH VALUES ('" + ldvt.MALOAIDONVITINH + "', N'" + ldvt.TENDONVITINH + "') ";
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Xóa một loại đơn vị tính tho mã lọa đơn vị tính 

        public void deleteLoaiDonViTinh(BusinessEntities.LoaiDonViTinhBE ldvt)
        {
            try
            {
                string query = "DELETE FROM LOAIDONVITINH WHERE MALOAIDONVITINH = '" + ldvt.MALOAIDONVITINH + "'";
                SQLHelp.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw e;
                //throw new Exception("Loi trong qua trinh xoa Loai Don Vi Tinh:" + e.Message.ToString());
            }
        }
        /*
         * Sửa Thông tin loại đơn vị tính
         * 
         * 
         */
        public void updateLoaiDonViTinh(BusinessEntities.LoaiDonViTinhBE ldvt)
        {
            string query = "UPDATE [QLCHVLXD].[dbo].[loaidonvitinh] SET [tendonvitinh] = N'" + ldvt.TENDONVITINH + "' WHERE MALOAIDONVITINH = '" + ldvt.MALOAIDONVITINH + "'";
      
            SQLHelp.executeNonQuery(query);
        }


        // Lấy mã đơn vị tính theo tên đơn vị tính 


        public BusinessEntities.LoaiDonViTinhBE getMaDonViTinhTuTen(string tendvt)
        {
            DataTable dt = SQLHelp.executeQuery("SELECT [maloaidonvitinh]FROM [QLCHVLXD].[dbo].[loaidonvitinh] WHERE [tendonvitinh]  = N'" + tendvt + "'");

            BusinessEntities.LoaiDonViTinhBE dvt = null;

            foreach (DataRow row in dt.Rows)
            {
                dvt = new BusinessEntities.LoaiDonViTinhBE();

                dvt.MALOAIDONVITINH =int.Parse(row["MALOAIDONVITINH"].ToString());
            }

            return dvt;
        }


    }
}
