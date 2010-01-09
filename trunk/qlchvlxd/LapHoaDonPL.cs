using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 07/01/2010 
* Modified by: Nguyen Van B
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace qlchvlxd
{
    public partial class LapHoaDonPL : Form
    {
        //lay danh sach cac chi tiet hoa don tu bang chi tiet hoa don
        List<BusinessEntities.CTHoaDonBE> listCTHD = new List<BusinessEntities.CTHoaDonBE>();

        //lay danh sach ten cac san pham tu bang san pham
        List<BusinessEntities.SanPhamBE> listSanPham = new List<BusinessEntities.SanPhamBE>();

        BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();

        //lay danh sach ten cac loai san pham tu bang loai san pham
        List<BusinessEntities.LoaiSanPhamBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSanPhamBE>();

        //lay danh sach khach hang trong co so du lieu
        List<BusinessEntities.KhachHangBE> listKhachHang = new List<BusinessEntities.KhachHangBE>();


        private float tongTien = 0;
        private float tienTra = 0;
        private float tienNo = 0;

        public LapHoaDonPL()
        {
            InitializeComponent();

            hienThiChiTietHoaDon();
            listTenLoaiSanPham = BusinessLogicLayer.LoaiSanPhamBLL.getListTenLoaiSanPham();
            button_Tim.Enabled = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TraGopPL tragop = new TraGopPL();
            tragop.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập mã khách hàng thân thiết vào ô bên dưới!");
            if (maKHTT.Enabled == false)
            {
                maKHTT.Enabled = true;
                button_Tim.Enabled = true;
            }
            else
            {
                maKHTT.Enabled = false;
                button_Tim.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maKHTT.Enabled == true && maKHTT.Text == "")
                MessageBox.Show("Nhập mã khách hàng thân thiết");
            //listView_HoaDon.Items.Clear();


            listKhachHang = BusinessLogicLayer.KhacHangBLL.getListKhachHang();

            BusinessLogicLayer.CTHoaDonBLL.xoaListHoaDon();
            

            BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();
            if (listCTHD == null)
                khachHang.maKhachHang = "KH001";
            else
                khachHang.maKhachHang = TaoKhoaChinh.getIdLonNhat(listKhachHang[listKhachHang.Count - 1].maKhachHang.ToString(), 1);
            khachHang.tenKhachHang = textBox_TenKH.Text;
            khachHang.diaChi = textBox_DiaChi.Text;
            khachHang.soDienThoai = textBox_DienThoai.Text;

            BusinessLogicLayer.KhacHangBLL.themKhachHang(khachHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {

            //currentListProduct = list;            

            if (listTenLoaiSanPham == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listTenLoaiSanPham.Count; i++)
                {
                    comboBox_LoaiSP.Items.Add(listTenLoaiSanPham[i].tenloaisp);
                }
            }
        }

        public void hienThiChiTietHoaDon()
        {
            listCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();

            //listView_HoaDon.MultiSelect = false;

            ListViewItem lvi;
            if (listCTHD == null)
                return;
            //   MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    lvi = new ListViewItem((i + 1).ToString());
                    sanPham = BusinessLogicLayer.SanPhamBLL.getTenSanPham(listCTHD[i].maSP);
                    lvi.SubItems.Add(sanPham.tensp);
                    lvi.SubItems.Add(listCTHD[i].soLuong.ToString());
                    lvi.SubItems.Add(listCTHD[i].donGia.ToString());
                    lvi.SubItems.Add((listCTHD[i].soLuong * listCTHD[i].donGia).ToString());
                    lvi.SubItems.Add(listCTHD[i].maCTHD);
                    listView_HoaDon.Items.Add(lvi);
                }
            }
            
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (listCTHD == null)
                textBox_MaCTHD.Text = "CT0001";
            else
                textBox_MaCTHD.Text = TaoKhoaChinh.getIdLonNhat(listCTHD[listCTHD.Count - 1].maCTHD.ToString(),2);

            BusinessEntities.CTHoaDonBE myCTHoaDon = new BusinessEntities.CTHoaDonBE();
            myCTHoaDon.maCTHD = textBox_MaCTHD.Text;
            myCTHoaDon.maSP = sanPham.masp;
            myCTHoaDon.maHD = "001";
            myCTHoaDon.soLuong = (int)numericUpDown_SoLuong.Value;
            myCTHoaDon.donGia = sanPham.giaban;
            myCTHoaDon.maLoaiSP = sanPham.maloaisp;

            BusinessLogicLayer.CTHoaDonBLL.themChiTietHoaDon(myCTHoaDon);

            //cập nhật tổng tiền
            tongTien += myCTHoaDon.soLuong * myCTHoaDon.donGia;
            label_GTTongTien.Text = tongTien.ToString(); 

            listView_HoaDon.Items.Clear();
            hienThiChiTietHoaDon();
        }

        private void comboBox_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {           
            textBox_DonGia.Clear();
            comboBox_TenSP.Items.Clear();

            //int maLoaiSanPham = comboBox_LoaiSP.SelectedItem.ToString();

            listSanPham = BusinessLogicLayer.SanPhamBLL.getListTenSanPham(comboBox_LoaiSP.SelectedItem.ToString());

            if (listSanPham == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listSanPham.Count; i++)
                {
                    comboBox_TenSP.Items.Add(listSanPham[i].tensp);
                }
            }
        }

        private void comboBox_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_DonGia.Clear();
            sanPham = BusinessLogicLayer.SanPhamBLL.getGiaSanPham(comboBox_TenSP.SelectedItem.ToString());

            if (sanPham == null)
                MessageBox.Show("Không tồn tại sản phẩm phù hợp!");
            else
            {
                textBox_DonGia.Text = sanPham.giaban.ToString();
            }
        }

        private void listView_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_HoaDon.SelectedItems.Count == 0)
                return;
            textBox_MaCTHD.Text = listView_HoaDon.SelectedItems[0].SubItems[5].Text;
            //textBoxMAHV.Text = listViewHV.SelectedItems[0].SubItems[0].Text;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_MaCTHD.Text == null)
                MessageBox.Show("Chọn sản phẩm bạn muốn xóa");
            else
                BusinessLogicLayer.CTHoaDonBLL.xoaChiTietHoaDon(textBox_MaCTHD.Text);

            listView_HoaDon.Items.Clear();
            hienThiChiTietHoaDon();
        }

        public float tinhTien()
        {
            textBox_SoTienTra.Text = tongTien.ToString();
 
            return tongTien;
            //textBox_MaCTHD.Text = listView_HoaDon.SelectedItems[0].SubItems[4].Text;
        }

        private void textBox_SoTienTra_TextChanged(object sender, EventArgs e)
        {

            if (textBox_SoTienTra.Text != "")
            {
                tienTra = float.Parse(textBox_SoTienTra.Text);
                tienNo = tongTien - tienTra;
            }
            label_GTTongTien.Text = tongTien.ToString();
            label_GTTienNo.Text = tienNo.ToString();
            
        }

        private void numericUpDown_SoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();

            khachHang = BusinessLogicLayer.KhacHangBLL.getKhachHang(maKHTT.Text);
            
            if (khachHang == null)
                MessageBox.Show("Không tồn tại mã khách hàng.");
            else
            {
                textBox_TenKH.Text = khachHang.tenKhachHang;
                textBox_DiaChi.Text = khachHang.diaChi;
                textBox_DienThoai.Text = khachHang.soDienThoai;
            }
        }
    }
}
