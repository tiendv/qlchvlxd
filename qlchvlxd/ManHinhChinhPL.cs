using System;
using System.Windows.Forms;

namespace qlchvlxd
{
    public partial class ManHinhChinhPL : Form
    {
        public ManHinhChinhPL()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }


        private void doanhThuNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDoanhThuNgayPL f2 = new XemDoanhThuNgayPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void baocaoKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoKhoPL f2 = new BaoCaoKhoPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void baocaoKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoKhachHangPL f2 = new BaoCaoKhachHangPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void baocaodinhkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDinhKi f2 = new BaoCaoDinhKi();
            f2.MdiParent = this;
            f2.Show();
        }

        private void themSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSanPhamPL frmForm2 = new ThemSanPhamPL();
            frmForm2.MdiParent = this;
            frmForm2.Show(); 
        }

        private void timkiemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiemSanPhamPL frmForm2 = new TimKiemSanPhamPL();
            frmForm2.MdiParent = this;
            frmForm2.Show();
        }

        private void themNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhaCungCapPL frmForm2 = new ThemNhaCungCapPL();
            frmForm2.MdiParent = this;
            frmForm2.Show();
        }

        private void timkiemToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TimKhachHangPL f2 = new TimKhachHangPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void timkiemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemNCCPL f2 = new TimKiemNCCPL();
            f2.MdiParent = this;
            f2.Show();

        }

        private void themKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKhachHangPL f2 = new ThemKhachHangPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void laphoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapHoaDonPL frmForm2 = new LapHoaDonPL();
            frmForm2.MdiParent = this;
            frmForm2.Show();
        }

        private void nhapkhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhapKhoPL f2 = new NhapKhoPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void capnhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void giaohangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoHangPL f2 = new GiaoHangPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void tragopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraGopPL f2 = new TraGopPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tinhluongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongNVPL f2 = new BangLuongNVPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void chamcongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCongNVPL f2 = new ChamCongNVPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyNV form2 = new QuanlyNV();
            form2.MdiParent = this;
            form2.Show();
        }

        private void tamungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TamUngPL f2 = new TamUngPL();
            f2.MdiParent = this;
            f2.Show();
        }
 
        private void bangChietKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangGiaChietKhauPL f2 = new BangGiaChietKhauPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void bangGiaGiaoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangGiaGHPL f2 = new BangGiaGHPL();
            f2.MdiParent = this;
            f2.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGiaPL f = new TacGiaPL();
            f.Show();
        }

        private void lienheToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void inBảngGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanggiasanphamPL f = new BanggiasanphamPL();
            f.MdiParent = this;
            f.Show();
        }
    }
}
