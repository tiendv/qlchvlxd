using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
     public class NhaCungCapBLL
    {
        public int suaTTNCC(BusinessEntities.NhaCungCapBE nhacungcap)
        {
            DataAccessLayer.NhaCungCapDAL access = new DataAccessLayer.NhaCungCapDAL();
            int kq=access.SuaTTNhaCungCap(nhacungcap);
            return kq;
        }
    }
}
