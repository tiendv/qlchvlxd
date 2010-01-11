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
    public partial class NhapKhoPL : Form
    {
        public NhapKhoPL()
        {
            InitializeComponent();
        }
        private void comboBox_LSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SP.Items.Clear();
            List<BusinessEntities.SanPhamBE> listtenSP = BusinessLogicLayer.SanPhamBLL.getListTenSanPham(comboBox_LSP.SelectedItem.ToString());
            for (int i = 0; i < listtenSP.Count; i++)
            comboBox_SP.Items.Add(listtenSP[i].TENSP);
        }

        private void comboBox_LSP_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_LSP.Items.Clear();
            List<BusinessEntities.LoaiSPBE> listloaiSP=BusinessLogicLayer.LoaiSPBLL.getListTenLoaiSanPham() ;
            for (int i = 0; i < listloaiSP.Count;i++ )
                comboBox_LSP.Items.Add(listloaiSP[i].TENLOAISP);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            String tensp = comboBox_SP.SelectedItem.ToString();
            String soluong = textBox_SoLuong.Text;
            String giamua = textBox_GiaMua.Text;
            String giaban = textBox_GiaBan.Text;
            if (soluong == "" || giamua == "" || giaban == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                string[] col = new string[5];

                col[0] = listView_NhapKho.Items.Count + 1 + "";
                col[1] = tensp;
                col[2] = soluong;
                col[3] = giamua;
                col[4] = giaban;
                ListViewItem lvItem = new ListViewItem(col);
                listView_NhapKho.Items.Add(lvItem);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool chk = listView_NhapKho.SelectedItems[0].Checked;
                DialogResult dlr = MessageBox.Show("Bạn có chắc là muốn xóa dòng này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    listView_NhapKho.Items.RemoveAt(listView_NhapKho.SelectedIndices[0]);
                    for (int i = 0; i < listView_NhapKho.Items.Count; i++)
                        listView_NhapKho.Items[i].SubItems[0].Text = i + 1 + "";
                }
            }
            catch (ArgumentOutOfRangeException exp)
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa.");
            }
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SPmoi_Click(object sender, EventArgs e)
        {
            ThemSanPhamPL frmForm2 = new ThemSanPhamPL();
            frmForm2.Show();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = listView_NhapKho.Items.Count;
                //tạo khóa chính cho phiếu nhập kho và chi tiết phiếu nhập
                String maNK = TaoKhoaChinh.getIdLonNhat(BusinessLogicLayer.PhieuNhapKhoBLL.getMaNKMax(), 2);
                String[] maCTNK = new String[dong];
                maCTNK[0] = TaoKhoaChinh.getIdLonNhat(BusinessLogicLayer.CTPhieuNhapKhoBLL.getMaCTNKMax(), 2);
                for (int i = 1; i < dong; i++)
                {
                    maCTNK[i] = TaoKhoaChinh.getIdLonNhat(maCTNK[i - 1], 2);
                }
                BusinessLogicLayer.SanPhamBLL sanphamBLL = new BusinessLogicLayer.SanPhamBLL();
                //lấy khóa của sản phẩm cần thêm vào chi tiết nhập kho
                int[] maSP = new int[dong];
                for (int i = 0; i < dong; i++)
                {
                    maSP[i] = sanphamBLL.getSanPhamTuTenSP(listView_NhapKho.Items[i].SubItems[1].Text).MASP;
                }
                float tongtien = 0;
                //cập nhật giá và số lượng sản phẩm sau khi nhập kho
                BusinessEntities.SanPhamBE sanphamBE;

                for (int i = 0; i < dong; i++)
                {
                    sanphamBE = new BusinessEntities.SanPhamBE();
                    sanphamBE.TENSP = listView_NhapKho.Items[i].SubItems[1].Text;
                    sanphamBE.SOLUONG = int.Parse(listView_NhapKho.Items[i].SubItems[2].Text);
                    sanphamBE.GIABAN = float.Parse(listView_NhapKho.Items[i].SubItems[4].Text);
                    sanphamBE.GIANHAP = float.Parse(listView_NhapKho.Items[i].SubItems[3].Text);
                    tongtien = tongtien + sanphamBE.SOLUONG * sanphamBE.GIANHAP;
                    sanphamBLL.updateNhapkho(sanphamBE);
                }
                //thêm phiếu nhập kho
                BusinessLogicLayer.PhieuNhapKhoBLL phieunhapBLL = new BusinessLogicLayer.PhieuNhapKhoBLL();
                BusinessEntities.PhieuNhapKhoBE phieunhapBE = new BusinessEntities.PhieuNhapKhoBE();
                phieunhapBE.MANK = maNK;
                phieunhapBE.TONGTIEN = tongtien;
                phieunhapBLL.nhapkho(phieunhapBE);
                BusinessEntities.CTNhapKhoBE ctNhapkho;
                BusinessLogicLayer.CTPhieuNhapKhoBLL ctnhapkhoBLL = new BusinessLogicLayer.CTPhieuNhapKhoBLL();
                for (int i = 0; i < dong; i++)
                {
                    ctNhapkho = new BusinessEntities.CTNhapKhoBE();
                    ctNhapkho.MACTNK = maCTNK[i];
                    ctNhapkho.MANK = maNK;
                    ctNhapkho.MASP = maSP[i];
                    ctNhapkho.SOLUONG = int.Parse(listView_NhapKho.Items[i].SubItems[2].Text);
                    ctNhapkho.GIABAN = float.Parse(listView_NhapKho.Items[i].SubItems[4].Text);
                    ctNhapkho.GIAMUA = float.Parse(listView_NhapKho.Items[i].SubItems[3].Text);
                    ctnhapkhoBLL.themCTnhapkho(ctNhapkho);
                }
                MessageBox.Show("Đã lưu thành công.");
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Có lỗi! Chưa lưu thành công.");
            }
        }
    }
}
