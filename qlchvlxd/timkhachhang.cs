﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlchvlxd
{
    public partial class timkhachhang : Form
    {
        public timkhachhang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suakhachhang f2 = new suakhachhang();
            f2.Show();
        }
    }
}