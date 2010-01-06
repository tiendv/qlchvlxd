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
    public partial class LapHoaDon : Form
    {
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

      
    }
}
