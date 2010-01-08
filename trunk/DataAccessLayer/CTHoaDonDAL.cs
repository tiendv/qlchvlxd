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
    public class CTHoaDonDAL
    {
        public List<BusinessEntities.CTHoaDonBE> getCTHoaDon()
        {
            List<BusinessEntities.CTHoaDonBE> danhSachCTHD = new List<BusinessEntities.CTHoaDonBE>();
            //DataTable dataTable = BaseDao.ExecuteDataTable("PRO_CTHoaDon", CommandType.StoredProcedure);
            DataTable dataTable = SQLHelp.executeQuery("SELECT * from cthoadon");
            
            BusinessEntities.CTHoaDonBE cthd = new BusinessEntities.CTHoaDonBE();
            
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cthd = new BusinessEntities.CTHoaDonBE();
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
