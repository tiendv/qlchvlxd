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

/**-----------------------------------------------------------
* Program : QLCHVLXD
* Written by : tiendv
* Email : tiendv.vn@gmail.com
•	Created date: 07/01/2010 
* Modified by:
•	Modified date:
•	Version: 1.0	
•	Description: 
----------------------------------------------------------*/

namespace qlchvlxd
{
    public partial class ThemSanPhamPL : Form
    {
        int msp; // Khai báo biến mã sản phẩm 
        // Lấy danh sách sản phẩm 

        List<BusinessEntities.SanPhamBE> listSanPham = new List<BusinessEntities.SanPhamBE>();
        public BusinessLogicLayer.SanPhamBLL sanphamBLL = new SanPhamBLL();
        //lay danh sach ten cac loai sản phẩm  từ bang loai sản phẩm

        List<BusinessEntities.LoaiSPBE> listTenLoaiSanPham = new List<BusinessEntities.LoaiSPBE>();


        //lay danh sach ten cac loai đơn vị tính từ bang loai đơn vị tính
        List<BusinessEntities.LoaiDonViTinhBE> listTenLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
       
        
        public ThemSanPhamPL()
        {
            InitializeComponent();
            listTenLoaiDonViTinh = BusinessLogicLayer.LoaiDonViTinhBLL.getListTenLoaiDonViTinh();
            listTenLoaiSanPham = BusinessLogicLayer.LoaiSPBLL.getListTenLoaiSanPham();


        }

        // ham hien thi danh sach san pham trong listview 
        public void hienthi()
        {


            listSanPham = BusinessLogicLayer.SanPhamBLL.getDanhSachSanPham();
            if (listSanPham == null)
                MessageBox.Show("Chi tiết sản phẩm rỗng ");
            else
            {
                int stt = 1;
                listView1.Items.Clear();
                foreach (SanPhamBE sp in listSanPham)
                {
                    sp.MASP.ToString();
                    ListViewItem item = new ListViewItem(stt.ToString());
                    stt++;
                    item.SubItems.Add(sp.TENSP);
                    item.SubItems.Add(sp.MASP.ToString());
                    item.SubItems.Add(sp.GIANHAP.ToString());
                    item.SubItems.Add(sp.GIABAN.ToString());
                    item.SubItems.Add(sp.MANCC);
                    item.SubItems.Add(sp.SOLUONG.ToString());
                    item.SubItems.Add(sp.SOLUONGTOITHIEU.ToString());
                    item.SubItems.Add(sp.MALOAISP.ToString());
                    item.SubItems.Add(sp.DONVITINH.ToString());
                    item.SubItems.Add(sp.THONGTIN.ToString());
                    listView1.Items.Add(item);

                }
              msp = Int32.Parse(listView1.Items[stt - 2].SubItems[2].Text);
                textBox9.Text = (msp + 1).ToString();
            }
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

            // Lay danh sach ten loai don vi tinh cho comboboxx
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
            // Lấy danh sách tên loại sản phẩm cho combobox

            if (listTenLoaiSanPham == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listTenLoaiSanPham.Count; i++)
                {
                    //MessageBox.Show("hien");
                    comboBox3.Items.Add(listTenLoaiSanPham[i].tenloaisp);
                }
            }

            // hien thi danh sach san pham trong list vier

            hienthi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDonViTinh fm = new ThemDonViTinh();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemNhaCungCapPL F = new ThemNhaCungCapPL();
            F.Show();

        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoaiSanPhamPL f = new LoaiSanPhamPL();
               f.Show();

        }

       

      

       
    }
}
