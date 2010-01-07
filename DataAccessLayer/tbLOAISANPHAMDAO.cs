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
    public class tbLOAISANPHAMDAO
    {
        public List<BusinessEntities.tbLOAISANPHAM> getLoaiSanPham()
        {
            DataTable dt = BaseDao.ExecuteDataTable("loaisanpham", CommandType.TableDirect);
            List<BusinessEntities.tbLOAISANPHAM> danhsachLOAISANPHAM = new List<BusinessEntities.tbLOAISANPHAM>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.tbLOAISANPHAM loaisanpham = new BusinessEntities.tbLOAISANPHAM();

                    loaisanpham.maloaisp = (int)row["maloaisp"];
                    loaisanpham.tenloaisanpham = row["tenloaisp"].ToString();
                   
                    danhsachLOAISANPHAM.Add(loaisanpham);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachLOAISANPHAM;
        }
    }
}
