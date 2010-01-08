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
        public TimKiemNCCPL()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuaNCCPL f2 = new SuaNCCPL();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }
    }
}
