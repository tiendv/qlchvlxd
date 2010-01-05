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
      
    public partial class Form3 : Form
    {
        tbsanphamServices msp;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            msp = new tbsanphamServices();
            DataSet ds;
            DataTable dt;
            ds = msp.getAllSanPham();
            dt = ds.Tables[0];

            dataGridView1.DataSource = dt;
        }
    }
}
