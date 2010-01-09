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
using DataAccessLayer;


namespace qlchvlxd
{
    public partial class TimKiemSanPhamPL : Form
    {

        public TimKiemSanPhamPL()
        {
            InitializeComponent();
            // hienthi();
        }

        public BusinessLogicLayer.SanPhamBLL sanphamBLL = new SanPhamBLL();


        public void hienthi()
        {
            //  BusinessLogicLayer.SanPhamBLL sanphamBLL = new BusinessLogicLayer.SanPhamBLL();
            List<SanPhamBE> listSanPham = new List<SanPhamBE>();
            listSanPham = sanphamBLL.getDanhSachSanPham();
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
                    item.SubItems.Add(sp.MANCC);
                    item.SubItems.Add(sp.SOLUONG.ToString());
                    item.SubItems.Add(sp.GIABAN.ToString());
                    listView1.Items.Add(item);
                }
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timkiemsanpham_Load(object sender, EventArgs e)
        {
            hienthi();

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // SanPhamPL frmForm2 = new SanPhamPL();
            // frmForm2.Show();
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa lập nội dung tìm kiếm !");

            }
            else
            {
                // tim kiem theo ten san pham 
                if (radioButton1.Checked)
                {
                    List<SanPhamBE> listSanPham = sanphamBLL.getListTenSanPham(textBox1.Text);
                    int stt = 1;
                    listView1.Items.Clear();
                    foreach (SanPhamBE sp in listSanPham)
                    {
                        sp.MASP.ToString();
                        ListViewItem item = new ListViewItem(stt.ToString());
                        stt++;
                        item.SubItems.Add(sp.TENSP);
                        item.SubItems.Add(sp.MASP.ToString());
                        item.SubItems.Add(sp.MANCC);
                        item.SubItems.Add(sp.SOLUONG.ToString());
                        item.SubItems.Add(sp.GIABAN.ToString());
                        listView1.Items.Add(item);
                    }



                }
                else
                {
                    // tim kiem theo ma san pham
                    
                    
                        if (radioButton2.Checked)
                        {
                            

                            List<SanPhamBE> listSanPham = sanphamBLL.getListMaSanPham(int.Parse(textBox1.Text));
                            int stt = 1;
                            listView1.Items.Clear();
                            foreach (SanPhamBE sp in listSanPham)
                            {
                                sp.MASP.ToString();
                                ListViewItem item = new ListViewItem(stt.ToString());
                                stt++;
                                item.SubItems.Add(sp.TENSP);
                                item.SubItems.Add(sp.MASP.ToString());
                                item.SubItems.Add(sp.MANCC);
                                item.SubItems.Add(sp.SOLUONG.ToString());
                                item.SubItems.Add(sp.GIABAN.ToString());
                                listView1.Items.Add(item);

                            }
                        }
                        else
                            if (radioButton3.Checked)
                            {


                                // tim kiem theo mancc
                                MessageBox.Show("Phan cua Linh chua dua vao ");
                            }
                    }

                
            }



        }
        // Kiểm tra  text box vào có phải là số không
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          

            if (!Char.IsDigit(e.KeyChar) &&radioButton2.Checked)
            MessageBox.Show("Mã sản phẩm là số ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }

    
}
