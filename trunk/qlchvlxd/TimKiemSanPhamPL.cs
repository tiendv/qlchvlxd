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
    public partial class TimKiemSanPhamPL : Form
    {
        public TimKiemSanPhamPL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timkiemsanpham_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            SanPhamPL frmForm2 = new SanPhamPL();
            frmForm2.Show();
        }
    }
}
