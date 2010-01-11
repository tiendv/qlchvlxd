using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class CTPhieuNhapKhoBLL
    {
        public int themCTnhapkho(BusinessEntities.CTNhapKhoBE ctnhap)
        {
            DataAccessLayer.CTPhieuNhapKhoDAL ctphieunhapDAL = new DataAccessLayer.CTPhieuNhapKhoDAL();
            return ctphieunhapDAL.themCTnhapKho(ctnhap);
        }
        public static String getMaCTNKMax()
        {
            List<BusinessEntities.CTNhapKhoBE> listCTNK = new List<BusinessEntities.CTNhapKhoBE>();
            DataAccessLayer.CTPhieuNhapKhoDAL accessCTNK = new DataAccessLayer.CTPhieuNhapKhoDAL();

            listCTNK = accessCTNK.getListCTNhapKho();
            return listCTNK[listCTNK.Count - 1].MACTNK;
        }
    }
}
