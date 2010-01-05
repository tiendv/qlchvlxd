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
    public partial class timkiemNCC : Form
    {
        public timkiemNCC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuaNCC f2 = new SuaNCC();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }
    }
}
