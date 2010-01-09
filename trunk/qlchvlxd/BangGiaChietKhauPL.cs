using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlchvlxd
{
    public partial class BangGiaChietKhauPL : Form
    {
        List<BusinessEntities.ChietKhauBE> listChietKhau = new List<BusinessEntities.ChietKhauBE>();

        private bool addFlag = false;
        private bool editFlag = false;
        private bool editRateflag = false;

        private String tenChietKhauTruoc;

        public BangGiaChietKhauPL()
        {
            InitializeComponent();
            hienThi();
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        public void hienThi()
        {
            listChietKhau = BusinessLogicLayer.ChietKhauBLL.getListChietKhau();

            ListViewItem lvi;
            if (listChietKhau == null)
                MessageBox.Show("Danh sách rỗng!");
            else
            {
                for (int i = 0; i < listChietKhau.Count; i++)
                {
                    lvi = new ListViewItem((i + 1).ToString());
                   
                    lvi.SubItems.Add(listChietKhau[i].tenChietKhau.ToString());
                    lvi.SubItems.Add((listChietKhau[i].tiLeChietKhau/100).ToString());

                    listView_ChietKhau.Items.Add(lvi);
                }
            }
        }

        private void button_Thêm_Click(object sender, EventArgs e)
        {
            //tao 1 doit tuong chiet khau can them
            BusinessEntities.ChietKhauBE themChietKhau = new BusinessEntities.ChietKhauBE();
            listChietKhau = BusinessLogicLayer.ChietKhauBLL.getListChietKhau();
            addFlag = true;
            if(listChietKhau == null)
            {
                addFlag = true;
            }
            else
                for (int i = 0; i < listChietKhau.Count; i++)
                {
                    if (listChietKhau[i].tenChietKhau == textBox_TenChietKhau.Text)
                    {
                        MessageBox.Show("Đã tồn tại tên này trong dữ liệu!");
                        addFlag = false;
                    }
                }
            if (float.Parse(textBox_tiLeChietKhau.Text) < 0 || float.Parse(textBox_tiLeChietKhau.Text) > 100)
            {
                MessageBox.Show("Tỉ lệ chiết khẩu nằm trong khoảng 0 -> 100!");
                addFlag = false;
            }

            if (addFlag == true)
            {
                //lay du lieu tu form dua vao chiet khau nay
                themChietKhau.tenChietKhau = textBox_TenChietKhau.Text;                
                themChietKhau.tiLeChietKhau = float.Parse(textBox_tiLeChietKhau.Text);

                //them vao du lieu
                BusinessLogicLayer.ChietKhauBLL.themChietKhau(themChietKhau);
            }

            //xoa listview và xuat len man hinh
            listView_ChietKhau.Items.Clear();
            hienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {

            //chon 1 doi tuong chiet khau can sua
            BusinessEntities.ChietKhauBE myChietKhau = new BusinessEntities.ChietKhauBE();
            listChietKhau = BusinessLogicLayer.ChietKhauBLL.getListChietKhau();
            editFlag = true;
            editRateflag = false;
            if (textBox_TenChietKhau.Text == "")
            {
                button_Sua.Enabled = false;
                MessageBox.Show("Chọn chiết khấu bạn muốn sửa!");
            }

            if (listChietKhau == null)
            {
                editFlag = true;
            }
            else
                for (int i = 0; i < listChietKhau.Count; i++)
                {
                    if (listChietKhau[i].tenChietKhau == textBox_TenChietKhau.Text 
                        && listChietKhau[i].tiLeChietKhau == float.Parse(textBox_tiLeChietKhau.Text))
                    {
                        MessageBox.Show("Đã tồn tại tên này trong dữ liệu!");
                        editFlag = false;
                    }
                    else if (listChietKhau[i].tenChietKhau == textBox_TenChietKhau.Text
                        && listChietKhau[i].tiLeChietKhau != float.Parse(textBox_tiLeChietKhau.Text))
                    {
                        editRateflag = true;
                    }
                }

            if (float.Parse(textBox_tiLeChietKhau.Text) < 0 || float.Parse(textBox_tiLeChietKhau.Text) > 100)
            {
                MessageBox.Show("Tỉ lệ chiết khẩu nằm trong khoảng 0 -> 100!");
                editFlag = false;
            }


            if (editFlag == true && textBox_TenChietKhau.Text != "" && editRateflag == false)
            {
                myChietKhau.tenChietKhau = textBox_TenChietKhau.Text;
                myChietKhau.tiLeChietKhau = float.Parse(textBox_tiLeChietKhau.Text);

                //xoa chiet khấu
                BusinessLogicLayer.ChietKhauBLL.suaChietKhau(myChietKhau, tenChietKhauTruoc);               
            }

            if (editFlag == true && editRateflag == true)
            {
                myChietKhau.tenChietKhau = textBox_TenChietKhau.Text;
                myChietKhau.tiLeChietKhau = float.Parse(textBox_tiLeChietKhau.Text);

                //xoa chiet khấu
                BusinessLogicLayer.ChietKhauBLL.suaChietKhau(myChietKhau);
            }

            //xoa listview và xuat len man hinh
            listView_ChietKhau.Items.Clear();
            hienThi();
            button_Sua.Enabled = false;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_TenChietKhau.Text == "")
            {
                button_Xoa.Enabled = false;
                MessageBox.Show("Chọn chiết khấu bạn muốn xóa");
            }

            //xoa chiet khấu
            BusinessLogicLayer.ChietKhauBLL.xoaChietKhau(textBox_TenChietKhau.Text);
            // MessageBox.Show(textBox_tiLeChietKhau.Text.Length.ToString() + "_" + textBox_TenChietKhau.Text);

            //xoa listview và xuat len man hinh
            listView_ChietKhau.Items.Clear();
            hienThi();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_ChietKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = true;
            button_Xoa.Enabled = true;
            if (listView_ChietKhau.SelectedItems.Count == 0)
                return;
            textBox_TenChietKhau.Text = listView_ChietKhau.SelectedItems[0].SubItems[1].Text;
            tenChietKhauTruoc = textBox_TenChietKhau.Text;
            textBox_tiLeChietKhau.Text = ((float.Parse(listView_ChietKhau.SelectedItems[0].SubItems[2].Text)) * 100).ToString();
        }
    }
}
