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
    public class tbLOAIDONVITINHDAO
    {
        public List<BusinessEntities.tbLOAIDONVITINH> getLoaiDonViTinh()
        {
            DataTable dt = BaseDao.ExecuteDataTable("loaidonvitinh", CommandType.TableDirect);
            List<BusinessEntities.tbLOAIDONVITINH> danhsachLOAIDONVITINH = new List<BusinessEntities.tbLOAIDONVITINH>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    BusinessEntities.tbLOAIDONVITINH loaidonvitinh = new BusinessEntities.tbLOAIDONVITINH();

                    loaidonvitinh.maloaidonvitinh= (int)row["madonvitinh"];
                    loaidonvitinh.tenloaidonvitinh = row["tenloaidonvitinh"].ToString();

                    danhsachLOAIDONVITINH.Add(loaidonvitinh);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return danhsachLOAIDONVITINH;
        }
    }
}
