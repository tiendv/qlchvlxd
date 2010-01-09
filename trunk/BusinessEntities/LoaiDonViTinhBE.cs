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
    public class LoaiDonViTinhBE
    {
     
        public int maloaidonvitinh;
        public string tendonvitinh;



        public LoaiDonViTinhBE()
        { }

        public int MALOAIDONVITINH
        {
            get { return this.maloaidonvitinh; }
            set
            {

                if (value == 0)
                    throw new Exception("Mã loại đơn vị tính rỗng!");
                this.maloaidonvitinh = value;
            }
        }
        public string TENDONVITINH
        {
            get { return this.tendonvitinh; }
            set
            {

                if (value == "")
                    throw new Exception("Tên  đơn vị tính rỗng!");
                this.tendonvitinh = value;
            }
        }
       
    }
}
