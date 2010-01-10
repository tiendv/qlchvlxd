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
            nhacungcap.MANCC = listView_NCC.SelectedItems[0].SubItems[1].Text;
            nhacungcap.TENNCC = listView_NCC.SelectedItems[0].SubItems[2].Text;
            nhacungcap.DIACHI = listView_NCC.SelectedItems[0].SubItems[3].Text;
            nhacungcap.DIENTHOAI = listView_NCC.SelectedItems[0].SubItems[4].Text;
        }
       
        private void button_SuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                bool chk=listView_NCC.SelectedItems[0].Checked;
  
                SuaNCCPL f2 = new SuaNCCPL();
                getTTNhaCungCap();
                f2.nhacungcapBE = nhacungcap;
                f2.MdiParent = this.MdiParent;
                f2.Show();
           
            }
            catch(Exception exp)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn sửa thông tin.");
            }
            
                
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa nhà cung cấp này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            listView_NCC.Items.Clear();
            
            BusinessLogicLayer.NhaCungCapBLL nhacungcapBLL = new BusinessLogicLayer.NhaCungCapBLL();
            List<BusinessEntities.NhaCungCapBE> listNhaCungCap= nhacungcapBLL.getListNCCtheoTen(textBox_Tim.Text);
            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
   
                            string[] col = new string[5];
                            
                            col[0] = i+1+"";
                            col[1] = listNhaCungCap[i].MANCC;
                            col[2] = listNhaCungCap[i].TENNCC;
                            col[3] = listNhaCungCap[i].DIACHI;
                            col[4] = listNhaCungCap[i].DIENTHOAI;
                            ListViewItem lvItem = new ListViewItem(col);
                            listView_NCC.Items.Add(lvItem);
            }
            textBox_Tim.Text = "";
            }
        }

        
       
    }

