using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 07/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace DataAccessLayer
{
    public class CTHoaDonDAL
    {
        public List<BusinessEntities.CTHoaDonBE> getCTHoaDon()
        {
            List<BusinessEntities.CTHoaDonBE> danhSachCTHD = new List<BusinessEntities.CTHoaDonBE>();
            
            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM CTHOADON");
            
            BusinessEntities.CTHoaDonBE cthd;
            
            if (dataTable.Rows.Count == 0)
            {
                return null;
                
            }

            //for (int i = 0; i < dataTable.Rows.Count; i++)                
            foreach (DataRow row in dataTable.Rows)
            {
                cthd = new BusinessEntities.CTHoaDonBE();

                cthd.maCTHD = row["macthd"].ToString();
                cthd.maHD = row["mahd"].ToString();                
                cthd.maSP = (int)row["masp"];
                cthd.soLuong = (int)row["soluong"];
                cthd.donGia = float.Parse(row["dongia"].ToString());
             
                danhSachCTHD.Add(cthd);
            }

            return danhSachCTHD;
        }

        public void themCTHoaDon(BusinessEntities.CTHoaDonBE myCTHD)
        {
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[cthoadon]([macthd],[masp],[soluong],[dongia],[mahd],[maloaisp])"
            + " VALUES ( '" + myCTHD.maCTHD + "', '" + myCTHD.maSP + "', " + myCTHD.soLuong + "," + myCTHD.donGia + ",'" + myCTHD.maHD + "'," + myCTHD.maLoaiSP + ")";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public void xoaCTHoaDon(String maCTHD)
        {
            String myAddQuery = "DELETE CTHOADON FROM CTHOADON WHERE MACTHD = '" + maCTHD +"'";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public void xoaListCTHoaDon()
        {
            String myAddQuery = "DELETE CTHOADON FROM CTHOADON";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        
    }
}
