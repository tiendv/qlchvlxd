using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class PhieuNhapKhoBLL
    {
        public int nhapkho(BusinessEntities.PhieuNhapKhoBE phieunhap)
        {
            DataAccessLayer.PhieuNhapKhoDAL phieunhapDAL = new DataAccessLayer.PhieuNhapKhoDAL();
            return phieunhapDAL.nhapKho(phieunhap);
        }
        public static String getMaNKMax()
        {
            List<BusinessEntities.PhieuNhapKhoBE> listPNK = new List<BusinessEntities.PhieuNhapKhoBE>();
            DataAccessLayer.PhieuNhapKhoDAL accessPNK = new DataAccessLayer.PhieuNhapKhoDAL();

            listPNK = accessPNK.getListPhieuNhapKho();
            return listPNK[listPNK.Count - 1].MANK;
        }

    }
}
