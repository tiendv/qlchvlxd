using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class ThongSoTinhLuongBLL
    {
        public ThongSoTinhLuongBLL()
        { 
        
        }
        public List<ThongSoTinhLuongBE> viewAll()
        {
            List<ThongSoTinhLuongBE> list = new List<ThongSoTinhLuongBE>();

            string query = "SELECT * FROM THONGSOTINHLUONG";
            DataTable dt = SQLHelp.executeQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                ThongSoTinhLuongBE thongso = new ThongSoTinhLuongBE();

                thongso.MaLoaiNhanVien = (int)row["MALOAINV"];
                thongso.TenLoaiNhanVien = row["TENLOAINV"].ToString();
                thongso.LuongCoBan = float.Parse(row["LUONGCOBAN"].ToString());

                list.Add(thongso);
            }

            return list;
        }
    }
}
