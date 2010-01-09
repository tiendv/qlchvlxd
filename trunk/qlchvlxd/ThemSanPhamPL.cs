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
    public partial class ThemSanPhamPL : Form
    {

        //lay danh sach ten cac loai đơn vị tính từ bang loai đơn vị tính
        List<BusinessEntities.LoaiDonViTinhBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
        public ThemSanPhamPL()
        {
            InitializeComponent();
            listTenLoaiDonViTinh = BusinessLogicLayer.LoaiDonViTinhBLL.getListTenLoaiDonViTinh();

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) 
                MessageBox.Show("Tiền có kiểu số ! ");
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Tiền có kiểu số ! ");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Số lượng có  kiểu số ! ");
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Số lượng có  kiểu số ! ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void ThemSanPhamPL_Load(object sender, EventArgs e)
        {
            if (listTenLoaiDonViTinh == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listTenLoaiDonViTinh.Count; i++)
                {
                    //MessageBox.Show("hien");
                    comboBox1.Items.Add(listTenLoaiDonViTinh[i].tendonvitinh);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDonViTinh fm = new ThemDonViTinh();
            fm.Show();
        }

       

      

       
    }
}
