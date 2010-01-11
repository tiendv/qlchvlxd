using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class PhieuGiaoHangBLL
    {
        public static BusinessEntities.CTHoaDonBE getHoaDon(String maHoaDon)
        {
            BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();
            DataAccessLayer.PhieuGiaoHangDAL access = new DataAccessLayer.PhieuGiaoHangDAL();

            hoaDon = access.getHoaDon(maHoaDon);

            if (hoaDon == null)
                return null;

            return hoaDon;
        }

        public static BusinessEntities.PhieuGiaoHangBE getPhieuGiaoHang()
        {
            BusinessEntities.PhieuGiaoHangBE phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();
            DataAccessLayer.PhieuGiaoHangDAL access = new DataAccessLayer.PhieuGiaoHangDAL();

            phieuGiaoHang = access.getPhieuGiaoHang();

            if (phieuGiaoHang == null)
                return null;

            return phieuGiaoHang;
        }

        public static List<BusinessEntities.PhieuGiaoHangBE> getListPhieuGiaoHang()
        {
            List<BusinessEntities.PhieuGiaoHangBE> listPhieuGiaoHang = new List<BusinessEntities.PhieuGiaoHangBE> ();
            DataAccessLayer.PhieuGiaoHangDAL access = new DataAccessLayer.PhieuGiaoHangDAL();

            listPhieuGiaoHang = access.getlistPhieuGiaoHang();

            if (listPhieuGiaoHang == null)
                return null;

            return listPhieuGiaoHang;
        }

        public static void themPhieuGiao(BusinessEntities.PhieuGiaoHangBE phieuGiaoHang)
        {
            DataAccessLayer.PhieuGiaoHangDAL access = new DataAccessLayer.PhieuGiaoHangDAL();

            access.themPhieuGiaoHang(phieuGiaoHang);
        }
    }
}
