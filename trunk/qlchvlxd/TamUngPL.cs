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
    public partial class TamUngPL : Form
    {
        private NhanVienUngLuongBLL myNhanVienUngLuongBLL;
       
        private List<ThongSoTinhLuongBE> listLoaiNhanVien;

        public TamUngPL()
        {
            InitializeComponent();

            listLoaiNhanVien = new List<ThongSoTinhLuongBE>();
            ThongSoTinhLuongBLL thsnv = new ThongSoTinhLuongBLL();
            listLoaiNhanVien = thsnv.viewAll();

            myNhanVienUngLuongBLL = new NhanVienUngLuongBLL();

            textBox6.Text = new DateTime().Month.ToString();
        }

        public void hienthi()
        {
            List<NhanVienUngLuongBE> list = new List<NhanVienUngLuongBE>();

            list = myNhanVienUngLuongBLL.fetchAll(new DateTime().Month);
            int stt = 1;
            listView1.Items.Clear();
            foreach (NhanVienUngLuongBE nvul in list)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nvul.HoTen);
                item.SubItems.Add(nvul.NgaySinh);
                item.SubItems.Add(nvul.GioiTinh);
                item.SubItems.Add(nvul.SoNgayDiLam.ToString());
                item.SubItems.Add(nvul.LuongCoBan.ToString());
                item.SubItems.Add(nvul.TamUng.ToString());
                item.SubItems.Add(nvul.TongLuong.ToString());
                item.SubItems.Add(listLoaiNhanVien[nvul.LoaiNhanVien - 1].TenLoaiNhanVien);
                item.SubItems.Add(nvul.MaNhanVien.ToString());
                item.SubItems.Add(nvul.MaBangLuong.ToString());
                listView1.Items.Add(item);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TamUngPL_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            item1.SubItems.Add("Họ tên :");
            item1.SubItems.Add(listView1.SelectedItems[0].SubItems[1].Text);

            ListViewItem item2 = new ListViewItem();
            item2.SubItems.Add("Ngày sinh :");
            item2.SubItems.Add(listView1.SelectedItems[0].SubItems[2].Text);

            ListViewItem item3 = new ListViewItem();
            item3.SubItems.Add("Giới tính :");
            item3.SubItems.Add(listView1.SelectedItems[0].SubItems[3].Text);

            ListViewItem item4 = new ListViewItem();
            item4.SubItems.Add("Số ngày đi làm :");
            item4.SubItems.Add(listView1.SelectedItems[0].SubItems[4].Text);

            ListViewItem item5 = new ListViewItem();
            item5.SubItems.Add("Lương cơ bản :");
            item5.SubItems.Add(listView1.SelectedItems[0].SubItems[5].Text);

            ListViewItem item6 = new ListViewItem();
            item6.SubItems.Add("Tạm ứng :");
            item6.SubItems.Add(listView1.SelectedItems[0].SubItems[6].Text);

            ListViewItem item7 = new ListViewItem();
            item7.SubItems.Add("Tổng lương :");
            item7.SubItems.Add(listView1.SelectedItems[0].SubItems[7].Text);

            ListViewItem item8 = new ListViewItem();
            item8.SubItems.Add("Ma nhan vien:");
            item8.SubItems.Add(listView1.SelectedItems[0].SubItems[9].Text);
            
            ListViewItem item9 = new ListViewItem();
            item9.SubItems.Add("Ma bang luong:");
            item9.SubItems.Add(listView1.SelectedItems[0].SubItems[10].Text);

            listView2.Items.Clear();
            listView2.Items.Add(item1);
            listView2.Items.Add(item2);
            listView2.Items.Add(item3);
            listView2.Items.Add(item4);
            listView2.Items.Add(item5);
            listView2.Items.Add(item6);
            listView2.Items.Add(item7);
            listView2.Items.Add(item8);
            listView2.Items.Add(item9);

            groupBox4.Enabled = true;
            listView2.Enabled = true;

        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienUngLuongBE nvul = new NhanVienUngLuongBE();
            nvul.TamUng = float.Parse(textBox7.Text) + float.Parse(listView2.Items[5].SubItems[2].Text);
            nvul.LuongCoBan = float.Parse(listView2.Items[4].SubItems[2].Text);
            nvul.MaNhanVien = int.Parse(listView2.Items[7].SubItems[2].Text);
            nvul.MaBangLuong = int.Parse(listView2.Items[8].SubItems[2].Text);

            myNhanVienUngLuongBLL.updateTamUng(nvul);

            groupBox4.Enabled = false;
            listView2.Enabled = false;
            hienthi();
            listView2.Items.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
