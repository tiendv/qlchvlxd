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
    public partial class QuanlyNV : Form
    {
        private BusinessLogicLayer.NhanVienBLL nhanvienBLL = new NhanVienBLL();
        public int maNV;
        public QuanlyNV()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            List<NhanVienBE> listNhanVien = new List<NhanVienBE>();
            listNhanVien = nhanvienBLL.viewAllEmployee();

            int stt = 1;
            listView1.Items.Clear();
            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.MaNV);
                item.SubItems.Add(nv.HoTenNV);
                item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(nv.LoaiNV);

                listView1.Items.Add(item);
            }

            maNV = Int32.Parse(listView1.Items[stt - 2].SubItems[1].Text);
            textBox2.Text = (maNV + 1).ToString();

            


        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<NhanVienBE> listNhanVien = nhanvienBLL.viewAllEmployeeByNameEmployee(this.textBox1.Text.ToUpper());

            int stt = 1;

            listView1.Items.Clear();

            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.MaNV);
                item.SubItems.Add(nv.HoTenNV);
                item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(nv.LoaiNV);

                listView1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void QuanlyNV_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            List<NhanVienBE> listNhanVien = nhanvienBLL.viewAllEmployeeByKindOfEmployee(this.comboBox1.SelectedItem.ToString());

            int stt = 1;

            listView1.Items.Clear();

            foreach (NhanVienBE nv in listNhanVien)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                stt++;
                item.SubItems.Add(nv.MaNV);
                item.SubItems.Add(nv.HoTenNV);
                item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.NgayDiLam);
                item.SubItems.Add(nv.QueQuan);
                item.SubItems.Add(nv.LoaiNV);

                listView1.Items.Add(item);

            }
            if (comboBox1.Text.Equals("TẤT CẢ"))
            {
                hienthi();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[6].Text;
            maskedTextBox2.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox11.Text = listView1.SelectedItems[0].SubItems[8].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "0" + (maNV + 1).ToString();
            MessageBox.Show("HÃY ĐIỀN ĐẦY ĐỦ NHỮNG THÔNG TIN. SAU ĐÓ NHẤN XONG");
            textBox3.Text = "ĐIỀN THÔNG TIN";
            textBox4.Text = "ĐIỀN THÔNG TIN";
            comboBox2.Text = "ĐIỀN THÔNG TIN";
            maskedTextBox1.Text = "ĐIỀN THÔNG TIN";
            textBox8.Text = "ĐIỀN THÔNG TIN";
            maskedTextBox2.Text = "ĐIỀN THÔNG TIN";
            textBox11.Text = "ĐIỀN THÔNG TIN";
            comboBox3.Text = "ĐIỀN THÔNG TIN";

            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button1.Enabled = false;
            this.button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("ĐIỀN THÔNG TIN") ||
                textBox4.Text.Equals("ĐIỀN THÔNG TIN") ||
                maskedTextBox1.Text.Equals("ĐIỀN THÔNG TIN") ||
                textBox8.Text.Equals("ĐIỀN THÔNG TIN") ||
                maskedTextBox2.Text.Equals("ĐIỀN THÔNG TIN") ||
                textBox11.Text.Equals("ĐIỀN THÔNG TIN") ||
                comboBox2.Text.Equals("ĐIỀN THÔNG TIN") ||
                comboBox3.Text.Equals("ĐIỀN THÔNG TIN"))
            {
                MessageBox.Show("HÃY ĐIỀN ĐẦY ĐỦ NHỮNG THÔNG TIN. SAU ĐÓ NHẤN XONG");
            }
            else
            {
                NhanVienBE nhanvien = new NhanVienBE();

                nhanvien.MaNV = textBox2.Text.ToUpper();
                nhanvien.HoTenNV = textBox3.Text.ToUpper();
                nhanvien.MatKhau = textBox4.Text.ToUpper();
                nhanvien.GioiTinh = comboBox2.Text.ToUpper();
                nhanvien.NgaySinh = maskedTextBox1.Text.ToUpper();
                nhanvien.SDT = textBox8.Text.ToUpper();
                nhanvien.NgayDiLam = maskedTextBox2.Text.ToUpper();
                nhanvien.QueQuan = textBox11.Text.ToUpper();
                nhanvien.LoaiNV = comboBox3.Text.ToUpper();

                nhanvienBLL.insertAEmployee(nhanvien);

                hienthi();

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                textBox8.Clear();
                maskedTextBox2.Clear();
                textBox11.Clear();

                this.button6.Enabled = false;
                this.button4.Enabled = true;
                this.button5.Enabled = true;
                this.button6.Enabled = true;
                this.button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA NHÂN VIÊN " + textBox2.Text + " HAY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                nhanvienBLL.deleteAEmployee(textBox2.Text);
                MessageBox.Show("NHÂN VIÊN ĐÃ ĐƯỢC XÓA");
                hienthi();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                textBox8.Clear();
                maskedTextBox2.Clear();
                textBox11.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Int32.Parse(textBox8.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("HÃY NHẬP ĐÚNG SỐ ĐIỆN THOẠI");
                textBox8.Focus();
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            string[] date = maskedTextBox1.Text.Split('/');

            try
            {
                if (12 < Int16.Parse(date[0].ToString()) || 31 < Int16.Parse(date[1].ToString()))
                {
                    MessageBox.Show("HÃY NHẬP VÀO THANG/NGAY/NĂM");
                    this.maskedTextBox1.Focus();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("HÃY NHẬP VÀO THANG/NGAY/NĂM");
                this.maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            string[] date = maskedTextBox2.Text.Split('/');
            try
            {
                if (12 < Int16.Parse(date[0].ToString()) || 31 < Int16.Parse(date[1].ToString()))
                {
                    MessageBox.Show("HÃY NHẬP VÀO THANG/NGAY/NĂM");
                    this.maskedTextBox2.Focus();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("HÃY NHẬP VÀO THANG/NGAY/NĂM");
                this.maskedTextBox2.Focus();
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Length < 6)
            {
                this.textBox4.Focus();
                MessageBox.Show("MẬT KHẨU PHẢI CÓ ÍT NHẤT 6 KÝ TỰ.", "THÔNG BÁO");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhanVienBE nhanvien = new NhanVienBE();

            nhanvien.MaNV = textBox2.Text.ToUpper();
            nhanvien.HoTenNV = textBox3.Text.ToUpper();
            nhanvien.MatKhau = textBox4.Text.ToUpper();
            nhanvien.GioiTinh = comboBox2.Text.ToUpper();
            nhanvien.NgaySinh = maskedTextBox1.Text.ToUpper();
            nhanvien.SDT = textBox8.Text.ToUpper();
            nhanvien.NgayDiLam = maskedTextBox2.Text.ToUpper();
            nhanvien.QueQuan = textBox11.Text.ToUpper();
            nhanvien.LoaiNV = comboBox3.Text.ToUpper();

            nhanvienBLL.updateEmployee(nhanvien);
            hienthi();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            textBox8.Clear();
            maskedTextBox2.Clear();
            textBox11.Clear();
        }
    }
}
