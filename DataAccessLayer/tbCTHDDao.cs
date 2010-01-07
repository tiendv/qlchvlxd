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
    public class tbCTHDDao
    {
        public List<BusinessEntities.tbCTHD> getCTHoaDon()
        {
            DataTable dt = BaseDao.ExecuteDataTable("cthoadon", CommandType.TableDirect);
            List<BusinessEntities.tbCTHD> danhsachCTHD = new List<BusinessEntities.tbCTHD>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.tbCTHD cthd = new BusinessEntities.tbCTHD();

                    cthd.maCTHD = row["macthd"].ToString();
                    cthd.maHD = row["mahd"].ToString();
                    cthd.maLoaiSP = (int)row["maloaisp"];
                    cthd.maSP = (int)row["masp"];
                    cthd.soLuong =  (int)row["soluong"];
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
