﻿namespace qlchvlxd
{
    partial class BaoCaoKhachHangPL
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
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Tim = new System.Windows.Forms.Button();
            this.listView_bcKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên khách hàng:";
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Location = new System.Drawing.Point(133, 10);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(175, 20);
            this.textBox_TenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Báo cáo doanh số khách hàng";
            // 
            // button_Tim
            // 
            this.button_Tim.Location = new System.Drawing.Point(351, 10);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 23);
            this.button_Tim.TabIndex = 3;
            this.button_Tim.Text = "Tìm";
            this.button_Tim.UseVisualStyleBackColor = true;
            // 
            // listView_bcKH
            // 
            this.listView_bcKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_bcKH.Location = new System.Drawing.Point(19, 89);
            this.listView_bcKH.Name = "listView_bcKH";
            this.listView_bcKH.Size = new System.Drawing.Size(468, 160);
            this.listView_bcKH.TabIndex = 4;
            this.listView_bcKH.UseCompatibleStateImageBehavior = false;
            this.listView_bcKH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng doanh số";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doanh số trong tháng";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng nợ";
            // 
            // BaoCaoKhachHangPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 301);
            this.Controls.Add(this.listView_bcKH);
            this.Controls.Add(this.button_Tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenKH);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoKhachHangPL";
            this.Text = "Báo cáo khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.ListView listView_bcKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}