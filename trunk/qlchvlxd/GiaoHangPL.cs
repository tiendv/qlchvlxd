using System;
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

        //chon muc chiet khau
        List<BusinessEntities.ChietKhauBE> listMucChietKhau = new List<BusinessEntities.ChietKhauBE>();

        private String maGiaoHang = "";
        private float tongTien = 0;
        private float tienTra = 0;
        private float tienNo = 0;
        private bool capNhat = false;
        private float soKm = 0;

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
            //    phieuGiaoHang.maPhieuGiaoHang = "GH0002";
            //}
            //else
            //{
            //    //MessageBox.Show(phieuGiaoHang.maPhieuGiaoHang);
            //    phieuGiaoHang.maPhieuGiaoHang = TaoKhoaChinh.getIdLonNhat(listPhieuGiaoHang[listPhieuGiaoHang.Count - 1].maPhieuGiaoHang.ToString(), 2);
            //}

            //maGiaoHang = phieuGiaoHang.maPhieuGiaoHang;
            ////MessageBox.Show(phieuGiaoHang.maPhieuGiaoHang);

        }

        public void hienThi()
        {
            tongTien = 0;
            listCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();

            listMaCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD(textBox_MaHD.Text);
            
            ListViewItem lvi;
            if (listMaCTHD == null)
                return;
            //   MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listMaCTHD.Count; i++)
                {
                    sanPham = BusinessLogicLayer.SanPhamBLL.getTenSanPham(listMaCTHD[i].maSP);

                    lvi = new ListViewItem((i + 1).ToString());                    
                    lvi.SubItems.Add(sanPham.tensp);
                    lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString());
                    if (listMaCTHD[i].maCTHD == textBox_MaCTHD.Text && capNhat == true)
                    {
                    //    MessageBox.Show("T_T 1");
                        lvi.SubItems.Add(numericUpDown_SoLuong.Value.ToString());
                        lvi.SubItems.Add(listMaCTHD[i].donGia.ToString());
                        lvi.SubItems.Add(((int)numericUpDown_SoLuong.Value * listMaCTHD[i].donGia).ToString());
                        //tinh tien
                        tongTien += (int)numericUpDown_SoLuong.Value * listMaCTHD[i].donGia * float.Parse(comboBox_MucChietKhau.Text)/100;
                    }
                    else
                    {
                      //  MessageBox.Show("T_T 2");
                        lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString());
                        //if ((float)listMaCTHD[i].soLuong == float.Parse(lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString()).Text.ToString()))
                        {
                         //   MessageBox.Show("T_T 3");
                        //    lvi.SubItems.Add(listMaCTHD[i].soLuong.ToString());
                        }
                        lvi.SubItems.Add(listMaCTHD[i].donGia.ToString());
                        lvi.SubItems.Add((listMaCTHD[i].soLuong * listMaCTHD[i].donGia).ToString());
                        //tinh tien

                        if (float.Parse(comboBox_MucChietKhau.Text) != 0)
                        {
                            //MessageBox.Show(((float)100 / (float.Parse(comboBox_MucChietKhau.Text))).ToString());
                            tongTien += (float)(float.Parse(listMaCTHD[i].soLuong.ToString()) * listMaCTHD[i].donGia) / (float)((float)100 / (float.Parse(comboBox_MucChietKhau.Text)));
                        }
                        else

                            tongTien += float.Parse(listMaCTHD[i].soLuong.ToString()) * listMaCTHD[i].donGia;
                    }
                    lvi.SubItems.Add(listMaCTHD[i].maCTHD);                                       

                    listView_GiaoHang.Items.Add(lvi);

                    label_GTTongTien.Text = "";
                    
                    label_GTTongTien.Text = double.Parse(tongTien.ToString()).ToString();
                }
            }
            capNhat = false;

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            //if (listCTHD == null)
            //    textBox_MaCTHD.Text = "CT0001";
            //else
            //    textBox_MaCTHD.Text = TaoKhoaChinh.getIdLonNhat(listCTHD[listCTHD.Count - 1].maCTHD.ToString(), 2);

            //BusinessEntities.CTHoaDonBE myCTHoaDon = new BusinessEntities.CTHoaDonBE();
            //myCTHoaDon.maCTHD = textBox_MaCTHD.Text;
            //myCTHoaDon.maSP = sanPham.masp;
            //myCTHoaDon.maHD = "HD0001";
            //myCTHoaDon.soLuong = (int)numericUpDown_SoLuong.Value;
            //myCTHoaDon.donGia = sanPham.giaban;
            //myCTHoaDon.maLoaiSP = sanPham.maloaisp;

            //BusinessLogicLayer.CTHoaDonBLL.suaChiTietHoaDon(myCTHoaDon.soLuong, myCTHoaDon.maCTHD);

            ////cập nhật tổng tiền
            //tongTien += myCTHoaDon.soLuong * myCTHoaDon.donGia;
            ////label_GTTongTien.Text = tongTien.ToString();

            capNhat = true;
            listView_GiaoHang.Items.Clear();
            hienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_MaCTHD.Text == null)
                MessageBox.Show("Chọn sản phẩm bạn muốn xóa");
            else
                BusinessLogicLayer.CTHoaDonBLL.xoaChiTietHoaDon(textBox_MaCTHD.Text);

            listView_GiaoHang.Items.Clear();
            hienThi();
        }

        private void comboBox_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_GiaoHang.Items.Clear();
            hienThi();
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
           
            comboBox_MucChietKhau.Items.Clear();
            listMucChietKhau = BusinessLogicLayer.ChietKhauBLL.getListChietKhau();
            for (int i = 0; i < listMucChietKhau.Count; i++)
            {
                comboBox_MucChietKhau.Items.Add(listMucChietKhau[i].tiLeChietKhau);
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
            comboBox_TenSP.Text = "";           

            if (listView_GiaoHang.SelectedItems.Count == 0)
                return;
            comboBox_TenSP.SelectedText = listView_GiaoHang.SelectedItems[0].SubItems[1].Text;
            textBox_MaCTHD.Text = listView_GiaoHang.SelectedItems[0].SubItems[6].Text;

            
            sanPham = BusinessLogicLayer.SanPhamBLL.getGiaSanPham(comboBox_TenSP.Text);
            //MessageBox.Show(te
            textBox_DonGia.Text = sanPham.giaban.ToString();

            //comboBox_MucChietKhau.SelectedText = listView_GiaoHang.SelectedItems[0].SubItems[3].Text;
        }

        private void textBox_SoKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Số Km có kiểu số ! ");
                textBox_SoKm.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phieuGiaoHang.maHoaDon = textBox_MaHD.Text;
            DateTime date = DateTime.Now;
            phieuGiaoHang.ngayGiaoHang = date.ToShortDateString();
            phieuGiaoHang.chiPhi = tongTien;

            BusinessLogicLayer.PhieuGiaoHangBLL.themPhieuGiao(phieuGiaoHang);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LapHoaDonRPForm f = new LapHoaDonRPForm();
            f.Show();
        }      
    }
}
