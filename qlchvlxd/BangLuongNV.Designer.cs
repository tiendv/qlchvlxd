﻿namespace qlchvlxd
{
    partial class BangLuongNV
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaydilam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng lương nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttNV,
            this.hotenNV,
            this.ngaysinhNV,
            this.gioitinhNV,
            this.loaiNV,
            this.songaydilam,
            this.ngaynghi,
            this.luong,
            this.tamung,
            this.conlai});
            this.dataGridView1.Location = new System.Drawing.Point(14, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 302);
            this.dataGridView1.TabIndex = 5;
            // 
            // sttNV
            // 
            this.sttNV.HeaderText = "STT";
            this.sttNV.Name = "sttNV";
            this.sttNV.Width = 30;
            // 
            // hotenNV
            // 
            this.hotenNV.HeaderText = "Họ tên NV";
            this.hotenNV.Name = "hotenNV";
            this.hotenNV.Width = 150;
            // 
            // ngaysinhNV
            // 
            this.ngaysinhNV.HeaderText = "Ngày sinh";
            this.ngaysinhNV.Name = "ngaysinhNV";
            this.ngaysinhNV.Width = 60;
            // 
            // gioitinhNV
            // 
            this.gioitinhNV.HeaderText = "Giới tính";
            this.gioitinhNV.Name = "gioitinhNV";
            this.gioitinhNV.Width = 50;
            // 
            // loaiNV
            // 
            this.loaiNV.HeaderText = "Loại NV";
            this.loaiNV.Name = "loaiNV";
            this.loaiNV.Width = 60;
            // 
            // songaydilam
            // 
            this.songaydilam.HeaderText = "Ngày đi làm";
            this.songaydilam.Name = "songaydilam";
            this.songaydilam.Width = 50;
            // 
            // ngaynghi
            // 
            this.ngaynghi.HeaderText = "Ngày nghỉ";
            this.ngaynghi.Name = "ngaynghi";
            this.ngaynghi.Width = 50;
            // 
            // luong
            // 
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            // 
            // tamung
            // 
            this.tamung.HeaderText = "Tạm ứng";
            this.tamung.Name = "tamung";
            // 
            // conlai
            // 
            this.conlai.HeaderText = "Còn lại";
            this.conlai.Name = "conlai";
            // 
            // BangLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "BangLuongNV";
            this.Text = "BangLuongNV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaydilam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamung;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlai;
    }
}