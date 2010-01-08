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
    public partial class TimKhachHangPL : Form
    {
        public TimKhachHangPL()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuaKhachHangPL f2 = new SuaKhachHangPL();
            f2.Show();
        }
    }
}
