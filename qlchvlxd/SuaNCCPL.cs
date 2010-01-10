using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlchvlxd
{
    public partial class SuaNCCPL : Form
    {
        public string maNCC;
        public SuaNCCPL()
        {
            maNCC = "";
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DongY_Click(object sender, EventArgs e)
        {
            BusinessEntities.NhaCungCapBE nhacungcapBE = new BusinessEntities.NhaCungCapBE();
            nhacungcapBE.MANCC = this.maNCC;
            nhacungcapBE.TENNCC=textBoxTen.Text;
            nhacungcapBE.DIACHI = textBox_DiaChi.Text;
            nhacungcapBE.DIENTHOAI = textBox_DienThoai.Text;
            //MessageBox.Show(this.maNCC);
            BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
            nhacungcapBLL.suaTTNCC(nhacungcapBE);
        }

       
    }
}
