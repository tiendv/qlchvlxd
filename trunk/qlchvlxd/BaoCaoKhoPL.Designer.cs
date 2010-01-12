namespace qlchvlxd
{
    partial class BaoCaoKhoPL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.listView_bcKho = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_In = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Location = new System.Drawing.Point(150, 47);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Thang.TabIndex = 2;
            // 
            // listView_bcKho
            // 
            this.listView_bcKho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_bcKho.FullRowSelect = true;
            this.listView_bcKho.Location = new System.Drawing.Point(23, 93);
            this.listView_bcKho.Name = "listView_bcKho";
            this.listView_bcKho.Size = new System.Drawing.Size(471, 159);
            this.listView_bcKho.TabIndex = 3;
            this.listView_bcKho.UseCompatibleStateImageBehavior = false;
            this.listView_bcKho.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã SP";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng Hiện Tại";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng SL Đã Nhập";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng Tiền ";
            this.columnHeader6.Width = 84;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(240, 258);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(98, 23);
            this.button_Thoat.TabIndex = 4;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_In
            // 
            this.button_In.Location = new System.Drawing.Point(344, 258);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(100, 23);
            this.button_In.TabIndex = 4;
            this.button_In.Text = "In Báo Cáo";
            this.button_In.UseVisualStyleBackColor = true;
            // 
            // BaoCaoKhoPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 293);
            this.Controls.Add(this.button_In);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.listView_bcKho);
            this.Controls.Add(this.comboBox_Thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoKhoPL";
            this.Text = "Báo Cáo Kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.ListView listView_bcKho;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_In;
    }
}