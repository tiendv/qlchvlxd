using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;

namespace DataAccessLayer
{
    class LoaiSPDAL
    {
        public static List<BusinessEntities.CTHoaDonBE> getLoaiSanPham()
        {
            DataTable dt = SQLHelp.executeQuery("select * from cthoadon");
            List<BusinessEntities.CTHoaDonBE> danhsachCTHD = new List<BusinessEntities.CTHoaDonBE>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.CTHoaDonBE cthd = new BusinessEntities.CTHoaDonBE();
                    cthd.maCTHD = row["macthd"].ToString();
                    cthd.maHD = row["mahd"].ToString();
                    cthd.maLoaiSP = (int)row["maloaisp"];
                    cthd.maSP = (int)row["masp"];
                    cthd.soLuong = (int)row["soluong"];
                    cthd.donGia = (float)row["dongia"];

                    danhsachCTHD.Add(cthd);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachCTHD;
        }
    }
}
