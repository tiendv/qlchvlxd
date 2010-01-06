namespace qlchvlxd
{
    partial class LapHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STTcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoGiaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_SanPham = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTTKH = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_GiaoHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.checkBox_TraGop = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maKHTT = new System.Windows.Forms.TextBox();
            this.checkBox_GiaoHang = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_SanPham.SuspendLayout();
            this.groupBoxTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(251, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(139, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LẬP HÓA ĐƠN BÁN HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTcolumn,
            this.TenSPColumn,
            this.SoLuongColumn,
            this.DoGiaColumn,
            this.thanhTienColumn});
            this.dataGridView1.Location = new System.Drawing.Point(33, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // STTcolumn
            // 
            this.STTcolumn.HeaderText = "STT";
            this.STTcolumn.Name = "STTcolumn";
            this.STTcolumn.Width = 50;
            // 
            // TenSPColumn
            // 
            this.TenSPColumn.HeaderText = "Ten san pham";
            this.TenSPColumn.Name = "TenSPColumn";
            this.TenSPColumn.Width = 150;
            // 
            // SoLuongColumn
            // 
            this.SoLuongColumn.HeaderText = "So luong";
            this.SoLuongColumn.Name = "SoLuongColumn";
            // 
            // DoGiaColumn
            // 
            this.DoGiaColumn.HeaderText = "Don gia";
            this.DoGiaColumn.Name = "DoGiaColumn";
            this.DoGiaColumn.Width = 110;
            // 
            // thanhTienColumn
            // 
            this.thanhTienColumn.HeaderText = "Thanh tien";
            this.thanhTienColumn.Name = "thanhTienColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xem hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox_SanPham
            // 
            this.groupBox_SanPham.Controls.Add(this.numericUpDown1);
            this.groupBox_SanPham.Controls.Add(this.button4);
            this.groupBox_SanPham.Controls.Add(this.label7);
            this.groupBox_SanPham.Controls.Add(this.comboBox3);
            this.groupBox_SanPham.Controls.Add(this.label6);
            this.groupBox_SanPham.Controls.Add(this.comboBox2);
            this.groupBox_SanPham.Controls.Add(this.label5);
            this.groupBox_SanPham.Location = new System.Drawing.Point(12, 163);
            this.groupBox_SanPham.Name = "groupBox_SanPham";
            this.groupBox_SanPham.Size = new System.Drawing.Size(588, 89);
            this.groupBox_SanPham.TabIndex = 16;
            this.groupBox_SanPham.TabStop = false;
            this.groupBox_SanPham.Text = "Sản phẩm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số lượng:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(417, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 21);
            this.comboBox3.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // groupBoxTTKH
            // 
            this.groupBoxTTKH.Controls.Add(this.checkBox_GiaoHang);
            this.groupBoxTTKH.Controls.Add(this.maKHTT);
            this.groupBoxTTKH.Controls.Add(this.checkBox_TraGop);
            this.groupBoxTTKH.Controls.Add(this.label8);
            this.groupBoxTTKH.Controls.Add(this.textBox3);
            this.groupBoxTTKH.Controls.Add(this.textBox2);
            this.groupBoxTTKH.Controls.Add(this.checkBox1);
            this.groupBoxTTKH.Controls.Add(this.textBox1);
            this.groupBoxTTKH.Controls.Add(this.label_GiaoHang);
            this.groupBoxTTKH.Controls.Add(this.label3);
            this.groupBoxTTKH.Controls.Add(this.label2);
            this.groupBoxTTKH.Controls.Add(this.label1);
            this.groupBoxTTKH.Controls.Add(this.labelTenKH);
            this.groupBoxTTKH.Location = new System.Drawing.Point(13, 47);
            this.groupBoxTTKH.Name = "groupBoxTTKH";
            this.groupBoxTTKH.Size = new System.Drawing.Size(587, 100);
            this.groupBoxTTKH.TabIndex = 17;
            this.groupBoxTTKH.TabStop = false;
            this.groupBoxTTKH.Text = "Thông tin khách hàng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(422, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label_GiaoHang
            // 
            this.label_GiaoHang.AutoSize = true;
            this.label_GiaoHang.Location = new System.Drawing.Point(19, 73);
            this.label_GiaoHang.Name = "label_GiaoHang";
            this.label_GiaoHang.Size = new System.Drawing.Size(59, 13);
            this.label_GiaoHang.TabIndex = 20;
            this.label_GiaoHang.Text = "Giao hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khách hàng thân thiết:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(19, 22);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(89, 13);
            this.labelTenKH.TabIndex = 16;
            this.labelTenKH.Text = "Tên khách hàng:";
            // 
            // checkBox_TraGop
            // 
            this.checkBox_TraGop.AutoSize = true;
            this.checkBox_TraGop.Location = new System.Drawing.Point(422, 73);
            this.checkBox_TraGop.Name = "checkBox_TraGop";
            this.checkBox_TraGop.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TraGop.TabIndex = 27;
            this.checkBox_TraGop.UseVisualStyleBackColor = true;
            this.checkBox_TraGop.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Trả góp:";
            // 
            // maKHTT
            // 
            this.maKHTT.Enabled = false;
            this.maKHTT.Location = new System.Drawing.Point(439, 14);
            this.maKHTT.Name = "maKHTT";
            this.maKHTT.Size = new System.Drawing.Size(138, 20);
            this.maKHTT.TabIndex = 28;
            // 
            // checkBox_GiaoHang
            // 
            this.checkBox_GiaoHang.AutoSize = true;
            this.checkBox_GiaoHang.Location = new System.Drawing.Point(115, 73);
            this.checkBox_GiaoHang.Name = "checkBox_GiaoHang";
            this.checkBox_GiaoHang.Size = new System.Drawing.Size(15, 14);
            this.checkBox_GiaoHang.TabIndex = 29;
            this.checkBox_GiaoHang.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(114, 47);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 30;
            // 
            // LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 483);
            this.Controls.Add(this.groupBoxTTKH);
            this.Controls.Add(this.groupBox_SanPham);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitle);
            this.Name = "LapHoaDon";
            this.Text = "frmLapHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_SanPham.ResumeLayout(false);
            this.groupBox_SanPham.PerformLayout();
            this.groupBoxTTKH.ResumeLayout(false);
            this.groupBoxTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoGiaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox_SanPham;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTTKH;
        private System.Windows.Forms.CheckBox checkBox_TraGop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_GiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.TextBox maKHTT;
        private System.Windows.Forms.CheckBox checkBox_GiaoHang;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}