namespace qlchvlxd
{
    partial class TimKhachHangPL
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
            this.textBox_Tim = new System.Windows.Forms.TextBox();
            this.button_Tim = new System.Windows.Forms.Button();
            this.listView_KH = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.rb_Hoten = new System.Windows.Forms.RadioButton();
            this.rb_CMND = new System.Windows.Forms.RadioButton();
            this.rb_Dienthoai = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_Tim
            // 
            this.textBox_Tim.Location = new System.Drawing.Point(77, 13);
            this.textBox_Tim.Name = "textBox_Tim";
            this.textBox_Tim.Size = new System.Drawing.Size(176, 20);
            this.textBox_Tim.TabIndex = 3;
            // 
            // button_Tim
            // 
            this.button_Tim.Location = new System.Drawing.Point(294, 12);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 23);
            this.button_Tim.TabIndex = 6;
            this.button_Tim.Text = "Tìm";
            this.button_Tim.UseVisualStyleBackColor = false;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // listView_KH
            // 
            this.listView_KH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_KH.FullRowSelect = true;
            this.listView_KH.Location = new System.Drawing.Point(16, 111);
            this.listView_KH.Name = "listView_KH";
            this.listView_KH.Size = new System.Drawing.Size(504, 245);
            this.listView_KH.TabIndex = 7;
            this.listView_KH.UseCompatibleStateImageBehavior = false;
            this.listView_KH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã khách hàng";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CMND";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đia chỉ";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện thoại";
            this.columnHeader5.Width = 68;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(526, 221);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(526, 282);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 9;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua__Click);
            // 
            // rb_Hoten
            // 
            this.rb_Hoten.AutoSize = true;
            this.rb_Hoten.Checked = true;
            this.rb_Hoten.Location = new System.Drawing.Point(32, 60);
            this.rb_Hoten.Name = "rb_Hoten";
            this.rb_Hoten.Size = new System.Drawing.Size(61, 17);
            this.rb_Hoten.TabIndex = 10;
            this.rb_Hoten.TabStop = true;
            this.rb_Hoten.Text = "Họ Tên";
            this.rb_Hoten.UseVisualStyleBackColor = true;
            // 
            // rb_CMND
            // 
            this.rb_CMND.AutoSize = true;
            this.rb_CMND.Location = new System.Drawing.Point(139, 60);
            this.rb_CMND.Name = "rb_CMND";
            this.rb_CMND.Size = new System.Drawing.Size(57, 17);
            this.rb_CMND.TabIndex = 11;
            this.rb_CMND.Text = "CMND";
            this.rb_CMND.UseVisualStyleBackColor = true;
            // 
            // rb_Dienthoai
            // 
            this.rb_Dienthoai.AutoSize = true;
            this.rb_Dienthoai.Location = new System.Drawing.Point(230, 60);
            this.rb_Dienthoai.Name = "rb_Dienthoai";
            this.rb_Dienthoai.Size = new System.Drawing.Size(77, 17);
            this.rb_Dienthoai.TabIndex = 12;
            this.rb_Dienthoai.Text = "Điện Thoại";
            this.rb_Dienthoai.UseVisualStyleBackColor = true;
            // 
            // TimKhachHangPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 389);
            this.Controls.Add(this.rb_Dienthoai);
            this.Controls.Add(this.rb_CMND);
            this.Controls.Add(this.rb_Hoten);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.listView_KH);
            this.Controls.Add(this.button_Tim);
            this.Controls.Add(this.textBox_Tim);
            this.Name = "TimKhachHangPL";
            this.Text = "Tìm kiếm khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Tim;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.ListView listView_KH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.RadioButton rb_Hoten;
        private System.Windows.Forms.RadioButton rb_CMND;
        private System.Windows.Forms.RadioButton rb_Dienthoai;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}