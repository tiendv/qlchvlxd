using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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


namespace DataAccessLayer
{
    public class ChietKhauDAL
    {
        public List<BusinessEntities.ChietKhauBE> getChietKhau()
        {
            List<BusinessEntities.ChietKhauBE> listChietKhau = new List<BusinessEntities.ChietKhauBE>();

            DataTable dataTable = SQLHelp.executeQuery("SELECT * FROM THAMSOCHIETKHAU");

            BusinessEntities.ChietKhauBE chietKhau;

            if (dataTable.Rows.Count == 0)
            {
                return null;

            }
                         
            foreach (DataRow row in dataTable.Rows)
            {
                chietKhau = new BusinessEntities.ChietKhauBE();

                chietKhau.tenChietKhau = row["TENCHIETKHAU"].ToString();              
                chietKhau.tiLeChietKhau = float.Parse(row["TILECHIETKHAU"].ToString());

                listChietKhau.Add(chietKhau);
            }

            return listChietKhau;
        }

        public void themChietKhau(BusinessEntities.ChietKhauBE chietKhau)
        {
            String myAddQuery = "INSERT INTO [QLCHVLXD].[dbo].[thamsochietkhau]([tenchietkhau],[tilechietkhau])" 
                                + " VALUES( N'"+ chietKhau.tenChietKhau + "'," + chietKhau.tiLeChietKhau + ")";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public void xoaChietKhau(String tenChietKhau)
        {
            String myAddQuery = "DELETE THAMSOCHIETKHAU FROM THAMSOCHIETKHAU WHERE TENCHIETKHAU = N'" + tenChietKhau + "'";

            SQLHelp.executeNonQuery(myAddQuery);
        }

        public void suaChietKhau(BusinessEntities.ChietKhauBE chietKhau, String _tenChietKhau)
        {
            String myAddQuery = "UPDATE [QLCHVLXD].[dbo].[thamsochietkhau]"
                                + "SET tenchietkhau = N'" + chietKhau.tenChietKhau + "',[tilechietkhau] = " + chietKhau.tiLeChietKhau 
                                + " WHERE tenchietkhau = N'" + _tenChietKhau + "'";
           // String myAddQuery = "UPDATE THAMSOCHIETKHAU SET tilechietkhau = " + chietKhau.tiLeChietKhau + " WHERE tenchietkhau = N'" + chietKhau.tenChietKhau + "'";
            SQLHelp.executeNonQuery(myAddQuery);
        }

        public void suaChietKhau(BusinessEntities.ChietKhauBE chietKhau)
        {
            
            String myAddQuery = "UPDATE THAMSOCHIETKHAU SET tilechietkhau = " + chietKhau.tiLeChietKhau + " WHERE tenchietkhau = N'" + chietKhau.tenChietKhau + "'";
            SQLHelp.executeNonQuery(myAddQuery);
        }
    }
}
