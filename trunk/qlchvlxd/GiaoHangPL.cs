﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : Nguyen Phuoc Cuong 
* Email : cuongnp.uit.se@gmail.com
•	Created date: 10/01/2010 
* Modified by: 
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/ 

namespace qlchvlxd
{
    public partial class GiaoHangPL : Form
    {
        //lay danh sach cac chi tiet hoa don tu bang chi tiet hoa don
        List<BusinessEntities.CTHoaDonBE> listCTHD = new List<BusinessEntities.CTHoaDonBE>();


        List<BusinessEntities.CTHoaDonBE> listMaCTHD = new List<BusinessEntities.CTHoaDonBE>();

        //lay danh sach ten cac san pham tu bang san pham
        List<BusinessEntities.SanPhamBE> listSanPham = new List<BusinessEntities.SanPhamBE>();

        BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();

        //lay danh sach ten cac loai san pham tu bang loai san pham

        List<BusinessEntities.LoaiSPBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();
        
        //lay  hoa don tu bang hoa don
        BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();

        //lay thong tin phieu giao hang
        BusinessEntities.PhieuGiaoHangBE phieuGiaoHang = new BusinessEntities.PhieuGiaoHangBE();

        //lay thong tin danh sach phieu giao hang
        List<BusinessEntities.PhieuGiaoHangBE> listPhieuGiaoHang = new List<BusinessEntities.PhieuGiaoHangBE>();

        private String maGiaoHang = "";
        private float tongTien = 0;
        private float tienTra = 0;
        private float tienNo = 0;

        public GiaoHangPL()
        {
            InitializeComponent();
            hienThi();
            listTenLoaiSanPham = BusinessLogicLayer.LoaiSPBLL.getDanhSachLoaiSP();
            //button_Tim.Enabled = false;
            button_CapNhap.Enabled = false;
            // button_XemHD.Enabled = false;
            
            listPhieuGiaoHang = BusinessLogicLayer.PhieuGiaoHangBLL.getListPhieuGiaoHang();

            phieuGiaoHang = BusinessLogicLayer.PhieuGiaoHangBLL.getPhieuGiaoHang();
           
            //if (listPhieuGiaoHang == null)
            //{
            //    phieuGiaoHang.maPhieuGiaoHang = "GH0001";                               
            //}
            //else
            //{
            //    MessageBox.Show(phieuGiaoHang.maPhieuGiaoHang);
            //    phieuGiaoHang.maPhieuGiaoHang = TaoKhoaChinh.getIdLonNhat(listPhieuGiaoHang[listPhieuGiaoHang.Count - 1].maPhieuGiaoHang.ToString(), 2);
            //}

            //maGiaoHang = phieuGiaoHang.maPhieuGiaoHang;

        }

        public void hienThi()
        {
            listCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();

            listMaCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD(textBox_MaHD.Text);
            //listView_HoaDon.MultiSelect = false;

            ListViewItem lvi;
            if (listMaCTHD == null)
                return;
            //   MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listMaCTHD.Count; i++)
                {
                    lvi = new ListViewItem((i + 1).ToString());
                    sanPham = BusinessLogicLayer.SanPhamBLL.getTenSanPham(listMaCTHD[i].maSP);
                    lvi.SubItems.Add(sanPham.tensp);
                    lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString());
                    lvi.SubItems.Add(((int)numericUpDown_SoLuong.Value).ToString());
                    lvi.SubItems.Add(listMaCTHD[i].donGia.ToString());
                    lvi.SubItems.Add((listMaCTHD[i].soLuong * listMaCTHD[i].donGia).ToString());
                    lvi.SubItems.Add(listMaCTHD[i].maCTHD);
                    listView_GiaoHang.Items.Add(lvi);
                }
            }

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (listCTHD == null)
                textBox_MaCTHD.Text = "CT0001";
            else
                textBox_MaCTHD.Text = TaoKhoaChinh.getIdLonNhat(listCTHD[listCTHD.Count - 1].maCTHD.ToString(), 2);

            BusinessEntities.CTHoaDonBE myCTHoaDon = new BusinessEntities.CTHoaDonBE();
            myCTHoaDon.maCTHD = textBox_MaCTHD.Text;
            myCTHoaDon.maSP = sanPham.masp;
            myCTHoaDon.maHD = "HD0001";
            myCTHoaDon.soLuong = (int)numericUpDown_SoLuong.Value;
            myCTHoaDon.donGia = sanPham.giaban;
            myCTHoaDon.maLoaiSP = sanPham.maloaisp;

            BusinessLogicLayer.CTHoaDonBLL.themChiTietHoaDon(myCTHoaDon);

            //cập nhật tổng tiền
            tongTien += myCTHoaDon.soLuong * myCTHoaDon.donGia;
            //label_GTTongTien.Text = tongTien.ToString();

            listView_GiaoHang.Items.Clear();
            hienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

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

        private void GiaoHangPL_Load(object sender, EventArgs e)
        {
            

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

        private void textBox_DonGia_TextChanged(object sender, EventArgs e)
        {
            button_CapNhap.Enabled = true;
            if (textBox_DonGia.Text == "")
                button_CapNhap.Enabled = false;
        }

        private void button_TimHoaDon_Click(object sender, EventArgs e)
        {
            hoaDon = BusinessLogicLayer.PhieuGiaoHangBLL.getHoaDon(textBox_MaHD.Text);
            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn này ");

                textBox_TenKH.Text = "";
                textBox_MaKHTT.Text = "";
                textBox_DiaChi.Text = "";
                textBox_DienThoai.Text = "";

            }
            else
            {
                textBox_TenKH.Text = hoaDon.tenKhachHang;
               
                if (hoaDon.loaiKhachHang == 1)
                {
                    label_KHTT.Text = "KHÁCH HÀNG THÂN THIẾT";
                }
                else
                    label_KHTT.Text = "KHÁCH HÀNG BÌNH THƯỜNG";

                textBox_MaKHTT.Text = hoaDon.maKhachHang;
                textBox_DiaChi.Text = hoaDon.diaChi;
                textBox_DienThoai.Text = hoaDon.soDienThoai;
            }

            listView_GiaoHang.Items.Clear();
            hienThi();
        }

        private void listView_GiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_LoaiSP.Text = "";
            if (listView_GiaoHang.SelectedItems.Count == 0)
                return;
            textBox_MaCTHD.Text = listView_GiaoHang.SelectedItems[0].SubItems[5].Text;

            comboBox_LoaiSP.SelectedText = listView_GiaoHang.SelectedItems[0].SubItems[3].Text;
        }
    }
}
