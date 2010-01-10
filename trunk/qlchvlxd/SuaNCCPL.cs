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
        public BusinessEntities.NhaCungCapBE nhacungcapBE;
        public SuaNCCPL()
        {
            nhacungcapBE = new BusinessEntities.NhaCungCapBE();
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DongY_Click(object sender, EventArgs e)
        {
            nhacungcapBE.TENNCC=textBoxTen.Text;
            nhacungcapBE.DIACHI = textBox_DiaChi.Text;
            nhacungcapBE.DIENTHOAI = textBox_DienThoai.Text;
            
            BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
            nhacungcapBLL.suaTTNCC(nhacungcapBE);
        }

        private void SuaNCCPL_Load(object sender, EventArgs e)
        {
            textBoxTen.Text = nhacungcapBE.TENNCC;
            textBox_DiaChi.Text= nhacungcapBE.DIACHI;
            textBox_DienThoai.Text=nhacungcapBE.DIENTHOAI;
        }

       
    }
}
