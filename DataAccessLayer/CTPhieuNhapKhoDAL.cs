using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class CTPhieuNhapKhoDAL
    {
        public int themCTnhapKho(BusinessEntities.CTNhapKhoBE ctnhap)
        {

            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho] ([mactnk],[mank],[masp],[soluong],[giaban],[giamua])"
                                + "VALUES ('" + ctnhap.MACTNK + "' , '" + ctnhap.MANK + "', " + ctnhap.MASP + ","
                                + ctnhap.SOLUONG + ", " + ctnhap.GIABAN + ", " + ctnhap.GIAMUA + ")";
            int kq = SQLHelp.executeNonQuery(myAddQuery);
            return kq;
        }
        public List<BusinessEntities.CTNhapKhoBE> getListCTNhapKho()
        {
            List<BusinessEntities.CTNhapKhoBE> listCTNK = new List<BusinessEntities.CTNhapKhoBE>();

            System.Data.DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM CTPHIEUNHAPKHO");

            BusinessEntities.CTNhapKhoBE CTNhapKho;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }

            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                CTNhapKho = new BusinessEntities.CTNhapKhoBE();

                CTNhapKho.MACTNK = row["MACTNK"].ToString();
                CTNhapKho.MANK = row["MANK"].ToString();
                CTNhapKho.MASP = int.Parse(row["MASP"].ToString());
                CTNhapKho.SOLUONG = int.Parse(row["SOLUONG"].ToString());
                CTNhapKho.GIABAN = float.Parse(row["GIABAN"].ToString());
                CTNhapKho.GIAMUA = float.Parse(row["GIAMUA"].ToString());
                listCTNK.Add(CTNhapKho);
            }

            return listCTNK;
        }
    }
}
