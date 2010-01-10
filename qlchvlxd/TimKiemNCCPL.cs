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
    public partial class TimKiemNCCPL : Form
    {
        BusinessEntities.NhaCungCapBE nhacungcap;
        public TimKiemNCCPL()
        {
            nhacungcap = new BusinessEntities.NhaCungCapBE();
            InitializeComponent();
        }

        private void getTTNhaCungCap()
        {
            nhacungcap.MANCC = listView_NCC.SelectedItems[0].SubItems[1].ToString();
            nhacungcap.TENNCC = listView_NCC.SelectedItems[0].SubItems[2].ToString();
            nhacungcap.DIACHI = listView_NCC.SelectedItems[0].SubItems[3].ToString();
            nhacungcap.DIENTHOAI = listView_NCC.SelectedItems[0].SubItems[4].ToString();
        }
       
        private void button_SuaNCC_Click(object sender, EventArgs e)
        {
            SuaNCCPL f2 = new SuaNCCPL();
            getTTNhaCungCap();
            f2.maNCC = nhacungcap.MANCC;
            f2.MdiParent = this.MdiParent;
            f2.Show();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa nhà cung cấp này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
            if (rb_TimTen.Checked)
            {
                nhacungcapBLL.getListNCCtheoTen(textBox_Tim.Text);
            }
        }

        
       
    }
}
