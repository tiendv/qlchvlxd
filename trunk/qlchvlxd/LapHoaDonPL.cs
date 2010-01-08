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
    public partial class LapHoaDonPL : Form
    {
        
        public LapHoaDonPL()
        {
            InitializeComponent();            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TraGopPL tragop = new TraGopPL();
            tragop.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập mã khách hàng thân thiết vào ô kế bên!");
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
            List<BusinessEntities.CTHoaDonBE> list = new List<BusinessEntities.CTHoaDonBE>();
            list = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();

            ListViewItem lvi;
            if(list == null)
                MessageBox.Show("nulll");
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
            List<BusinessEntities.CTHoaDonBE> danhsachCTHD = new List<BusinessEntities.CTHoaDonBE>();
            danhsachCTHD = BusinessLogicLayer.CTHoaDonBLL.getDanhSachCTHD();
            for (int i = 0; i < danhsachCTHD.Count; i++)
            {
                comboBox_LoaiSP.Items.Add(danhsachCTHD[i].maSP);
            }
        }

      
    }
}
