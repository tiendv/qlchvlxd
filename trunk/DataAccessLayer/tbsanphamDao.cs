using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Data.OleDb;
using BusinessEntities;


namespace DataAccessLayer
{
    public class tbsanphamDao:BaseDao
    {
         public List<BusinessEntities.tbsanpham> getSanPham()
        {
            DataTable dt = BaseDao.ExecuteDataTable("sanpham", CommandType.TableDirect);
            List<BusinessEntities.tbsanpham> danhsachSANPHAM = new List<BusinessEntities.tbsanpham>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.tbsanpham sanpham = new BusinessEntities.tbsanpham();

                    sanpham.masp= (int)row["masp"];
                    sanpham.tensp = row["tensp"].ToString();
                    sanpham.gianhap=(float)row["gianhap"];
                    sanpham.giaban=(float)row["giaban"];
                    sanpham.soluong = (int)row["soluong"];
                    sanpham.soluongtoithieu = (int)row["soluongtoithieu"];
                    sanpham.mancc = row["mancc"].ToString();
                    sanpham.thongtin = row["dongia"].ToString();
                    sanpham.donvitinh=row["donvitinh"].ToString();
                    sanpham.maloaisp= (int)row["maloaisp"];


                    danhsachSANPHAM.Add(sanpham);                    
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachSANPHAM;

          /*      public SqlDataAdapter daMT;
        //constructor///////////////////////////////////
        
        public tbsanphamDao(): base()
        {
        }

/// Lấy tất cả Sản phẩm trong bảng
/// </summary>
/// <returns>Danh sách Sản Phẩm </returns>
        public DataSet getAllSanPham()
        {
           
                DataSet ds = new DataSet();
                daMT = new SqlDataAdapter("select * from user", sqlCon);
                daMT.Fill(ds, "demo");

                return ds;
          
        }   */     

    }
}
