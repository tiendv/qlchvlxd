using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessEntities;

namespace qlchvlxd
{
    public partial class ChamCongNVPL : Form
    {
        private NhanVienBLL myNhanVienBLL = new NhanVienBLL();
        private BangLuongNhanVienBLL myBangLuongNhanVien = new BangLuongNhanVienBLL();
        public int maNV;

        private List<ThongSoTinhLuongBE> listLoaiNhanVien;

        public ChamCongNVPL()
        {
            InitializeComponent();

            listLoaiNhanVien = new List<ThongSoTinhLuongBE>();
            ThongSoTinhLuongBLL thsnv = new ThongSoTinhLuongBLL();
            listLoaiNhanVien = thsnv.viewAll();

            foreach (ThongSoTinhLuongBE loaiNhanVien in listLoaiNhanVien)
            {
                comboBox1.Items.Add(loaiNhanVien.TenLoaiNhanVien.ToUpper());
                //comboBox3.Items.Add(loaiNhanVien.TenLoaiNhanVien.ToUpper());
            }
            comboBox1.Items.Add("TẤT CẢ");
        }

        public void hienthi()
        {
            List<NhanVienBE> listNhanVien = myNhanVienBLL.viewAllEmployee();

            int stt = 1;

            listView1.Items.Clear();

            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.HoTenNV);                
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(listLoaiNhanVien[nv.MaLoaiNV - 1].TenLoaiNhanVien);
                item.SubItems.Add(nv.MaNV.ToString());
                listView1.Items.Add(item);

            }
        }

        private void ChamCongNVPL_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            System.Console.Out.WriteLine("dfdf");
            List<NhanVienBE> listNhanVien = myNhanVienBLL.viewAllEmployeeByKindOfEmployee(this.comboBox1.SelectedIndex + 1);

            int stt = 1;

            listView1.Items.Clear();

            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.HoTenNV);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(listLoaiNhanVien[nv.MaLoaiNV - 1].TenLoaiNhanVien);

                listView1.Items.Add(item);
            }

            if (comboBox1.Text.Equals("TẤT CẢ"))
            {
                hienthi();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[8].Text;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<NhanVienBE> listNhanVien = myNhanVienBLL.viewAllEmployeeByNameEmployee(this.textBox2.Text.ToUpper());

            int stt = 1;

            listView1.Items.Clear();

            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.HoTenNV);
                //item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(nv.MaLoaiNV.ToString());

                listView1.Items.Add(item);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text.Equals("Vắng mặt"))
            {
                BangLuongNhanVienBE blnv = new BangLuongNhanVienBE();
                
                blnv = myBangLuongNhanVien.searchBangLuong(int.Parse(textBox3.Text), int.Parse(new DateTime().Month.ToString() + "2010"));
                myBangLuongNhanVien.updateSoNgayDiLam(blnv);
            }
            //MessageBox.Show(new DateTime().Month.ToString() + "2010");
            button4.Enabled = false;
        }                     
    }
}
