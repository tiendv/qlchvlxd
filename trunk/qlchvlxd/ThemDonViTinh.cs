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
    public partial class ThemDonViTinh : Form
    {
        // thêm một đơn vị tính vào databse 

        private BusinessLogicLayer.LoaiDonViTinhBLL loaidonvitinhBLL = new BusinessLogicLayer.LoaiDonViTinhBLL();
  
        // lấy danh sách đơn vị tính trong bảng 
        List<BusinessEntities.LoaiDonViTinhBE> listLoaiDonViTinh = new List<BusinessEntities.LoaiDonViTinhBE>();
        public BusinessLogicLayer.LoaiDonViTinhBLL loaidonvitinh = new BusinessLogicLayer.LoaiDonViTinhBLL();
      
        public int madvt;
        
        public ThemDonViTinh()
        {
            InitializeComponent();
        }

        public void hienthi()
        {
            //  BusinessLogicLayer.SanPhamBLL sanphamBLL = new BusinessLogicLayer.SanPhamBLL();

            listLoaiDonViTinh = BusinessLogicLayer.LoaiDonViTinhBLL.getDanhSachLoaiDonViTinh();
            if (listLoaiDonViTinh == null)
                MessageBox.Show("Chi tiết sản phẩm rỗng ");
            else
            {
              
                int stt = 1;
                listView1.Items.Clear();
                foreach ( LoaiDonViTinhBE dv in listLoaiDonViTinh)
                {
                    dv.MALOAIDONVITINH.ToString();
                    ListViewItem item = new ListViewItem(stt.ToString());
                    stt++;
                    item.SubItems.Add(dv.MALOAIDONVITINH.ToString());
                    item.SubItems.Add(dv.TENDONVITINH.ToString());
                    listView1.Items.Add(item);
                   
                }
                madvt = Int32.Parse(listView1.Items[stt - 2].SubItems[1].Text);
                textBox1.Text = (madvt + 1).ToString();

            }

        }

        private void ThemDonViTinh_Load(object sender, EventArgs e)
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
                MessageBox.Show("Tên đơn vị tính không được bỏ trống");
            else
            {
                LoaiDonViTinhBE ldvt = new LoaiDonViTinhBE();
                ldvt.MALOAIDONVITINH = int.Parse(textBox1.Text);
                ldvt.TENDONVITINH = textBox2.Text.ToUpper();
                loaidonvitinhBLL.themdonvitinh(ldvt);
                hienthi();
                textBox2.Clear();
            
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }


        // Xóa một đơn vị tính 
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị tính " + textBox2.Text + " hay không ?", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                LoaiDonViTinhBE ldvt = new LoaiDonViTinhBE();
                ldvt.MALOAIDONVITINH = int.Parse(textBox1.Text);
                try
                {
                    loaidonvitinhBLL.xoadonvitinhtheoten(ldvt);
                    MessageBox.Show("Đơn Vị Tính Đã Được Xóa");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi Không xóa được do đơn vị tính này đang được sử dụng!");
                }       
                hienthi();
                textBox1.Clear();
                textBox2.Clear();
   
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoaiDonViTinhBE ldvt = new LoaiDonViTinhBE();
            ldvt.MALOAIDONVITINH = int.Parse(textBox1.Text);
            ldvt.TENDONVITINH = textBox2.Text.ToString();
           // MessageBox.Show(ldvt.MALOAIDONVITINH.ToString());
            loaidonvitinhBLL.suadonvitinh(ldvt);
            MessageBox.Show("Đơn Vị Tính Đã Được cập nhật !");
            hienthi();
            textBox1.Clear();
            textBox2.Clear();

        }

       

      

       
    }
}
