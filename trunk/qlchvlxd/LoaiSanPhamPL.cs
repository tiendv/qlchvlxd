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
    public partial class LoaiSanPhamPL : Form
    {
        int malsp;// khai báo biến mã loại sản phẩm


        // Lấy danh sách loại sản phảm
        List<BusinessEntities.LoaiSPBE> listLoaiSP = new List<BusinessEntities.LoaiSPBE>();
        public BusinessLogicLayer.LoaiSPBLL loaispBLL = new BusinessLogicLayer.LoaiSPBLL();

        public LoaiSanPhamPL()
        {
            InitializeComponent();
        }
        public void hienthi()
        {

            listLoaiSP = BusinessLogicLayer.LoaiSPBLL.getDanhSachLoaiSP();
            if (listLoaiSP == null)
                MessageBox.Show("Chi tiết sản phẩm rỗng ");
            else
            {

                int stt = 1;
                listView1.Items.Clear();
                foreach (LoaiSPBE lsp in listLoaiSP)
                {
                    lsp.MALOAISP.ToString();
                    ListViewItem item = new ListViewItem(stt.ToString());
                    stt++;
                    item.SubItems.Add(lsp.MALOAISP.ToString());
                    item.SubItems.Add(lsp.TENLOAISP.ToString());
                    listView1.Items.Add(item);

                }
                malsp = Int32.Parse(listView1.Items[stt - 2].SubItems[1].Text);
                textBox1.Text = (malsp + 1).ToString();

            }

        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                MessageBox.Show("Tên của loại sản phẩm Không được rỗng !");
            else
            {
                LoaiSPBE lsp = new LoaiSPBE();
                lsp.MALOAISP = int.Parse(textBox1.Text);
                lsp.TENLOAISP = textBox2.Text.ToUpper();
               // loaidonvitinhBLL.themdonvitinh(ldvt);
                loaispBLL.themdloaisanpham(lsp);
                hienthi();
                textBox2.Clear();
                
            }
        }

        // Hien thi chi tiet ve Loai San Pham Khi bam vao list views .
        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm " + textBox2.Text + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    LoaiSPBE lsp = new LoaiSPBE();
                    lsp.MALOAISP = int.Parse(textBox1.Text);
                    loaispBLL.xoaloaisptheomaloai(lsp);
                    MessageBox.Show("Loại Sản Phẩm Được Xóa");

                }
                catch(Exception exp)
                {
                    MessageBox.Show("Loại sản phẩm đang được sử dụng không thể xóa !");
 
                }
                hienthi();
               // textBox1.Clear();
                textBox2.Clear();

            }
        }
        
    }

}
