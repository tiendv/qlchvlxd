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
    public partial class BangLuongNVPL : Form
    {
        private BangLuongNhanVienBLL blnvBO;

        public BangLuongNVPL()
        {
            InitializeComponent();
            blnvBO = new BangLuongNhanVienBLL();
        }
        public void hienthi()
        {
            List<BangLuongNhanVienBE> list = new List<BangLuongNhanVienBE>();

            list = blnvBO.viewAllTableSalary();

            int stt = 1;

            this.listView1.Items.Clear();

            foreach (BangLuongNhanVienBE blnv in list)
            {
                ListViewItem item1 = new ListViewItem(stt.ToString());
                item1.SubItems.Add(blnv.HotenNV);
                item1.ForeColor = Color.Red;
                
                ListViewItem item2 = new ListViewItem(" ");
                item2.SubItems.Add(" ");
                item2.SubItems.Add("HỌ TÊN NHÂN VIÊN : ");
                item2.SubItems.Add(blnv.HotenNV);

                ListViewItem item3 = new ListViewItem(" ");
                item3.SubItems.Add(" ");
                item3.SubItems.Add("MÃ BẢNG LƯƠNG NHÂN VIÊN : ");
                item3.SubItems.Add(blnv.MaBL);

                ListViewItem item4 = new ListViewItem(" ");
                item4.SubItems.Add(" ");
                item4.SubItems.Add("SỐ NGÀY ĐI LÀM : ");
                item4.SubItems.Add(blnv.NgayDiLam.ToString());

                ListViewItem item5 = new ListViewItem(" ");
                item5.SubItems.Add(" ");
                item5.SubItems.Add("TIỀN THƯỞNG TRONG THÁNG :");
                item5.SubItems.Add(blnv.TienThuong.ToString());

                ListViewItem item6 = new ListViewItem(" ");
                item6.SubItems.Add(" ");
                item6.SubItems.Add("LƯƠNG CƠ BẢN :");
                item6.SubItems.Add(blnv.LuongCB.ToString());

                ListViewItem item7 = new ListViewItem(" ");
                item7.SubItems.Add(" ");
                item7.SubItems.Add("TẠM ỨNG : ");
                item7.SubItems.Add(blnv.TamUng.ToString());

                ListViewItem item8 = new ListViewItem(" ");
                item8.SubItems.Add(" ");
                item8.SubItems.Add("TỔNG LƯƠNG :");
                item8.SubItems.Add(blnv.TongLuong.ToString());

                listView1.Items.Add(item1);
                listView1.Items.Add(item2);
                listView1.Items.Add(item3);
                listView1.Items.Add(item4);
                listView1.Items.Add(item5);
                listView1.Items.Add(item6);
                listView1.Items.Add(item7);
                listView1.Items.Add(item8);
                stt++;
            }
        }
        private void BangLuongNVPL_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
