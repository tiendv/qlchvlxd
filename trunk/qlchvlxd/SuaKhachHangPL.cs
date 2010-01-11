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
    public partial class SuaKhachHangPL : Form
    {
        public BusinessEntities.KhachHangBE khachhangBE;

        public SuaKhachHangPL()
        {
            khachhangBE = new BusinessEntities.KhachHangBE();
            InitializeComponent();
        }

        private void button_DongY_Click(object sender, EventArgs e)
        {
            
            String diaChi = textBox_diaChi.Text;
            String dienThoai = textBox_dienThoai.Text;
            if (diaChi == "" || dienThoai == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else
            {
                khachhangBE.DiaChi = diaChi;
                
                khachhangBE.SoDienThoai = dienThoai;

                BusinessLogicLayer.KhacHangBLL khachhangBLL = new BusinessLogicLayer.KhacHangBLL();
                int kq = khachhangBLL.suaTTKHThanThiet(khachhangBE);
                if (kq > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công.");
                }
                else
                    MessageBox.Show("Chưa cập nhật thành công.");
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
