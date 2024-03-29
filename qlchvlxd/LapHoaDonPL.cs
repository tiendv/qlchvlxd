﻿using System;
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

        List<BusinessEntities.CTHoaDonBE> listMaCTHD = new List<BusinessEntities.CTHoaDonBE>();

        //lay danh sach ten cac san pham tu bang san pham
        List<BusinessEntities.SanPhamBE> listSanPham = new List<BusinessEntities.SanPhamBE>();

        BusinessEntities.SanPhamBE sanPham = new BusinessEntities.SanPhamBE();

        BusinessEntities.SanPhamBE soLuongSanPham = new BusinessEntities.SanPhamBE();

        //lay danh sach ten cac loai san pham tu bang loai san pham
      
        List<BusinessEntities.LoaiSPBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();

        //lay danh sach khach hang trong co so du lieu
        List<BusinessEntities.KhachHangBE> listKhachHang = new List<BusinessEntities.KhachHangBE>();


        //lay danh sach hoa don
        List<BusinessEntities.CTHoaDonBE> listHoaDon = new List<BusinessEntities.CTHoaDonBE>();

        BusinessEntities.CTHoaDonBE hoaDon = new BusinessEntities.CTHoaDonBE();
        BusinessEntities.CTHoaDonBE myCTHoaDon = new BusinessEntities.CTHoaDonBE();

        private float tongTien = 0;
     
        private bool createable = true;

        public LapHoaDonPL()
        {
            InitializeComponent();

            hienThiChiTietHoaDon();
            listTenLoaiSanPham = BusinessLogicLayer.LoaiSPBLL.getDanhSachLoaiSP();
            button_Tim.Enabled = false;
            button_Them.Enabled = false;
            button_XemHD.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TraGopPL tragop = new TraGopPL();
            tragop.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_KHTT.Checked == true)
            {
                MessageBox.Show("Nhập mã khách hàng thân thiết vào ô bên dưới!");
                
                maKHTT.Enabled = true;
                button_Tim.Enabled = true;
   
            }
            else
            {
                maKHTT.Enabled = false;
                button_Tim.Enabled = false;
                maKHTT.Text = "";
                textBox_TenKH.Text = "";
                textBox_DiaChi.Text = "";
                textBox_DienThoai.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            /*********************************************************
             * 
             * 
             * 
             * Tao 1 khach hang
             * 
             * 
             * *******************************************************/
            if (maKHTT.Enabled == true && maKHTT.Text == "")
                MessageBox.Show("Nhập mã khách hàng thân thiết");
          
                listKhachHang = BusinessLogicLayer.KhacHangBLL.getListKhachHang();

                //BusinessLogicLayer.CTHoaDonBLL.xoaListHoaDon();


                if (textBox_TenKH.Text != "" && textBox_DiaChi.Text != "" && textBox_DienThoai.Text != "")
                {
                    BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();
                    if (maKHTT.Text == "")
                    {
                        if (listKhachHang == null)
                            khachHang.maKhachHang = "KH0001";
                        else
                            khachHang.maKhachHang = TaoKhoaChinh.getIdLonNhat(listKhachHang[listKhachHang.Count - 1].maKhachHang.ToString(), 2);


                        khachHang.tenKhachHang = textBox_TenKH.Text;
                        khachHang.diaChi = textBox_DiaChi.Text;
                        khachHang.soDienThoai = textBox_DienThoai.Text;

                        //them 1 khach hang vao table KHACHHANG
                        BusinessLogicLayer.KhacHangBLL.themKhachHang(khachHang);
                    }
                    else
                    {
                        khachHang = BusinessLogicLayer.KhacHangBLL.getKhachHang(maKHTT.Text);

                    }
                    /*********************************************************
                     * 
                     * 
                     * 
                     * Tao HoaDon va luu vao database
                     * 
                     * 
                     * *******************************************************/
                    hoaDon.maHD = textBox_MaHD.Text;
                    hoaDon.maNhanVien = 1;
                    hoaDon.maKhachHang = khachHang.maKhachHang;
                    hoaDon.tongTien = tongTien;
                    hoaDon.tienTra = tongTien;
                    hoaDon.tienNo = 0;
                    DateTime date = DateTime.Now;
                    hoaDon.ngayLapHoaDon = date.ToShortDateString();
                    hoaDon.chietKhau = 0;
                    hoaDon.giaoHang = 0;

                    BusinessLogicLayer.CTHoaDonBLL.suaHoaDon(hoaDon, hoaDon.maHD);

                    MessageBox.Show("ĐÃ TẠO THÀNH CÔNG HÓA ĐƠN!");

                    capNhatSoLuongSanPham();

                    LapHoaDonRPForm f2 = new LapHoaDonRPForm();
                    f2.Show();
                   
                }
                else
                {
                    MessageBox.Show("NHẬP ĐẦY ĐỦ THÔNG TIN TRƯỚC KHI XEM HÓA ĐƠN!");
                }

                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            tongTien = 0;

            listHoaDon = BusinessLogicLayer.CTHoaDonBLL.getListHoaDon();
            hoaDon = new BusinessEntities.CTHoaDonBE();

            if (listHoaDon == null)
                hoaDon.maHD = "HD0001";
            else
                hoaDon.maHD = TaoKhoaChinh.getIdLonNhat(listHoaDon[listHoaDon.Count - 1].maHD.ToString(), 2);

            hoaDon.maNhanVien = 1;
            textBox_MaHD.Text = hoaDon.maHD;

            BusinessLogicLayer.CTHoaDonBLL.themHoaDon(hoaDon);

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

                    soLuongSanPham = BusinessLogicLayer.SanPhamBLL.getGiaSanPham(sanPham.tensp);

                    if (listMaCTHD[i].soLuong > soLuongSanPham.soluong)
                    {
                        MessageBox.Show("Số lượng trong kho không đủ.");
                        MessageBox.Show("Mặc hàng này trong kho còn " + soLuongSanPham.soluong.ToString() + " " + soLuongSanPham.tendonvitinh);
                        lvi.ForeColor = Color.Red;
                        createable = false;
                    }

                    lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString());
                    lvi.SubItems.Add(listMaCTHD[i].donGia.ToString());
                    lvi.SubItems.Add(((float)listMaCTHD[i].soLuong * listMaCTHD[i].donGia).ToString());
                    lvi.SubItems.Add(listMaCTHD[i].maCTHD);
                    listView_HoaDon.Items.Add(lvi);
                }
            }
            
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            button_Them.Enabled = false;
            button_XemHD.Enabled = true;
   
            if (listMaCTHD == null)
                textBox_MaCTHD.Text = "CT0001";
            else
                textBox_MaCTHD.Text = TaoKhoaChinh.getIdLonNhat(listMaCTHD[listMaCTHD.Count - 1].maCTHD.ToString(),2);

            myCTHoaDon = new BusinessEntities.CTHoaDonBE();
            myCTHoaDon.maCTHD = textBox_MaCTHD.Text;
            myCTHoaDon.maSP = sanPham.masp;
            myCTHoaDon.maHD = textBox_MaHD.Text;
            myCTHoaDon.soLuong = (int)numericUpDown_SoLuong.Value;
            myCTHoaDon.donGia = sanPham.giaban;
            myCTHoaDon.maLoaiSP = sanPham.maloaisp;
            myCTHoaDon.thanhTien = (float)myCTHoaDon.soLuong * myCTHoaDon.donGia;

            BusinessLogicLayer.CTHoaDonBLL.themChiTietHoaDon(myCTHoaDon);

            //cập nhật tổng tiền
            tongTien += float.Parse(myCTHoaDon.soLuong.ToString()) * myCTHoaDon.donGia;
            

            label_GTTongTien.Text = double.Parse(tongTien.ToString()).ToString() + " VND";

            listView_HoaDon.Items.Clear();
            hienThiChiTietHoaDon();
        }

        private void comboBox_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {           
            textBox_DonGia.Clear();
            comboBox_TenSP.Items.Clear();

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
            button_Them.Enabled = true;
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

        private void button_Tim_Click(object sender, EventArgs e)
        {
            textBox_TenKH.Text = "";
            textBox_DiaChi.Text = "";
            textBox_DienThoai.Text = "";

            BusinessEntities.KhachHangBE khachHang = new BusinessEntities.KhachHangBE();

            khachHang = BusinessLogicLayer.KhacHangBLL.getKhachHang(maKHTT.Text);

            if (khachHang == null)
            {
                checkBox_KHTT.Checked = false;
                MessageBox.Show("Không tồn tại mã khách hàng.");
            }
            else
            {
                textBox_TenKH.Text = khachHang.tenKhachHang;
                textBox_DiaChi.Text = khachHang.diaChi;
                textBox_DienThoai.Text = khachHang.soDienThoai;
            }
        }

        private void textBox_DonGia_TextChanged(object sender, EventArgs e)
        {
            button_Them.Enabled = true;
            if (textBox_DonGia.Text == "")
                button_Them.Enabled = false;
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            float thanhTien = float.Parse(numericUpDown_SoLuong.Value.ToString()) * float.Parse(textBox_DonGia.Text); 
            BusinessLogicLayer.CTHoaDonBLL.suaChiTietHoaDon((int)numericUpDown_SoLuong.Value, thanhTien, textBox_MaCTHD.Text);

            listView_HoaDon.Items.Clear();
            hienThiChiTietHoaDon();
        }
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            LapHoaDonRPForm f2 = new LapHoaDonRPForm();
            f2.Show();

        }

        private void capNhatSoLuongSanPham()
        {
            listCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();
            
            ListViewItem lvi;
            if (listMaCTHD == null)
                return;
            //   MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listMaCTHD.Count; i++)
                {
                    int soluongcon = soLuongSanPham.soluong - listMaCTHD[i].soLuong;

                    BusinessLogicLayer.SanPhamBLL.suadSoLuongSanPham(soluongcon,  listCTHD[i].maSP);
                }
            }
        }

    }
}
