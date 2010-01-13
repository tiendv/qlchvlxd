using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessEntities;
using BusinessLogicLayer;

namespace qlchvlxd
{
    public partial class DangNhap : Form
    {
        public DangNhapBE currentDangNhap = new DangNhapBE();
        public DangNhapBLL dangNhapBLL = new DangNhapBLL();

        public ManHinhChinhPL mainForm;

        public DangNhap()
        {
            InitializeComponent();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhapBE tk = new DangNhapBE();
            try
            {
                if (textBox1.Text == "admin")
                {
                    tk.MaNhanVien = 1;
                }
                else { tk.MaNhanVien = int.Parse(textBox1.Text); }  
              
                tk.MatKhau = textBox2.Text;
                //MessageBox.Show(tk.MatKhau);
                currentDangNhap = dangNhapBLL.dangNhap(tk);
                if (currentDangNhap.MaNhanVien == 0)
                {
                    MessageBox.Show("Lỗi đăng nhập.");
                }
                else {
                    MessageBox.Show("Dang Nhap thanh cong chao Nhan Vien : " + currentDangNhap.MaNhanVien.ToString());
                    this.Visible = false;
                    ManHinhChinhPL mainForm1 = new ManHinhChinhPL();
                    this.mainForm = mainForm1;
                    this.mainForm.Show();                    
                }
            }
            catch (Exception ex){
                MessageBox.Show("Đăng nhập không đúng.");
            }
            
           
        }
        public ManHinhChinhPL MainForm
        {
            set { this.mainForm = value; }
            get { return this.mainForm; }
        }
    }
}
