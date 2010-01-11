using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLogicLayer;

namespace qlchvlxd
{
    public partial class SanPhamPL : Form
    {
        public SanPhamBE sanpham;
        public SanPhamBLL sanphamBLL;
       

        public SanPhamPL()
        {
            sanpham = new BusinessEntities.SanPhamBE();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SanPhamPL_Load(object sender, EventArgs e)
        {
            textBox2.Text = sanpham.TENSP;
            textBox6.Text = sanpham.SOLUONG.ToString();
            textBox3.Text = sanpham.GIANHAP.ToString();
            textBox4.Text = sanpham.GIABAN.ToString();
            textBox5.Text = sanpham.SOLUONG.ToString();
            textBox1.Text = sanpham.THONGTIN;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SanPhamBE sanphamtest = new SanPhamBE();
            //sanphamtest = sanphamBLL.getSanPhamTuTenSP(textBox2.Text.ToString());
            //MessageBox.Show(sanphamtest.TENSP);
            sanphamBLL.suadthongtinsanphamtheotensanpham(sanpham);
            MessageBox.Show("Đơn Vị Tính Đã Được cập nhật !");
                   

        }
    }
}
