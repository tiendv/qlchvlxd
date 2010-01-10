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
            String ten=textBoxTen.Text;
            String diaChi=textBox_DiaChi.Text;
            String dienThoai=textBox_DienThoai.Text;
            if (ten == "" || diaChi == "" || dienThoai == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else
            {
                nhacungcapBE.TENNCC = ten;
                nhacungcapBE.DIACHI = diaChi;
                nhacungcapBE.DIENTHOAI = dienThoai;

                BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
                int kq = nhacungcapBLL.suaTTNCC(nhacungcapBE);
                if (kq > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công.");
                }
                else
                    MessageBox.Show("Chưa cập nhật thành công.");
            }
        }

        private void SuaNCCPL_Load(object sender, EventArgs e)
        {
            textBoxTen.Text = nhacungcapBE.TENNCC;
            textBox_DiaChi.Text= nhacungcapBE.DIACHI;
            textBox_DienThoai.Text=nhacungcapBE.DIENTHOAI;
        }

       
    }
}
