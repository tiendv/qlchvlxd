using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 09/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace BusinessLogicLayer
{
    public class ChietKhauBLL
    {
        public static List<BusinessEntities.ChietKhauBE> getListChietKhau()
        {
            List<BusinessEntities.ChietKhauBE> list = new List<BusinessEntities.ChietKhauBE>();
            DataAccessLayer.ChietKhauDAL access = new DataAccessLayer.ChietKhauDAL();

            list = access.getChietKhau();

            if (list == null)
                return null;

            return list;
        }

        public static void themChietKhau(BusinessEntities.ChietKhauBE chietkhau)
        {
            DataAccessLayer.ChietKhauDAL access = new DataAccessLayer.ChietKhauDAL();

            access.themChietKhau(chietkhau);
        }

        public static void xoaChietKhau(String tenChietKhau)
        {
            DataAccessLayer.ChietKhauDAL access = new DataAccessLayer.ChietKhauDAL();

            access.xoaChietKhau(tenChietKhau);
        }

        public static void suaChietKhau(BusinessEntities.ChietKhauBE chietkhau, String tenChietKhau)
        {
            DataAccessLayer.ChietKhauDAL access = new DataAccessLayer.ChietKhauDAL();

            access.suaChietKhau(chietkhau, tenChietKhau);            
        }

        public static void suaChietKhau(BusinessEntities.ChietKhauBE chietkhau)
        {
            DataAccessLayer.ChietKhauDAL access = new DataAccessLayer.ChietKhauDAL();

            access.suaChietKhau(chietkhau);

        }
    }
}
