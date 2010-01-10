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

        //lay danh sach ten cac loai nhà cung  cấp  tính từ nhà cung cấp
        List<BusinessEntities.NhaCungCapBE> listTenNhaCungCap = new List<BusinessEntities.NhaCungCapBE>();

        /// <summary>
        ///  Lấy mã nhà cung cấp để thêm sản phẩm
        /// </summary>

        public BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new NhaCungCapBLL();
        

        /// <summary>
        ///  Lấy mã đơn vị tính để  thêm sản phẩm
        /// </summary>

        public BusinessLogicLayer.LoaiDonViTinhBLL loaidonvitnhBLL = new LoaiDonViTinhBLL();


        /// <summary>
        ///  Lấy mã loại sản phẩm để  thêm sản phẩm
        /// </summary>

        public BusinessLogicLayer.LoaiSPBLL loaisanphamBLL = new LoaiSPBLL();


        
        public ThemSanPhamPL()
        {
            InitializeComponent();
            listTenLoaiDonViTinh = BusinessLogicLayer.LoaiDonViTinhBLL.getListTenLoaiDonViTinh();
            listTenLoaiSanPham = BusinessLogicLayer.LoaiSPBLL.getListTenLoaiSanPham();
            listTenNhaCungCap = BusinessLogicLayer.NhaCungCapBLL.getListTenNhaCungCap();
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
            // Lấy danh sách tên nhà cung cấp cho combobox
            if (listTenNhaCungCap == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listTenNhaCungCap.Count; i++)
                {
                    
                    comboBox2.Items.Add(listTenNhaCungCap[i].tenncc);
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

        private void button2_Click(object sender, EventArgs e)
        {

            // Kiem tra hop le cua du lieu nhap 
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Tên sản phẩm không được bỏ trống!");
                textBox4.Focus();
            }
            else
            {
                if (textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
                {
                    MessageBox.Show("Giá Tiền không được bỏ trống");
                    textBox5.Focus();
                }
                else
                {
                    if (Int32.Parse(textBox5.Text.ToString()) > Int32.Parse(textBox6.Text.ToString()))
                    {
                        MessageBox.Show("Giá bán phải lớn hơn hoặc bằng giá nhập!");
                        textBox6.Focus();

                    }
                    else
                    {
                        if (textBox8.Text.Length == 0)
                        {
                            MessageBox.Show("Số lượng tối thiểu  không được bỏ trống");
                            textBox5.Focus();

                        }
                        else
                        {
                            if (comboBox1.SelectedItem == null)
                            {
                                MessageBox.Show("Bạn chưa chọn đơn vị tính của sản phẩm !");
                            }
                            else
                            {
                               // Lấy mã nhà cung cấp 
                                NhaCungCapBE cc = new NhaCungCapBE();
                                cc = nhacungcapBLL.getMaNhaCungCap(comboBox2.SelectedItem.ToString());
                               
                                
                                ////// Lấy mã Loại đơn vị tính
                               
                               LoaiDonViTinhBE dvt = new LoaiDonViTinhBE();
                               dvt = loaidonvitnhBLL.getMadonvitinhtuten(comboBox1.SelectedItem.ToString());

                                LoaiSPBE lsp = new LoaiSPBE();
                               lsp = loaisanphamBLL.getMaloaisanphamtuten(comboBox3.SelectedItem.ToString());


                          
                           //   thêm một sản phẩm
                               SanPhamBE sp = new SanPhamBE();
                               sp.MASP = int.Parse(textBox9.Text.ToString());
                               sp.TENSP = textBox4.Text.ToString();
                               sp.GIANHAP = float.Parse(textBox5.Text.ToString());
                               sp.GIABAN = float.Parse(textBox6.Text.ToString());
                               sp.SOLUONG = int.Parse(textBox1.Text.ToString());
                               sp.SOLUONGTOITHIEU = int.Parse(textBox8.Text.ToString());
                               sp.MANCC = cc.MANCC;
                               sp.THONGTIN = textBox7.Text.ToString();
                               sp.DONVITINH = dvt.MALOAIDONVITINH;
                               sp.MALOAISP = lsp.MALOAISP;

                               //MessageBox.Show(textBox9.Text.ToString());
                               sanphamBLL.themsanpham(sp);
                               hienthi();
                             

                            }
                        }
                       
 
                    }


                }
                
            }
        }

       

      

       
    }
}
