﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BusinessEntities;
using System.Data;
using System.Data.OleDb;

namespace BusinessLogicLayer
{
    public class SanPhamBLL
    {



        public static List<BusinessEntities.SanPhamBE> getDanhSachSanPham()
        {
            List<BusinessEntities.SanPhamBE> list = new List<BusinessEntities.SanPhamBE>();
            DataAccessLayer.SanPhamDAL access = new SanPhamDAL();

            //list = access.getSanPham();

            if (list == null)
                return null;

            return list;
        }     
 




        /*
        private tbsanphamDao dao;
        public tbsanphamServices()
        {
            dao = new tbsanphamDao();
        }

        public DataSet getAllSanPham()
        {
            if (dao == null)
                throw new Exception("Cannot get DB");
            return dao.getAllSanPham();
        }
         */

    }
}
