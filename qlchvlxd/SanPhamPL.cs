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
            BusinessLogicLayer.SanPhamBLL sanphamBLL = new BusinessLogicLayer.SanPhamBLL();

            sanpham.TENSP = textBox2.Text;
            sanpham.SOLUONG = int.Parse(textBox6.Text.ToString());
            sanpham.GIANHAP = float.Parse(textBox3.Text.ToString());
            sanpham.GIABAN = float.Parse(textBox4.Text.ToString());
            //sanpham.SOLUONGtextBox5.Text = .ToString();
            sanpham.THONGTIN = textBox1.Text;

            try
            {
              
                sanphamBLL.suadthongtinsanphamtheotensanpham(sanpham);
                MessageBox.Show("Sản Phẩm đã được cập nhật !");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật thông tin sản phẩm !");

            }
            
                   

        }

        private void button2_Click(object sender, EventArgs e)
        {
         



            BusinessLogicLayer.SanPhamBLL sanphamBLL = new BusinessLogicLayer.SanPhamBLL();

            try
            {
               
                sanphamBLL.xoasanpham(sanpham);
                
               // MessageBox.Show(sanpham.THONGTIN);
                MessageBox.Show("Sản Phẩm đã được xóa khỏi dữ liệu !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sản Phẩm đang tồn tại trong dữ liệu khác !");

            }
        }
    }
}
