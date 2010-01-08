namespace qlchvlxd
{
    partial class LapHoaDonPL
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
            this.button_XemHD = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.groupBox_SanPham = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_TenSP = new System.Windows.Forms.ComboBox();
            this.label_TenSP = new System.Windows.Forms.Label();
            this.comboBox_LoaiSP = new System.Windows.Forms.ComboBox();
            this.label_LoaiSP = new System.Windows.Forms.Label();
            this.groupBoxTTKH = new System.Windows.Forms.GroupBox();
            this.checkBox_GiaoHang = new System.Windows.Forms.CheckBox();
            this.maKHTT = new System.Windows.Forms.TextBox();
            this.checkBox_TraGop = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DienThoai = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.checkBox_KHTT = new System.Windows.Forms.CheckBox();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.label_GiaoHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.listView_HoaDon = new System.Windows.Forms.ListView();
            this.column_STT = new System.Windows.Forms.ColumnHeader();
            this.column_TenSP = new System.Windows.Forms.ColumnHeader();
            this.column_SoLuong = new System.Windows.Forms.ColumnHeader();
            this.column_DonGia = new System.Windows.Forms.ColumnHeader();
            this.column_ThanhTien = new System.Windows.Forms.ColumnHeader();
            this.textBox_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MaCTHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            this.groupBoxTTKH.SuspendLayout();
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
            // button_XemHD
            // 
            this.button_XemHD.Location = new System.Drawing.Point(382, 467);
            this.button_XemHD.Name = "button_XemHD";
            this.button_XemHD.Size = new System.Drawing.Size(89, 23);
            this.button_XemHD.TabIndex = 12;
            this.button_XemHD.Text = "Xem hóa đơn";
            this.button_XemHD.UseVisualStyleBackColor = true;
            this.button_XemHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(514, 467);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 14;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox_SanPham
            // 
            this.groupBox_SanPham.Controls.Add(this.textBox_MaCTHD);
            this.groupBox_SanPham.Controls.Add(this.label5);
            this.groupBox_SanPham.Controls.Add(this.numericUpDown_SoLuong);
            this.groupBox_SanPham.Controls.Add(this.button_Them);
            this.groupBox_SanPham.Controls.Add(this.label7);
            this.groupBox_SanPham.Controls.Add(this.comboBox_TenSP);
            this.groupBox_SanPham.Controls.Add(this.label_TenSP);
            this.groupBox_SanPham.Controls.Add(this.comboBox_LoaiSP);
            this.groupBox_SanPham.Controls.Add(this.label_LoaiSP);
            this.groupBox_SanPham.Location = new System.Drawing.Point(13, 174);
            this.groupBox_SanPham.Name = "groupBox_SanPham";
            this.groupBox_SanPham.Size = new System.Drawing.Size(587, 117);
            this.groupBox_SanPham.TabIndex = 16;
            this.groupBox_SanPham.TabStop = false;
            this.groupBox_SanPham.Text = "Sản phẩm";
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(111, 67);
            this.numericUpDown_SoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_SoLuong.TabIndex = 30;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(470, 68);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(50, 23);
            this.button_Them.TabIndex = 29;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số lượng:";
            // 
            // comboBox_TenSP
            // 
            this.comboBox_TenSP.FormattingEnabled = true;
            this.comboBox_TenSP.Location = new System.Drawing.Point(414, 41);
            this.comboBox_TenSP.Name = "comboBox_TenSP";
            this.comboBox_TenSP.Size = new System.Drawing.Size(159, 21);
            this.comboBox_TenSP.TabIndex = 26;
            // 
            // label_TenSP
            // 
            this.label_TenSP.AutoSize = true;
            this.label_TenSP.Location = new System.Drawing.Point(295, 49);
            this.label_TenSP.Name = "label_TenSP";
            this.label_TenSP.Size = new System.Drawing.Size(78, 13);
            this.label_TenSP.TabIndex = 25;
            this.label_TenSP.Text = "Tên sản phẩm:";
            // 
            // comboBox_LoaiSP
            // 
            this.comboBox_LoaiSP.FormattingEnabled = true;
            this.comboBox_LoaiSP.Location = new System.Drawing.Point(111, 41);
            this.comboBox_LoaiSP.Name = "comboBox_LoaiSP";
            this.comboBox_LoaiSP.Size = new System.Drawing.Size(159, 21);
            this.comboBox_LoaiSP.TabIndex = 24;
            // 
            // label_LoaiSP
            // 
            this.label_LoaiSP.AutoSize = true;
            this.label_LoaiSP.Location = new System.Drawing.Point(15, 48);
            this.label_LoaiSP.Name = "label_LoaiSP";
            this.label_LoaiSP.Size = new System.Drawing.Size(79, 13);
            this.label_LoaiSP.TabIndex = 23;
            this.label_LoaiSP.Text = "Loại sản phẩm:";
            // 
            // groupBoxTTKH
            // 
            this.groupBoxTTKH.Controls.Add(this.textBox_MaHD);
            this.groupBoxTTKH.Controls.Add(this.label4);
            this.groupBoxTTKH.Controls.Add(this.checkBox_GiaoHang);
            this.groupBoxTTKH.Controls.Add(this.maKHTT);
            this.groupBoxTTKH.Controls.Add(this.checkBox_TraGop);
            this.groupBoxTTKH.Controls.Add(this.label8);
            this.groupBoxTTKH.Controls.Add(this.textBox_DienThoai);
            this.groupBoxTTKH.Controls.Add(this.textBox_DiaChi);
            this.groupBoxTTKH.Controls.Add(this.checkBox_KHTT);
            this.groupBoxTTKH.Controls.Add(this.textBox_TenKH);
            this.groupBoxTTKH.Controls.Add(this.label_GiaoHang);
            this.groupBoxTTKH.Controls.Add(this.label3);
            this.groupBoxTTKH.Controls.Add(this.label2);
            this.groupBoxTTKH.Controls.Add(this.label1);
            this.groupBoxTTKH.Controls.Add(this.label_TenKH);
            this.groupBoxTTKH.Location = new System.Drawing.Point(13, 53);
            this.groupBoxTTKH.Name = "groupBoxTTKH";
            this.groupBoxTTKH.Size = new System.Drawing.Size(587, 123);
            this.groupBoxTTKH.TabIndex = 17;
            this.groupBoxTTKH.TabStop = false;
            this.groupBoxTTKH.Text = "Thông tin khách hàng";
            // 
            // checkBox_GiaoHang
            // 
            this.checkBox_GiaoHang.AutoSize = true;
            this.checkBox_GiaoHang.Location = new System.Drawing.Point(111, 101);
            this.checkBox_GiaoHang.Name = "checkBox_GiaoHang";
            this.checkBox_GiaoHang.Size = new System.Drawing.Size(15, 14);
            this.checkBox_GiaoHang.TabIndex = 29;
            this.checkBox_GiaoHang.UseVisualStyleBackColor = true;
            // 
            // maKHTT
            // 
            this.maKHTT.Enabled = false;
            this.maKHTT.Location = new System.Drawing.Point(435, 42);
            this.maKHTT.Name = "maKHTT";
            this.maKHTT.Size = new System.Drawing.Size(138, 20);
            this.maKHTT.TabIndex = 28;
            // 
            // checkBox_TraGop
            // 
            this.checkBox_TraGop.AutoSize = true;
            this.checkBox_TraGop.Location = new System.Drawing.Point(418, 101);
            this.checkBox_TraGop.Name = "checkBox_TraGop";
            this.checkBox_TraGop.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TraGop.TabIndex = 27;
            this.checkBox_TraGop.UseVisualStyleBackColor = true;
            this.checkBox_TraGop.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Trả góp:";
            // 
            // textBox_DienThoai
            // 
            this.textBox_DienThoai.Location = new System.Drawing.Point(418, 72);
            this.textBox_DienThoai.Name = "textBox_DienThoai";
            this.textBox_DienThoai.Size = new System.Drawing.Size(159, 20);
            this.textBox_DienThoai.TabIndex = 24;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(111, 72);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(159, 20);
            this.textBox_DiaChi.TabIndex = 23;
            // 
            // checkBox_KHTT
            // 
            this.checkBox_KHTT.AutoSize = true;
            this.checkBox_KHTT.Location = new System.Drawing.Point(418, 45);
            this.checkBox_KHTT.Name = "checkBox_KHTT";
            this.checkBox_KHTT.Size = new System.Drawing.Size(15, 14);
            this.checkBox_KHTT.TabIndex = 22;
            this.checkBox_KHTT.UseVisualStyleBackColor = true;
            this.checkBox_KHTT.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Location = new System.Drawing.Point(111, 47);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(159, 20);
            this.textBox_TenKH.TabIndex = 21;
            // 
            // label_GiaoHang
            // 
            this.label_GiaoHang.AutoSize = true;
            this.label_GiaoHang.Location = new System.Drawing.Point(15, 101);
            this.label_GiaoHang.Name = "label_GiaoHang";
            this.label_GiaoHang.Size = new System.Drawing.Size(59, 13);
            this.label_GiaoHang.TabIndex = 20;
            this.label_GiaoHang.Text = "Giao hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khách hàng thân thiết:";
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.Location = new System.Drawing.Point(15, 50);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(89, 13);
            this.label_TenKH.TabIndex = 16;
            this.label_TenKH.Text = "Tên khách hàng:";
            // 
            // listView_HoaDon
            // 
            this.listView_HoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_STT,
            this.column_TenSP,
            this.column_SoLuong,
            this.column_DonGia,
            this.column_ThanhTien});
            this.listView_HoaDon.Location = new System.Drawing.Point(13, 297);
            this.listView_HoaDon.Name = "listView_HoaDon";
            this.listView_HoaDon.Size = new System.Drawing.Size(587, 150);
            this.listView_HoaDon.TabIndex = 18;
            this.listView_HoaDon.UseCompatibleStateImageBehavior = false;
            this.listView_HoaDon.View = System.Windows.Forms.View.Details;
            // 
            // column_STT
            // 
            this.column_STT.Text = "STT";
            this.column_STT.Width = 48;
            // 
            // column_TenSP
            // 
            this.column_TenSP.Text = "Tên sản phẩm";
            this.column_TenSP.Width = 198;
            // 
            // column_SoLuong
            // 
            this.column_SoLuong.Text = "Số lượng";
            this.column_SoLuong.Width = 69;
            // 
            // column_DonGia
            // 
            this.column_DonGia.Text = "Đơn giá";
            this.column_DonGia.Width = 135;
            // 
            // column_ThanhTien
            // 
            this.column_ThanhTien.Text = "Thành tiền";
            this.column_ThanhTien.Width = 131;
            // 
            // textBox_MaHD
            // 
            this.textBox_MaHD.Enabled = false;
            this.textBox_MaHD.Location = new System.Drawing.Point(111, 22);
            this.textBox_MaHD.Name = "textBox_MaHD";
            this.textBox_MaHD.Size = new System.Drawing.Size(159, 20);
            this.textBox_MaHD.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // textBox_MaCTHD
            // 
            this.textBox_MaCTHD.Enabled = false;
            this.textBox_MaCTHD.Location = new System.Drawing.Point(111, 16);
            this.textBox_MaCTHD.Name = "textBox_MaCTHD";
            this.textBox_MaCTHD.Size = new System.Drawing.Size(159, 20);
            this.textBox_MaCTHD.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã chi tiết hóa đơn";
            // 
            // LapHoaDonPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 496);
            this.Controls.Add(this.listView_HoaDon);
            this.Controls.Add(this.groupBoxTTKH);
            this.Controls.Add(this.groupBox_SanPham);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_XemHD);
            this.Controls.Add(this.labelTitle);
            this.Name = "LapHoaDonPL";
            this.Text = "Lập hóa đơn";
            this.Load += new System.EventHandler(this.LapHoaDon_Load);
            this.groupBox_SanPham.ResumeLayout(false);
            this.groupBox_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            this.groupBoxTTKH.ResumeLayout(false);
            this.groupBoxTTKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button_XemHD;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.GroupBox groupBox_SanPham;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_TenSP;
        private System.Windows.Forms.Label label_TenSP;
        private System.Windows.Forms.ComboBox comboBox_LoaiSP;
        private System.Windows.Forms.Label label_LoaiSP;
        private System.Windows.Forms.GroupBox groupBoxTTKH;
        private System.Windows.Forms.CheckBox checkBox_TraGop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DienThoai;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.CheckBox checkBox_KHTT;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.Label label_GiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TenKH;
        private System.Windows.Forms.TextBox maKHTT;
        private System.Windows.Forms.CheckBox checkBox_GiaoHang;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.ListView listView_HoaDon;
        private System.Windows.Forms.ColumnHeader column_STT;
        private System.Windows.Forms.ColumnHeader column_TenSP;
        private System.Windows.Forms.ColumnHeader column_SoLuong;
        private System.Windows.Forms.ColumnHeader column_DonGia;
        private System.Windows.Forms.ColumnHeader column_ThanhTien;
        private System.Windows.Forms.TextBox textBox_MaCTHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaHD;
        private System.Windows.Forms.Label label4;
    }
}