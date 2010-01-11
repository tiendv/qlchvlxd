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
            String ten=textBox_Ten.Text;
            String diaChi=textBox_DiaChi.Text;
            String dienThoai=textBox_DienThoai.Text;
            if (ten == "" || diaChi == "" || dienThoai == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else
            {
                BusinessEntities.NhaCungCapBE nhacungcapBE = new BusinessEntities.NhaCungCapBE();
                nhacungcapBE.TENNCC = ten;
                nhacungcapBE.DIACHI = diaChi;
                nhacungcapBE.DIENTHOAI = dienThoai;

                BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
                nhacungcapBE.MANCC = TaoKhoaChinh.getIdLonNhat(nhacungcapBLL.getMaNCCMax(), 1);
                int kq = nhacungcapBLL.themTTNCC(nhacungcapBE);
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thành công.");
                    textBox_DiaChi.Text = "";
                    textBox_DienThoai.Text = "";
                    textBox_Ten.Text= "";
                }
                else
                    MessageBox.Show("Có lỗi! Thông tin chưa được thêm vào.");
            }
        }

      
    }
}
