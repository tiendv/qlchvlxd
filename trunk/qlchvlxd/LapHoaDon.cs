using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace qlchvlxd
{
    public partial class LapHoaDon : Form
    {
        tbCTHDServices mtbCTHD;
        public LapHoaDon()
        {
            InitializeComponent();            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TraGop tragop = new TraGop();
            tragop.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (maKHTT.Enabled == false)
                maKHTT.Enabled = true;
            else
                maKHTT.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maKHTT.Enabled == true && maKHTT.Text == "")
                MessageBox.Show("Nhập mã khách hàng thân thiết");                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {

            listView_HoaDon.MultiSelect = false;

            //show list of items
            List<BusinessEntities.tbCTHD> list = new List<BusinessEntities.tbCTHD>();
            list = BusinessLogicLayer.tbCTHDServices.getDanhSachCTHD();

            ListViewItem lvi;

            for (int i = 0; i < list.Count; i++)
            {
                lvi = new ListViewItem(list[i].maCTHD.ToString());
                lvi.SubItems.Add(list[i].maHD.ToString());
                lvi.SubItems.Add(list[i].maLoaiSP.ToString());
                lvi.SubItems.Add(list[i].maSP.ToString());
                lvi.SubItems.Add(list[i].donGia.ToString());

                listView_HoaDon.Items.Add(lvi);
            }
            //currentListProduct = list;
            //show comboBox Product Type
            List<BusinessEntities.tbCTHD> danhsachCTHD = new List<BusinessEntities.tbCTHD>();
            danhsachCTHD = BusinessLogicLayer.tbCTHDServices.getDanhSachCTHD();
            for (int i = 0; i < danhsachCTHD.Count; i++)
            {
                comboBox_LoaiSP.Items.Add(danhsachCTHD[i].maCTHD);
            }
        }

      
    }
}
