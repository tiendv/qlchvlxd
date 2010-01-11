using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class PhieuNhapKhoDAL
    {
        public int nhapKho(BusinessEntities.PhieuNhapKhoBE phieunhap)
        {
           
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])"
                                + "VALUES ('" +phieunhap.MANK + "' , getdate() ,"
                                 + phieunhap.TONGTIEN + ")";

            int kq=SQLHelp.executeNonQuery(myAddQuery);
            return kq;
           
        }
        public List<BusinessEntities.PhieuNhapKhoBE> getListPhieuNhapKho()
        {
            List<BusinessEntities.PhieuNhapKhoBE> listPNK = new List<BusinessEntities.PhieuNhapKhoBE>();

            System.Data.DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM PHIEUNHAPKHO");

            BusinessEntities.PhieuNhapKhoBE phieuNhapKho;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                phieuNhapKho = new BusinessEntities.PhieuNhapKhoBE();

                phieuNhapKho.MANK= row["MANK"].ToString();
                phieuNhapKho.NGAYNHAP = row["NGAYNHAP"].ToString();
                phieuNhapKho.TONGTIEN= float.Parse(row["TONGTIEN"].ToString());
                listPNK.Add(phieuNhapKho);
            }

            return listPNK;
        }
    }
}
