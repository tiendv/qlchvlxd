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
    public partial class NhapKhoPL : Form
    {
        public NhapKhoPL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSanPhamPL frmForm2 = new ThemSanPhamPL();
            frmForm2.Show();
        }
    }
}
