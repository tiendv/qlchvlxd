namespace qlchvlxd
{
    partial class NhapKhoPL
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
            this.label5 = new System.Windows.Forms.Label();
            this.listView_NhapKho = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_LSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_SPmoi = new System.Windows.Forms.Button();
            this.textBox_GiaBan = new System.Windows.Forms.TextBox();
            this.textBox_GiaMua = new System.Windows.Forms.TextBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SP = new System.Windows.Forms.ComboBox();
            this.button_Dong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách nhập kho";
            // 
            // listView_NhapKho
            // 
            this.listView_NhapKho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_NhapKho.FullRowSelect = true;
            this.listView_NhapKho.Location = new System.Drawing.Point(18, 194);
            this.listView_NhapKho.MultiSelect = false;
            this.listView_NhapKho.Name = "listView_NhapKho";
            this.listView_NhapKho.Size = new System.Drawing.Size(433, 149);
            this.listView_NhapKho.TabIndex = 11;
            this.listView_NhapKho.UseCompatibleStateImageBehavior = false;
            this.listView_NhapKho.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá mua";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá bán";
            this.columnHeader5.Width = 108;
            // 
            // button_Luu
            // 
            this.button_Luu.Location = new System.Drawing.Point(85, 362);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(75, 23);
            this.button_Luu.TabIndex = 13;
            this.button_Luu.Text = "Lưu kho";
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(197, 362);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 14;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_SP);
            this.groupBox1.Controls.Add(this.comboBox_LSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.button_SPmoi);
            this.groupBox1.Controls.Add(this.textBox_GiaBan);
            this.groupBox1.Controls.Add(this.textBox_GiaMua);
            this.groupBox1.Controls.Add(this.textBox_SoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập sản phẩm";
            // 
            // comboBox_LSP
            // 
            this.comboBox_LSP.FormattingEnabled = true;
            this.comboBox_LSP.Location = new System.Drawing.Point(102, 32);
            this.comboBox_LSP.Name = "comboBox_LSP";
            this.comboBox_LSP.Size = new System.Drawing.Size(166, 21);
            this.comboBox_LSP.TabIndex = 27;
            this.comboBox_LSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_LSP_MouseClick);
            this.comboBox_LSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_LSP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Loại sản phẩm";
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(283, 121);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 24;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_SPmoi
            // 
            this.button_SPmoi.Location = new System.Drawing.Point(283, 54);
            this.button_SPmoi.Name = "button_SPmoi";
            this.button_SPmoi.Size = new System.Drawing.Size(82, 23);
            this.button_SPmoi.TabIndex = 23;
            this.button_SPmoi.Text = "Sản phẩm mới";
            this.button_SPmoi.UseVisualStyleBackColor = true;
            this.button_SPmoi.Click += new System.EventHandler(this.button_SPmoi_Click);
            // 
            // textBox_GiaBan
            // 
            this.textBox_GiaBan.Location = new System.Drawing.Point(102, 123);
            this.textBox_GiaBan.Name = "textBox_GiaBan";
            this.textBox_GiaBan.Size = new System.Drawing.Size(166, 20);
            this.textBox_GiaBan.TabIndex = 22;
            // 
            // textBox_GiaMua
            // 
            this.textBox_GiaMua.Location = new System.Drawing.Point(102, 101);
            this.textBox_GiaMua.Name = "textBox_GiaMua";
            this.textBox_GiaMua.Size = new System.Drawing.Size(166, 20);
            this.textBox_GiaMua.TabIndex = 21;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(102, 79);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(166, 20);
            this.textBox_SoLuong.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sản phẩm";
            // 
            // comboBox_SP
            // 
            this.comboBox_SP.FormattingEnabled = true;
            this.comboBox_SP.Location = new System.Drawing.Point(102, 54);
            this.comboBox_SP.Name = "comboBox_SP";
            this.comboBox_SP.Size = new System.Drawing.Size(166, 21);
            this.comboBox_SP.TabIndex = 28;
            // 
            // button_Dong
            // 
            this.button_Dong.Location = new System.Drawing.Point(311, 361);
            this.button_Dong.Name = "button_Dong";
            this.button_Dong.Size = new System.Drawing.Size(75, 23);
            this.button_Dong.TabIndex = 16;
            this.button_Dong.Text = "Đóng";
            this.button_Dong.UseVisualStyleBackColor = true;
            this.button_Dong.Click += new System.EventHandler(this.button_Dong_Click);
            // 
            // NhapKhoPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 407);
            this.Controls.Add(this.button_Dong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.listView_NhapKho);
            this.Controls.Add(this.label5);
            this.Name = "NhapKhoPL";
            this.Text = "Nhập kho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView_NhapKho;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_SPmoi;
        private System.Windows.Forms.TextBox textBox_GiaBan;
        private System.Windows.Forms.TextBox textBox_GiaMua;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_LSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_SP;
        private System.Windows.Forms.Button button_Dong;
    }
}