using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : tiendv
* Email : tiendv.vn@gmail.com
•	Created date: 07/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/
namespace BusinessEntities
{
    public class LoaiSPBE
    {
        public LoaiSPBE()
        {}
        public int maloaisp;
        public string tenloaisp;

        public int MALOAISP
        {
            get { return this.maloaisp; }
            set
            {

                if (value ==0)
                    throw new Exception("Mã loại sản phẩm rỗng!");
                this.maloaisp = value;
            }
        }

        public string TENLOAISP
        {
            get { return this.tenloaisp; }
            set
            {

                if (value == "")
                    throw new Exception("Tên loại sản phẩm rỗng!");
                this.tenloaisp = value;
            }
        }
       

    }
}
