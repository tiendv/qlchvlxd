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
            List<BusinessEntities.tbCTHD> danhSachCTHD = new List<BusinessEntities.tbCTHD>();
            //DataTable dataTable = BaseDao.ExecuteDataTable("PRO_CTHoaDon", CommandType.StoredProcedure);
            DataTable dataTable = BaseDao.ExecuteDataTable("SELECT * from cthoadon", CommandType.StoredProcedure);
            
            BusinessEntities.tbCTHD cthd = new BusinessEntities.tbCTHD();
            
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cthd = new BusinessEntities.tbCTHD();
                cthd.maCTHD = dataTable.Rows[i]["macthd"].ToString();
                cthd.maHD = dataTable.Rows[i]["mahd"].ToString();
                
                cthd.maSP = (int)dataTable.Rows[i]["masp"];
                cthd.soLuong = (int)dataTable.Rows[i]["soluong"];
               


                danhSachCTHD.Add(cthd);
            }

            return danhSachCTHD;
        }

        
    }
}
