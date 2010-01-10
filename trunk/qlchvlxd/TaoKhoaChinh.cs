using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlchvlxd
{
    public class TaoKhoaChinh
    {
        public static String getIdLonNhat(String tenId, int soID)
        {
            String ketQua = tenId.Substring(soID);
           
            String conlai = tenId.Substring(0, soID);
          
            int phanSo = Int32.Parse(ketQua);
            phanSo = phanSo + 1;
            ketQua = phanSo.ToString();
            tenId = conlai;

            
            //add String "0"
            for (int i = 0; i < 6 - (ketQua.Length + conlai.Length); i++)
            {
                tenId += "0";
            }

            tenId += ketQua;
            return tenId;
        }
    }
}
