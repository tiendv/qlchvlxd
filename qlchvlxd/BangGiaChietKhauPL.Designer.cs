namespace qlchvlxd
{
    partial class BangGiaChietKhauPL
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
            this.label_BangGiaCK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_TenChietKhau = new System.Windows.Forms.Label();
            this.textBox_TenChietKhau = new System.Windows.Forms.TextBox();
            this.textBox_tiLeChietKhau = new System.Windows.Forms.TextBox();
            this.label_tiLeChietKhau = new System.Windows.Forms.Label();
            this.button_Thêm = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_ChietKhau = new System.Windows.Forms.ListView();
            this.columnHeader_STT = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_TenChietKhau = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_TiLeChietKhau = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_BangGiaCK
            // 
            this.label_BangGiaCK.AutoSize = true;
            this.label_BangGiaCK.Location = new System.Drawing.Point(177, 26);
            this.label_BangGiaCK.Name = "label_BangGiaCK";
            this.label_BangGiaCK.Size = new System.Drawing.Size(126, 13);
            this.label_BangGiaCK.TabIndex = 0;
            this.label_BangGiaCK.Text = "BẢNG GIÁ CHIẾT KHẤU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Thoat);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Sua);
            this.groupBox1.Controls.Add(this.button_Thêm);
            this.groupBox1.Controls.Add(this.textBox_tiLeChietKhau);
            this.groupBox1.Controls.Add(this.label_tiLeChietKhau);
            this.groupBox1.Controls.Add(this.textBox_TenChietKhau);
            this.groupBox1.Controls.Add(this.label_TenChietKhau);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoạt động";
            // 
            // label_TenChietKhau
            // 
            this.label_TenChietKhau.AutoSize = true;
            this.label_TenChietKhau.Location = new System.Drawing.Point(7, 20);
            this.label_TenChietKhau.Name = "label_TenChietKhau";
            this.label_TenChietKhau.Size = new System.Drawing.Size(85, 13);
            this.label_TenChietKhau.TabIndex = 0;
            this.label_TenChietKhau.Text = "Tên chiết khấu :";
            // 
            // textBox_TenChietKhau
            // 
            this.textBox_TenChietKhau.Location = new System.Drawing.Point(116, 16);
            this.textBox_TenChietKhau.Name = "textBox_TenChietKhau";
            this.textBox_TenChietKhau.Size = new System.Drawing.Size(140, 20);
            this.textBox_TenChietKhau.TabIndex = 1;
            // 
            // textBox_tiLeChietKhau
            // 
            this.textBox_tiLeChietKhau.Location = new System.Drawing.Point(116, 49);
            this.textBox_tiLeChietKhau.Name = "textBox_tiLeChietKhau";
            this.textBox_tiLeChietKhau.Size = new System.Drawing.Size(140, 20);
            this.textBox_tiLeChietKhau.TabIndex = 3;
            // 
            // label_tiLeChietKhau
            // 
            this.label_tiLeChietKhau.AutoSize = true;
            this.label_tiLeChietKhau.Location = new System.Drawing.Point(7, 56);
            this.label_tiLeChietKhau.Name = "label_tiLeChietKhau";
            this.label_tiLeChietKhau.Size = new System.Drawing.Size(103, 13);
            this.label_tiLeChietKhau.TabIndex = 2;
            this.label_tiLeChietKhau.Text = "Tỉ lệ chiết khấu (%) :";
            // 
            // button_Thêm
            // 
            this.button_Thêm.Location = new System.Drawing.Point(278, 13);
            this.button_Thêm.Name = "button_Thêm";
            this.button_Thêm.Size = new System.Drawing.Size(75, 23);
            this.button_Thêm.TabIndex = 4;
            this.button_Thêm.Text = "Thêm";
            this.button_Thêm.UseVisualStyleBackColor = true;
            this.button_Thêm.Click += new System.EventHandler(this.button_Thêm_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(372, 15);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 5;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(278, 46);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 6;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(372, 46);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 7;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_ChietKhau);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chiết khấu";
            // 
            // listView_ChietKhau
            // 
            this.listView_ChietKhau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_STT,
            this.columnHeader_TenChietKhau,
            this.columnHeader_TiLeChietKhau});
            this.listView_ChietKhau.FullRowSelect = true;
            this.listView_ChietKhau.GridLines = true;
            this.listView_ChietKhau.Location = new System.Drawing.Point(7, 20);
            this.listView_ChietKhau.Name = "listView_ChietKhau";
            this.listView_ChietKhau.Size = new System.Drawing.Size(452, 117);
            this.listView_ChietKhau.TabIndex = 0;
            this.listView_ChietKhau.UseCompatibleStateImageBehavior = false;
            this.listView_ChietKhau.View = System.Windows.Forms.View.Details;
            this.listView_ChietKhau.SelectedIndexChanged += new System.EventHandler(this.listView_ChietKhau_SelectedIndexChanged);
            // 
            // columnHeader_STT
            // 
            this.columnHeader_STT.Text = "STT";
            // 
            // columnHeader_TenChietKhau
            // 
            this.columnHeader_TenChietKhau.Text = "Tên chiết khấu";
            this.columnHeader_TenChietKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_TenChietKhau.Width = 209;
            // 
            // columnHeader_TiLeChietKhau
            // 
            this.columnHeader_TiLeChietKhau.Text = "Tỉ lệ chiết khấu %";
            this.columnHeader_TiLeChietKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_TiLeChietKhau.Width = 177;
            // 
            // BangGiaChietKhauPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_BangGiaCK);
            this.Name = "BangGiaChietKhauPL";
            this.Text = "Bảng giá chiết khấu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BangGiaCK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_tiLeChietKhau;
        private System.Windows.Forms.Label label_tiLeChietKhau;
        private System.Windows.Forms.TextBox textBox_TenChietKhau;
        private System.Windows.Forms.Label label_TenChietKhau;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Thêm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_ChietKhau;
        private System.Windows.Forms.ColumnHeader columnHeader_STT;
        private System.Windows.Forms.ColumnHeader columnHeader_TenChietKhau;
        private System.Windows.Forms.ColumnHeader columnHeader_TiLeChietKhau;
    }
}