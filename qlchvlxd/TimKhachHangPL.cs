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
    public partial class TimKhachHangPL : Form
    {
        BusinessEntities.KhachHangBE khachhangBE;
        public TimKhachHangPL()
        {
            khachhangBE = new BusinessEntities.KhachHangBE();
            //rb_Hoten.Checked = true;
            InitializeComponent();
        }
        private void getTTKH()
        {
            khachhangBE.MaKhachHang = listView_KH.SelectedItems[0].SubItems[1].Text;
            khachhangBE.TenKhachHang = listView_KH.SelectedItems[0].SubItems[2].Text;
            khachhangBE.SCMND= listView_KH.SelectedItems[0].SubItems[3].Text;
            khachhangBE.GioiTinh = listView_KH.SelectedItems[0].SubItems[4].Text;
            khachhangBE.DiaChi = listView_KH.SelectedItems[0].SubItems[5].Text;
            khachhangBE.SoDienThoai = listView_KH.SelectedItems[0].SubItems[6].Text;
            khachhangBE.LoaiKhachHang = 1;
        }
        private void button_Sua__Click(object sender, EventArgs e)
        {
            try
            {
                bool chk = listView_KH.SelectedItems[0].Checked;

                SuaKhachHangPL f2 = new SuaKhachHangPL();
                getTTKH();
                f2.khachhangBE = khachhangBE;
                f2.MdiParent = this.MdiParent;
                f2.Show();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn sửa thông tin.");
            }

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool chk = listView_KH.SelectedItems[0].Checked;
                DialogResult dlr = MessageBox.Show("Bạn có chắc là muốn xóa khách hàng này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    BusinessLogicLayer.KhacHangBLL khachhangBLL = new BusinessLogicLayer.KhacHangBLL();
                    getTTKH();
                    int kq = khachhangBLL.XoaTTKHThanThiet(khachhangBE);
                    if (kq > 0)
                    {
                        MessageBox.Show("Đã xóa thành công.");
                        loaddanhsach();
                    }
                    else
                        MessageBox.Show("Xóa không thành công.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn xóa.");
            }
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            loaddanhsach();
            textBox_Tim.Text = "";
            }
        public void loaddanhsach()
        {
            listView_KH.Items.Clear();

            BusinessLogicLayer.KhacHangBLL khachhangBLL = new BusinessLogicLayer.KhacHangBLL();
            List<BusinessEntities.KhachHangBE> listKH;
            if (rb_Hoten.Checked == true)
            {
                listKH = khachhangBLL.getListKHTTtheoTen(textBox_Tim.Text);
            }
            else
            {
                if (rb_Dienthoai.Checked == true)
                    listKH = khachhangBLL.getListKHTTtheoDienThoai(textBox_Tim.Text);
                else
                    listKH = khachhangBLL.getListKHTTtheoCMND(textBox_Tim.Text);
            }
            for (int i = 0; i < listKH.Count; i++)
            {

                string[] col = new string[7];

                col[0] = i + 1 + "";
                col[1] = listKH[i].MaKhachHang;
                col[2] = listKH[i].TenKhachHang;
                col[3] = listKH[i].SCMND;
                col[4] = listKH[i].GioiTinh;
                col[5] = listKH[i].DiaChi;
                col[6] = listKH[i].SoDienThoai;
                ListViewItem lvItem = new ListViewItem(col);
                listView_KH.Items.Add(lvItem);
            }
        }
        }

        
    }

