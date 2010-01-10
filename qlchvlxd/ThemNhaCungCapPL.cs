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
    public partial class ThemNhaCungCapPL : Form
    {
        public ThemNhaCungCapPL()
        {
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            BusinessEntities.NhaCungCapBE nhacungcapBE = new BusinessEntities.NhaCungCapBE();
            nhacungcapBE.TENNCC = textBox_Ten.Text;
            nhacungcapBE.DIACHI = textBox_DiaChi.Text;
            nhacungcapBE.DIENTHOAI = textBox_DienThoai.Text;
            
            BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
            nhacungcapBE.MANCC=TaoKhoaChinh.getIdLonNhat(nhacungcapBLL.getMaNCCMax(),1);
            int kq = nhacungcapBLL.themTTNCC(nhacungcapBE);
            if (kq > 0)
            {
                MessageBox.Show("Đã cập nhật thành công.");
            }
            else
                MessageBox.Show("Chưa cập nhật thành công.");
        }

      
    }
}
