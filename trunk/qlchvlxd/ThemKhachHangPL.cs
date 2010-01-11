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
    public partial class ThemKhachHangPL : Form
    {
        public ThemKhachHangPL()
        {
            //rb_Nam.Checked = true;
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            String hoTen = textBox_Ten.Text;
            String CMND = textBox_CMND.Text;
            String diaChi = textBox_DiaChi.Text;
            String dienThoai = textBox_DienThoai.Text;
            String gioiTinh ="";
            if(rb_Nam.Checked==true)
            gioiTinh = "Nam";
            gioiTinh = "Nữ";
            if (hoTen == "" || CMND == "" || diaChi == "" || dienThoai == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            else
            {
                BusinessLogicLayer.KhacHangBLL khachhangBLL = new BusinessLogicLayer.KhacHangBLL();
                BusinessEntities.KhachHangBE khachhangBE = new BusinessEntities.KhachHangBE();
                khachhangBE.TenKhachHang = hoTen;
                khachhangBE.SCMND = CMND;
                khachhangBE.DiaChi = diaChi;
                khachhangBE.SoDienThoai = dienThoai;
                khachhangBE.GioiTinh = gioiTinh;
                khachhangBE.MaKhachHang = TaoKhoaChinh.getIdLonNhat(khachhangBLL.getMaKHMax(), 2);
                int kq = khachhangBLL.themKhachHangThanThiet(khachhangBE);
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thông tin khách hàng thành công.");
                }
                else
                    MessageBox.Show("Có lỗi! Thông tin chưa được thêm vào.");
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
