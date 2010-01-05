using System;
using System.Windows.Forms;

namespace qlchvlxd
{
    public partial class manhinhchinh : Form
    {
        public manhinhchinh()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }


        private void doanhThuNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdoanhthungay f2 = new xemdoanhthungay();
            f2.Show();
        }

        private void baocaoKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaokho f2 = new baocaokho();
            f2.Show();
        }

        private void baocaoKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaokhachhang f2 = new baocaokhachhang();
            f2.Show();
        }

        private void baocaodinhkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaodinhki f2 = new baocaodinhki();
            f2.Show();
        }

        private void themSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themsanpham frmForm2 = new themsanpham();
            frmForm2.Show(); 
        }

        private void timkiemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Timkiemsanpham frmForm2 = new Timkiemsanpham();
            frmForm2.Show();
        }

        private void themNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themnhacungcap frmForm2 = new themnhacungcap();
            frmForm2.Show();
        }

        private void timkiemToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timkhachhang f2 = new timkhachhang();
            f2.Show();
        }

        private void timkiemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timkiemNCC f2 = new timkiemNCC();
            f2.Show();

        }

        private void themKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themkhachhang f2 = new themkhachhang();
            f2.Show();
        }

        private void laphoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapHoaDon frmForm2 = new LapHoaDon();
            frmForm2.Show();
        }

        private void nhapkhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nhapkho f2 = new nhapkho();
            f2.Show();
        }

        private void capnhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangGiaGH f2 = new BangGiaGH();
            f2.Show();
        }

        private void giaohangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoHang f2 = new GiaoHang();
            f2.Show();
        }

        private void tragopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraGop f2 = new TraGop();
            f2.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tinhluongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongNV f2 = new BangLuongNV();
            f2.Show();
        }

        private void chamcongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCongNV f2 = new ChamCongNV();
            f2.Show();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyNV f2 = new QuanlyNV();
            f2.Show();
        }

        private void tamungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TamUng f2 = new TamUng();
            f2.Show();
        }
    }
}
