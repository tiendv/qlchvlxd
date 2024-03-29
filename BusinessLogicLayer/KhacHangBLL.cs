﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 09/01/2010 
* Modified by: Nguyen Van B
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace BusinessLogicLayer
{
    public class KhacHangBLL
    {
        public static void themKhachHang(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            access.themKhachHang(khachHang);
        }
        public int themKhachHangThanThiet(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            int kq;
            return kq=access.themKhachHangThanThiet(khachHang);
        }
        // Sửa thông tin khách hàng thân thiết
        public int suaTTKHThanThiet(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            int kq = access.suaTTKHThanThiet(khachHang);
            return kq;
        }
        // xóa thông tin khách hàng thân thiết
        public int XoaTTKHThanThiet(BusinessEntities.KhachHangBE khachHang)
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            int kq = access.XoaTTKHThanThiet(khachHang);
            return kq;
        }
        //tìm thông tin khách hàng theo tên
        public List<BusinessEntities.KhachHangBE> getListKHTTtheoTen(String tenKH)
        {
            List<BusinessEntities.KhachHangBE> listKHTT = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            listKHTT = access.getListKhachHangThanThiet();

            if (listKHTT == null)
                return null;
            if (tenKH == "")
            {
                return listKHTT;
            }
            else
            {
                for (int i = 0; i < listKHTT.Count; i++)
                {
                    if (!listKHTT[i].TenKhachHang.Equals(tenKH))
                    {
                        listKHTT.RemoveAt(i);
                        i--;
                    }
                }

            }
            return listKHTT;
        }
        //tìm thông tin khách hàng theo CMND
        public List<BusinessEntities.KhachHangBE> getListKHTTtheoCMND(String CMND)
        {
            List<BusinessEntities.KhachHangBE> listKHTT = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            listKHTT = access.getListKhachHangThanThiet();

            if (listKHTT == null)
                return null;
            if (CMND == "")
            {
                return listKHTT;
            }
            else
            {
                for (int i = 0; i < listKHTT.Count; i++)
                {
                    if (!listKHTT[i].SCMND.Equals(CMND))
                    {
                        listKHTT.RemoveAt(i);
                        i--;
                    }
                }

            }
            return listKHTT;
        }
        //tìm thông tin khách hàng theo số điện thoại
        public List<BusinessEntities.KhachHangBE> getListKHTTtheoDienThoai(String dienthoai)
        {
            List<BusinessEntities.KhachHangBE> listKHTT = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            listKHTT = access.getListKhachHangThanThiet();

            if (listKHTT == null)
                return null;
            if (dienthoai == "")
            {
                return listKHTT;
            }
            else
            {
                for (int i = 0; i < listKHTT.Count; i++)
                {
                    if (!listKHTT[i].SoDienThoai.Equals(dienthoai))
                    {
                        listKHTT.RemoveAt(i);
                        i--;
                    }
                }

            }
            return listKHTT;
        }
        public  String getMaKHMax()
        {
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();
            
            List<BusinessEntities.KhachHangBE> listKH = access.getListKhachHangThanThiet();
            return listKH[listKH.Count - 1].MaKhachHang;
        }
        public static List<BusinessEntities.KhachHangBE> getListKhachHang()
        {
            List<BusinessEntities.KhachHangBE> list = new List<BusinessEntities.KhachHangBE>();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            list = access.getListKhachHang();

            if (list == null)
                return null;

            return list;
        }

        public static BusinessEntities.KhachHangBE getKhachHang(String maKhachHang)
        {
            BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();
            DataAccessLayer.KhachHangDAL access = new DataAccessLayer.KhachHangDAL();

            khachHang = access.getKhachHang(maKhachHang);

            if (khachHang == null)
                return null;

            return khachHang;
        }
    }
}
