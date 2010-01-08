namespace qlchvlxd
{
    partial class ChamCongNVPL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hotenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynghiNV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm công nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotenNV,
            this.ngaysinhNV,
            this.gioitinhNV,
            this.loaiNV,
            this.ngaynghiNV});
            this.dataGridView1.Location = new System.Drawing.Point(13, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chấm công xong";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày chấm công :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 5;
            // 
            // hotenNV
            // 
            this.hotenNV.HeaderText = "Họ tên NV";
            this.hotenNV.Name = "hotenNV";
            this.hotenNV.Width = 300;
            // 
            // ngaysinhNV
            // 
            this.ngaysinhNV.HeaderText = "Ngày sinh NV";
            this.ngaysinhNV.Name = "ngaysinhNV";
            // 
            // gioitinhNV
            // 
            this.gioitinhNV.HeaderText = "Giới tính NV";
            this.gioitinhNV.Name = "gioitinhNV";
            // 
            // loaiNV
            // 
            this.loaiNV.HeaderText = "Loại NV";
            this.loaiNV.Name = "loaiNV";
            // 
            // ngaynghiNV
            // 
            this.ngaynghiNV.HeaderText = "Chấm công ngày nghỉ";
            this.ngaynghiNV.Name = "ngaynghiNV";
            this.ngaynghiNV.Width = 60;
            // 
            // ChamCongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 538);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ChamCongNV";
            this.Text = "ChamCongNV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ngaynghiNV;
    }
}