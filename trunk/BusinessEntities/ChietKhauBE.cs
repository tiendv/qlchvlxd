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

namespace BusinessEntities
{
    public class ChietKhauBE
    {
        public String tenChietKhau = "";       
        public float tiLeChietKhau; 

      
        public String TenChietKhau
        {
            get { return this.tenChietKhau; }
            set { this.tenChietKhau = value;}
        }

        public float TiLeChietKhau
        {
            get { return this.tiLeChietKhau; }
            set { this.tiLeChietKhau = value; }
        }
    }
}
